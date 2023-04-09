using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ASP.NET_ServiceCenter.Areas.Identity.Data;
using ASP.NET_ServiceCenter.Models;
using Microsoft.AspNetCore.Authorization;
using ASP.NET_ServiceCenter.ViewModels;
using System.Text.Json;

namespace ASP.NET_ServiceCenter.Controllers
{
    [Authorize(Roles = "Master")]
    public class OrdersController : Controller
    {
        private readonly ApplicationDBContext _context;

        public OrdersController(ApplicationDBContext context)
        {
            _context = context;
        }

        // GET: Orders
        public async Task<IActionResult> Index()
        {
            return View(await _context.Orders.ToListAsync());
        }

        // GET: Orders/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orders = await _context.Orders
                .FirstOrDefaultAsync(m => m.id == id);
            if (orders == null)
            {
                return NotFound();
            }

            return View(orders);
        }

        // GET: Orders/Create
        public IActionResult Create()
        {
            ViewData["client_id"] = new SelectList(_context.Clients, "id", "name");
            ViewData["product_id"] = new SelectList(_context.Products, "id", "model");
            return View();
        }

        // POST: Orders/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,product_id,user_id,user_name,client_id,date_start,date_end,price")] Orders orders)
        {
            if (ModelState.IsValid)
            {
                _context.Add(orders);
                await _context.SaveChangesAsync();
                return RedirectToAction("JQueryAjax");
            }
            ViewData["client_id"] = new SelectList(_context.Clients, "id", "name", orders.client_id);
            ViewData["product_id"] = new SelectList(_context.Products, "id", "model", orders.product_id);
            return View(orders);
        }

        // GET: Orders/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orders = await _context.Orders.FindAsync(id);
            if (orders == null)
            {
                return NotFound();
            }
            return View(orders);
        }

        // POST: Orders/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,product_id,user_id,user_name,client_id,date_start,date_end,price")] Orders orders)
        {
            if (id != orders.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(orders);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrdersExists(orders.id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("JQueryAjax");
            }
            return View(orders);
        }

        // GET: Orders/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orders = await _context.Orders
                .FirstOrDefaultAsync(m => m.id == id);
            if (orders == null)
            {
                return NotFound();
            }

            return View(orders);
        }

        // POST: Orders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var orders = await _context.Orders.FindAsync(id);
            _context.Orders.Remove(orders);
            await _context.SaveChangesAsync();
            return RedirectToAction("JQueryAjax");
        }

        private bool OrdersExists(int id)
        {
            return _context.Orders.Any(e => e.id == id);
        }

        //-------------------------------------------------------------------------------------
        //JQueryAjax
        public ActionResult JQueryAjax()
        {
            var viewModel = new OrdersViewModel
            {
                Orders = _context.Orders.ToList(),
                Masters = _context.Users.ToList()
            };

            return View("JQueryAjaxOrders", viewModel);
        }


        //метод вызывается из Ajax.Html и возвращает JSON, который содержит коллекцию результатов 
        [HttpPost]
        public JsonResult OrdersListJson([FromBody] object body)
        {
            var dict = System.Text.Json.JsonSerializer.Deserialize<Dictionary<string, string>>(body.ToString());
            string master = dict["master"];

            IEnumerable<Orders> filteredOrders = null;

            if (master != null)
                filteredOrders = from p in _context.Orders.ToList()
                                 where p.user_name.Equals(master)
                                 select p;
            else
                filteredOrders = from p in _context.Orders.ToList()
                                 select p;

            // преобразовать результирующую коллекцию в формат Json и возвратить
            var result = Json(filteredOrders, new JsonSerializerOptions
            {
                PropertyNamingPolicy = null
            });

            return result;
        }
    }
}
