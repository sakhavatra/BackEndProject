#pragma checksum "C:\Users\Admin\Desktop\Backend-Final\Juan\Juan\Views\Account\MyAccount.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "886b3480398c59ed8be01450db473c4410540ccd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_MyAccount), @"mvc.1.0.view", @"/Views/Account/MyAccount.cshtml")]
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
#line 2 "C:\Users\Admin\Desktop\Backend-Final\Juan\Juan\Views\_ViewImports.cshtml"
using Juan.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Admin\Desktop\Backend-Final\Juan\Juan\Views\_ViewImports.cshtml"
using Juan.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Admin\Desktop\Backend-Final\Juan\Juan\Views\_ViewImports.cshtml"
using Juan.Services;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"886b3480398c59ed8be01450db473c4410540ccd", @"/Views/Account/MyAccount.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b705268eb85f917cf99ee8529dca17fb70bcbc02", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_MyAccount : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UserProfileVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Order", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetMyOrder", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Admin\Desktop\Backend-Final\Juan\Juan\Views\Account\MyAccount.cshtml"
  
    ViewData["Title"] = "MyAccount";
    int orderCount = 1;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<main>
    <!-- breadcrumb area start -->
    <div class=""breadcrumb-area bg-img"" data-bg=""assets/img/banner/breadcrumb-banner.jpg"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-12"">
                    <div class=""breadcrumb-wrap text-center"">
                        <nav aria-label=""breadcrumb"">
                            <h1 class=""breadcrumb-title"">My Account</h1>
                            <ul class=""breadcrumb"">
                                <li class=""breadcrumb-item""><a href=""index.html"">Home</a></li>
                                <li class=""breadcrumb-item active"" aria-current=""page"">My Account</li>
                            </ul>
                        </nav>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- breadcrumb area end -->
    <!-- my account wrapper start -->
    <div class=""my-account-wrapper section-padding"">
        <div class=""container custom-containe");
            WriteLiteral(@"r"">
            <div class=""row"">
                <div class=""col-lg-12"">
                    <!-- My Account Page Start -->
                    <div class=""myaccount-page-wrapper"">
                        <!-- My Account Tab Menu Start -->
                        <div class=""row"">
                            <div class=""col-lg-3 col-md-4"">
                                <div class=""myaccount-tab-menu nav"" role=""tablist"">
                                    <a href=""#dashboad"" class=""active"" data-toggle=""tab"" >
                                        <i class=""fa fa-dashboard""></i>
                                        Dashboard
                                    </a>
                                    <a href=""#orders"" data-toggle=""tab""><i class=""fa fa-cart-arrow-down""></i> Orders</a>
                                    <a href=""#download"" data-toggle=""tab""><i class=""fa fa-cloud-download""></i> Download</a>
                                    <a href=""#payment-method"" data-toggle=""tab"">
 ");
            WriteLiteral(@"                                       <i class=""fa fa-credit-card""></i> Payment
                                        Method
                                    </a>
                                    <a href=""#address-edit"" data-toggle=""tab""><i class=""fa fa-map-marker""></i> address</a>
                                    <a href=""#account-info"" data-toggle=""tab""");
            BeginWriteAttribute("aria-selected", " aria-selected=\"", 2513, "\"", 2629, 1);
#nullable restore
#line 49 "C:\Users\Admin\Desktop\Backend-Final\Juan\Juan\Views\Account\MyAccount.cshtml"
WriteAttributeValue("", 2529, (TempData["ProfileTab"] != null && TempData["ProfileTab"].ToString() == "Account"?"true":"false"), 2529, 100, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 2630, "\"", 2735, 1);
#nullable restore
#line 49 "C:\Users\Admin\Desktop\Backend-Final\Juan\Juan\Views\Account\MyAccount.cshtml"
WriteAttributeValue("", 2638, (TempData["ProfileTab"] != null && TempData["ProfileTab"].ToString() == "Account"?"active":""), 2638, 97, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"><i class=""fa fa-user""></i> Account Details</a>
                                    <a href=""login-register.html""><i class=""fa fa-sign-out""></i> Logout</a>
                                </div>
                            </div>
                            <!-- My Account Tab Menu End -->
                            <!-- My Account Tab Content Start -->
                            <div class=""col-lg-9 col-md-8"">
                                <div class=""tab-content"" id=""myaccountContent"">
                                    <!-- Single Tab Content Start -->
                                    <div class=""tab-pane fade show active"" id=""dashboad"" role=""tabpanel"">
                                        <div class=""myaccount-content"">
                                            <h3>Dashboard</h3>
                                            <div class=""welcome"">
                                                <p>Hello, <strong>Alex Tuntuni</strong> (If Not <strong>Tuntuni !</strong><a href=""login-");
            WriteLiteral(@"register.html"" class=""logout""> Logout</a>)</p>
                                            </div>
                                            <p class=""mb-0"">From your account dashboard. you can easily check & view your recent orders, manage your shipping and billing addresses and edit your password and account details.</p>
                                        </div>
                                    </div>
                                    <!-- Single Tab Content End -->
                                    <!-- Single Tab Content Start -->
                                    <div class=""tab-pane fade"" id=""orders"" role=""tabpanel"">
                                        <div class=""myaccount-content"">
                                            <h3>Orders</h3>
                                            <div class=""myaccount-table table-responsive text-center"">
                                                <table class=""table table-bordered"">
                                              ");
            WriteLiteral(@"      <thead class=""thead-light"">
                                                        <tr>
                                                            <th>Order</th>
                                                            <th>Date</th>
                                                            <th>Status</th>
                                                            <th>Total</th>
                                                            <th>Action</th>
                                                        </tr>
                                                    </thead>
                                                    <tbody>
");
#nullable restore
#line 84 "C:\Users\Admin\Desktop\Backend-Final\Juan\Juan\Views\Account\MyAccount.cshtml"
                                                         foreach (Order order in Model.Orders)
                                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                            <tr>\r\n                                                                <td>");
#nullable restore
#line 87 "C:\Users\Admin\Desktop\Backend-Final\Juan\Juan\Views\Account\MyAccount.cshtml"
                                                               Write(orderCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                                <td>");
#nullable restore
#line 88 "C:\Users\Admin\Desktop\Backend-Final\Juan\Juan\Views\Account\MyAccount.cshtml"
                                                               Write(order.CreatedAt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                                <td>");
#nullable restore
#line 89 "C:\Users\Admin\Desktop\Backend-Final\Juan\Juan\Views\Account\MyAccount.cshtml"
                                                               Write(order.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                                <td>$");
#nullable restore
#line 90 "C:\Users\Admin\Desktop\Backend-Final\Juan\Juan\Views\Account\MyAccount.cshtml"
                                                                Write(order.TotalPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                                <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "886b3480398c59ed8be01450db473c4410540ccd12591", async() => {
                WriteLiteral("View");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-orderId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 91 "C:\Users\Admin\Desktop\Backend-Final\Juan\Juan\Views\Account\MyAccount.cshtml"
                                                                                                                             WriteLiteral(order.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["orderId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-orderId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["orderId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 91 "C:\Users\Admin\Desktop\Backend-Final\Juan\Juan\Views\Account\MyAccount.cshtml"
                                                                                                                                                            WriteLiteral(order.AppUser.Name);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["UserName"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-UserName", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["UserName"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n                                                            </tr>\r\n");
#nullable restore
#line 93 "C:\Users\Admin\Desktop\Backend-Final\Juan\Juan\Views\Account\MyAccount.cshtml"
                                                            orderCount += 1;
                                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                    </tbody>
                                                </table>
                                            </div>
                                        </div>
                                    </div>
                                    <!-- Single Tab Content End -->
                                    <!-- Single Tab Content Start -->
                                    <div class=""tab-pane fade"" id=""download"" role=""tabpanel"">
                                        <div class=""myaccount-content"">
                                            <h3>Downloads</h3>
                                            <div class=""myaccount-table table-responsive text-center"">
                                                <table class=""table table-bordered"">
                                                    <thead class=""thead-light"">
                                                        <tr>
                                                       ");
            WriteLiteral(@"     <th>Product</th>
                                                            <th>Date</th>
                                                            <th>Expire</th>
                                                            <th>Download</th>
                                                        </tr>
                                                    </thead>
                                                    <tbody>
                                                        <tr>
                                                            <td>Haven - Free Real Estate PSD Template</td>
                                                            <td>Aug 22, 2018</td>
                                                            <td>Yes</td>
                                                            <td><a href=""#"" class=""btn ""><i class=""fa fa-cloud-download""></i> Download File</a></td>
                                                        </tr>
                                            ");
            WriteLiteral(@"            <tr>
                                                            <td>HasTech - Profolio Business Template</td>
                                                            <td>Sep 12, 2018</td>
                                                            <td>Never</td>
                                                            <td><a href=""#"" class=""btn ""><i class=""fa fa-cloud-download""></i> Download File</a></td>
                                                        </tr>
                                                    </tbody>
                                                </table>
                                            </div>
                                        </div>
                                    </div>
                                    <!-- Single Tab Content End -->
                                    <!-- Single Tab Content Start -->
                                    <div class=""tab-pane fade"" id=""payment-method"" role=""tabpanel"">
                      ");
            WriteLiteral(@"                  <div class=""myaccount-content"">
                                            <h3>Payment Method</h3>
                                            <p class=""saved-message"">You Can't Saved Your Payment Method yet.</p>
                                        </div>
                                    </div>
                                    <!-- Single Tab Content End -->
                                    <!-- Single Tab Content Start -->
                                    <div class=""tab-pane fade"" id=""address-edit"" role=""tabpanel"">
                                        <div class=""myaccount-content"">
                                            <h3>Billing Address</h3>
                                            <address>
                                                <p><strong>Alex Tuntuni</strong></p>
                                                <p>
                                                    1355 Market St, Suite 900 <br>
                                     ");
            WriteLiteral(@"               San Francisco, CA 94103
                                                </p>
                                                <p>Mobile: (123) 456-7890</p>
                                            </address>
                                            <a href=""#"" class=""check-btn sqr-btn ""><i class=""fa fa-edit""></i> Edit Address</a>
                                        </div>
                                    </div>
                                    <!-- Single Tab Content End -->
                                    <!-- Single Tab Content Start -->
                                    <div");
            BeginWriteAttribute("class", " class=\"", 11173, "\"", 11297, 3);
            WriteAttributeValue("", 11181, "tab-pane", 11181, 8, true);
            WriteAttributeValue(" ", 11189, "fade", 11190, 5, true);
#nullable restore
#line 159 "C:\Users\Admin\Desktop\Backend-Final\Juan\Juan\Views\Account\MyAccount.cshtml"
WriteAttributeValue(" ", 11194, (TempData["ProfileTab"] != null && TempData["ProfileTab"].ToString() == "Account"?"active show":""), 11195, 102, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" id=""account-info"" role=""tabpanel"">
                                        <div class=""myaccount-content"">
                                            <h3>Account Details</h3>
                                            <div class=""account-details-form"">
                                                ");
#nullable restore
#line 163 "C:\Users\Admin\Desktop\Backend-Final\Juan\Juan\Views\Account\MyAccount.cshtml"
                                           Write(await Html.PartialAsync("_AccountDetailPartial", Model.Member));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                            </div>
                                        </div>
                                    </div> <!-- Single Tab Content End -->
                                </div>
                            </div> <!-- My Account Tab Content End -->
                        </div>
                    </div> <!-- My Account Page End -->
                </div>
            </div>
        </div>
    </div>
    <!-- my account wrapper end -->
</main>
");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UserProfileVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
