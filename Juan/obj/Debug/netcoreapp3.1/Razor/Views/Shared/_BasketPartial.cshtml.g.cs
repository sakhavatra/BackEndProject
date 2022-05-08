#pragma checksum "C:\Users\Admin\Desktop\Backend-Final\Juan\Juan\Views\Shared\_BasketPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9c31efcf6cafa89d12c9210466c5526e1ccef3e4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__BasketPartial), @"mvc.1.0.view", @"/Views/Shared/_BasketPartial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c31efcf6cafa89d12c9210466c5526e1ccef3e4", @"/Views/Shared/_BasketPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b705268eb85f917cf99ee8529dca17fb70bcbc02", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__BasketPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BasketVM>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("product"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("minicart-remove deletecard"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteCard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Basket", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Admin\Desktop\Backend-Final\Juan\Juan\Views\Shared\_BasketPartial.cshtml"
   double subTotal = 0;

    double total = 0;
    foreach (var item in Model)
    {
        total += (item.Price * item.Count);
    } 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n\n<div class=\"minicart-item-wrapper\">\n    <ul>\n");
#nullable restore
#line 14 "C:\Users\Admin\Desktop\Backend-Final\Juan\Juan\Views\Shared\_BasketPartial.cshtml"
         foreach (BasketVM basketVM in Model)
        {


#line default
#line hidden
#nullable disable
            WriteLiteral("        <li class=\"minicart-item\">\n            <div class=\"minicart-thumb\">\n                <a href=\"product-details.html\">\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9c31efcf6cafa89d12c9210466c5526e1ccef3e45816", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 425, "~/user/assets/img/product/", 425, 26, true);
#nullable restore
#line 20 "C:\Users\Admin\Desktop\Backend-Final\Juan\Juan\Views\Shared\_BasketPartial.cshtml"
AddHtmlAttributeValue("", 451, basketVM.Image, 451, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                </a>\n            </div>\n            <div class=\"minicart-content\">\n                <h3 class=\"product-name\">\n                    <a href=\"product-details.html\">");
#nullable restore
#line 25 "C:\Users\Admin\Desktop\Backend-Final\Juan\Juan\Views\Shared\_BasketPartial.cshtml"
                                              Write(basketVM.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n                </h3>\n                <p>\n                    <span class=\"cart-quantity\">");
#nullable restore
#line 28 "C:\Users\Admin\Desktop\Backend-Final\Juan\Juan\Views\Shared\_BasketPartial.cshtml"
                                           Write(basketVM.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("<strong>&times;</strong></span>\n                    <span class=\"cart-price\">$");
#nullable restore
#line 29 "C:\Users\Admin\Desktop\Backend-Final\Juan\Juan\Views\Shared\_BasketPartial.cshtml"
                                         Write(basketVM.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                </p>\n\n                <p>\n                    <span class=\"pro-colo \" style=\"margin-right:1rem\">Size:");
#nullable restore
#line 33 "C:\Users\Admin\Desktop\Backend-Final\Juan\Juan\Views\Shared\_BasketPartial.cshtml"
                                                                      Write(basketVM.Color);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                    <span class=\"pro-size\">Color:");
#nullable restore
#line 34 "C:\Users\Admin\Desktop\Backend-Final\Juan\Juan\Views\Shared\_BasketPartial.cshtml"
                                            Write(basketVM.Size);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                </p>\n            </div>\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9c31efcf6cafa89d12c9210466c5526e1ccef3e49353", async() => {
                WriteLiteral("<i class=\"ion-android-close\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 37 "C:\Users\Admin\Desktop\Backend-Final\Juan\Juan\Views\Shared\_BasketPartial.cshtml"
                                                                            WriteLiteral(basketVM.ProductId);

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
            WriteLiteral("\n        </li>\n");
#nullable restore
#line 39 "C:\Users\Admin\Desktop\Backend-Final\Juan\Juan\Views\Shared\_BasketPartial.cshtml"
            subTotal += (basketVM.Price * basketVM.Count);
         }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </ul>\n</div>\n\n<div class=\"minicart-pricing-box\">\n    <ul>\n        <li>\n            <span>sub-total</span>\n            <span><strong>$");
#nullable restore
#line 49 "C:\Users\Admin\Desktop\Backend-Final\Juan\Juan\Views\Shared\_BasketPartial.cshtml"
                      Write(subTotal);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></span>\n        </li>\n        <li>\n            <span>Eco Tax</span>\n            <span><strong>$");
#nullable restore
#line 53 "C:\Users\Admin\Desktop\Backend-Final\Juan\Juan\Views\Shared\_BasketPartial.cshtml"
                       Write((subTotal*18)/100);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></span>\n        </li>\n        <li>\n            <span>Shipping</span>\n            <span><strong>$");
#nullable restore
#line 57 "C:\Users\Admin\Desktop\Backend-Final\Juan\Juan\Views\Shared\_BasketPartial.cshtml"
                       Write((subTotal*5)/100);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></span>\n        </li>\n        <li class=\"total\">\n            <span>total</span>\n            <span><strong>$");
#nullable restore
#line 61 "C:\Users\Admin\Desktop\Backend-Final\Juan\Juan\Views\Shared\_BasketPartial.cshtml"
                       Write(subTotal+ ((subTotal * 18) / 100)+ ((subTotal * 5) / 100));

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></span>\n        </li>\n    </ul>\n</div>\n\n<div class=\"minicart-button\">\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9c31efcf6cafa89d12c9210466c5526e1ccef3e413524", async() => {
                WriteLiteral("<i class=\"fa fa-shopping-cart\"></i> view cart");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    <a href=\"cart.html\"><i class=\"fa fa-share\"></i> checkout</a>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BasketVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591