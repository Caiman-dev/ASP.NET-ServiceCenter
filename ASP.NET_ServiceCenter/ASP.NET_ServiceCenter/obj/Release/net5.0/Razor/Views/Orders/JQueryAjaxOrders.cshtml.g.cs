#pragma checksum "D:\Developer\GitHub\ASP.NET-ServiceCenter\ASP.NET_ServiceCenter\ASP.NET_ServiceCenter\Views\Orders\JQueryAjaxOrders.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bc2320260724d7e3167f581a72247aff8ee43f0f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orders_JQueryAjaxOrders), @"mvc.1.0.view", @"/Views/Orders/JQueryAjaxOrders.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\Developer\GitHub\ASP.NET-ServiceCenter\ASP.NET_ServiceCenter\ASP.NET_ServiceCenter\Views\_ViewImports.cshtml"
using ASP.NET_ServiceCenter;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Developer\GitHub\ASP.NET-ServiceCenter\ASP.NET_ServiceCenter\ASP.NET_ServiceCenter\Views\_ViewImports.cshtml"
using ASP.NET_ServiceCenter.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\Developer\GitHub\ASP.NET-ServiceCenter\ASP.NET_ServiceCenter\ASP.NET_ServiceCenter\Views\Orders\JQueryAjaxOrders.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Developer\GitHub\ASP.NET-ServiceCenter\ASP.NET_ServiceCenter\ASP.NET_ServiceCenter\Views\Orders\JQueryAjaxOrders.cshtml"
using ASP.NET_ServiceCenter.Areas.Identity.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc2320260724d7e3167f581a72247aff8ee43f0f", @"/Views/Orders/JQueryAjaxOrders.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"715a40f390a924d5fcbf5ca79c8715257c2a4206", @"/Views/_ViewImports.cshtml")]
    public class Views_Orders_JQueryAjaxOrders : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ASP.NET_ServiceCenter.ViewModels.OrdersViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 7 "D:\Developer\GitHub\ASP.NET-ServiceCenter\ASP.NET_ServiceCenter\ASP.NET_ServiceCenter\Views\Orders\JQueryAjaxOrders.cshtml"
  
    ViewBag.Title = "Orders";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n    <main role=\"main\" class=\"pb-3\">\r\n        <br /><br />\r\n        <h2>Orders</h2>\r\n\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bc2320260724d7e3167f581a72247aff8ee43f0f6308", async() => {
                WriteLiteral("\r\n            <div class=\"form-group col-2 p-0\">\r\n");
#nullable restore
#line 18 "D:\Developer\GitHub\ASP.NET-ServiceCenter\ASP.NET_ServiceCenter\ASP.NET_ServiceCenter\Views\Orders\JQueryAjaxOrders.cshtml"
                 if (SignInManager.IsSignedIn(User))
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "D:\Developer\GitHub\ASP.NET-ServiceCenter\ASP.NET_ServiceCenter\ASP.NET_ServiceCenter\Views\Orders\JQueryAjaxOrders.cshtml"
                     if (await UserManager.IsInRoleAsync(await UserManager.GetUserAsync(User), "Admin"))
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "D:\Developer\GitHub\ASP.NET-ServiceCenter\ASP.NET_ServiceCenter\ASP.NET_ServiceCenter\Views\Orders\JQueryAjaxOrders.cshtml"
                   Write(Html.DropDownListFor(m => m.Masters, new SelectList(Model.Masters, "UserName", "UserName"), "Select master", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <br />\r\n                        <h5>Total amount:</h5>\r\n                        <input class=\"form-control\" id=\"totalAmount\" type=\"text\" readonly=\"readonly\" />\r\n");
#nullable restore
#line 26 "D:\Developer\GitHub\ASP.NET-ServiceCenter\ASP.NET_ServiceCenter\ASP.NET_ServiceCenter\Views\Orders\JQueryAjaxOrders.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "D:\Developer\GitHub\ASP.NET-ServiceCenter\ASP.NET_ServiceCenter\ASP.NET_ServiceCenter\Views\Orders\JQueryAjaxOrders.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"            </div>

            <script type=""text/javascript"">

        //передача JSON при помощи JQuery по методу POST
        $('#Masters').change(function (e) {

            // получить значение выпадающего списка при помощи JQuery
            var cr = $('#Masters').val();
            let sum = 0;

            // подача Ajax-запроса на сервер при помощи JQuery
            $.ajax({
                url: '");
#nullable restore
#line 41 "D:\Developer\GitHub\ASP.NET-ServiceCenter\ASP.NET_ServiceCenter\ASP.NET_ServiceCenter\Views\Orders\JQueryAjaxOrders.cshtml"
                 Write(Url.Action("OrdersListJson", "Orders"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"',
                method: ""POST"",
                data: JSON.stringify({
                    master: cr
                }),
                dataType: 'json',
                contentType: 'application/json',
                cache: false,
                processData: true,
                success: function (data) {
                    console.log(data);

                    // получить ссылку на таблицу с результатами
                    var table = $('#ordersTable');

                    // удалить все старые строки
                    table.find(""tbody tr"").remove();

                    // перебрать коллекцию в Json и создать новые строки таблицы на их основе
                    data.forEach(function (orders) {
                        table.append(""<tr><td>"" + orders.product_id + ""</td><td>"" + orders.user_id + ""</td><td>"" + orders.user_name + ""</td><td>"" + orders.client_id + ""</td><td>"" + orders.date_start + ""</td><td>"" + orders.date_end + ""</td><td>"" + orders.price + ""</td></tr>"");
   ");
                WriteLiteral(@"                 });

                    //показать общую сумму по выбранному мастеру
                    data.forEach(function (orders) {
                        sum += orders.price;
                        $('#totalAmount').val(sum)
                    });
                }
            })
        });
            </script>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        <br />

        <div id=""results"" class=""form-group"">
            <table id=""ordersTable"" class=""table table-bordered table-hover"">
                <thead>
                    <tr>
                        <th>product_id</th>
                        <th>user_id</th>
                        <th>user_name</th>
                        <th>client_id</th>
                        <th>date_start</th>
                        <th>date_end</th>
                        <th>price</th>
                        <th>options</th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 91 "D:\Developer\GitHub\ASP.NET-ServiceCenter\ASP.NET_ServiceCenter\ASP.NET_ServiceCenter\Views\Orders\JQueryAjaxOrders.cshtml"
                     foreach (var order in Model.Orders)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 94 "D:\Developer\GitHub\ASP.NET-ServiceCenter\ASP.NET_ServiceCenter\ASP.NET_ServiceCenter\Views\Orders\JQueryAjaxOrders.cshtml"
                           Write(order.product_id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 95 "D:\Developer\GitHub\ASP.NET-ServiceCenter\ASP.NET_ServiceCenter\ASP.NET_ServiceCenter\Views\Orders\JQueryAjaxOrders.cshtml"
                           Write(order.user_id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 96 "D:\Developer\GitHub\ASP.NET-ServiceCenter\ASP.NET_ServiceCenter\ASP.NET_ServiceCenter\Views\Orders\JQueryAjaxOrders.cshtml"
                           Write(order.user_name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 97 "D:\Developer\GitHub\ASP.NET-ServiceCenter\ASP.NET_ServiceCenter\ASP.NET_ServiceCenter\Views\Orders\JQueryAjaxOrders.cshtml"
                           Write(order.client_id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 98 "D:\Developer\GitHub\ASP.NET-ServiceCenter\ASP.NET_ServiceCenter\ASP.NET_ServiceCenter\Views\Orders\JQueryAjaxOrders.cshtml"
                           Write(order.date_start);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 99 "D:\Developer\GitHub\ASP.NET-ServiceCenter\ASP.NET_ServiceCenter\ASP.NET_ServiceCenter\Views\Orders\JQueryAjaxOrders.cshtml"
                           Write(order.date_end);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 100 "D:\Developer\GitHub\ASP.NET-ServiceCenter\ASP.NET_ServiceCenter\ASP.NET_ServiceCenter\Views\Orders\JQueryAjaxOrders.cshtml"
                           Write(order.price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bc2320260724d7e3167f581a72247aff8ee43f0f15139", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 102 "D:\Developer\GitHub\ASP.NET-ServiceCenter\ASP.NET_ServiceCenter\ASP.NET_ServiceCenter\Views\Orders\JQueryAjaxOrders.cshtml"
                                                       WriteLiteral(order.id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bc2320260724d7e3167f581a72247aff8ee43f0f17382", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 103 "D:\Developer\GitHub\ASP.NET-ServiceCenter\ASP.NET_ServiceCenter\ASP.NET_ServiceCenter\Views\Orders\JQueryAjaxOrders.cshtml"
                                                          WriteLiteral(order.id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bc2320260724d7e3167f581a72247aff8ee43f0f19631", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 104 "D:\Developer\GitHub\ASP.NET-ServiceCenter\ASP.NET_ServiceCenter\ASP.NET_ServiceCenter\Views\Orders\JQueryAjaxOrders.cshtml"
                                                         WriteLiteral(order.id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 107 "D:\Developer\GitHub\ASP.NET-ServiceCenter\ASP.NET_ServiceCenter\ASP.NET_ServiceCenter\Views\Orders\JQueryAjaxOrders.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n\r\n        <p>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bc2320260724d7e3167f581a72247aff8ee43f0f22274", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </p>\r\n    </main>\r\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<ApplicationUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<ApplicationUser> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ASP.NET_ServiceCenter.ViewModels.OrdersViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591