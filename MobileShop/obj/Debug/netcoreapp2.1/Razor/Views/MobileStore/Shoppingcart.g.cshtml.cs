#pragma checksum "F:\G 166g\task 4 adv ecommerce\TASK 4 advecom\task 4 adv ecommerce\MobileShop\MobileShop\Views\MobileStore\Shoppingcart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3cb8c7bc047e91c499d69423ed435aa3084fb348"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MobileStore_Shoppingcart), @"mvc.1.0.view", @"/Views/MobileStore/Shoppingcart.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/MobileStore/Shoppingcart.cshtml", typeof(AspNetCore.Views_MobileStore_Shoppingcart))]
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
#line 1 "F:\G 166g\task 4 adv ecommerce\TASK 4 advecom\task 4 adv ecommerce\MobileShop\MobileShop\Views\_ViewImports.cshtml"
using MobileShop;

#line default
#line hidden
#line 2 "F:\G 166g\task 4 adv ecommerce\TASK 4 advecom\task 4 adv ecommerce\MobileShop\MobileShop\Views\_ViewImports.cshtml"
using MobileShop.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cb8c7bc047e91c499d69423ed435aa3084fb348", @"/Views/MobileStore/Shoppingcart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"829525de4518d6a245edfad2ecb61bdfe881547e", @"/Views/_ViewImports.cshtml")]
    public class Views_MobileStore_Shoppingcart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/3.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "F:\G 166g\task 4 adv ecommerce\TASK 4 advecom\task 4 adv ecommerce\MobileShop\MobileShop\Views\MobileStore\Shoppingcart.cshtml"
  
    ViewData["Title"] = "Shoppingcart";

#line default
#line hidden
            DefineSection("Style", async() => {
                BeginContext(71, 11, true);
                WriteLiteral("\r\n    <link");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 82, "\"", 152, 1);
#line 7 "F:\G 166g\task 4 adv ecommerce\TASK 4 advecom\task 4 adv ecommerce\MobileShop\MobileShop\Views\MobileStore\Shoppingcart.cshtml"
WriteAttributeValue("", 89, Url.Content("https://fonts.googleapis.com/css?family=Poppins"), 89, 63, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(153, 62, true);
                WriteLiteral(" rel=\"stylesheet\">\r\n    <link rel=\"stylesheet\" type=\"text/css\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 215, "\"", 251, 1);
#line 8 "F:\G 166g\task 4 adv ecommerce\TASK 4 advecom\task 4 adv ecommerce\MobileShop\MobileShop\Views\MobileStore\Shoppingcart.cshtml"
WriteAttributeValue("", 222, Url.Content("~/css/all.css"), 222, 29, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(252, 47, true);
                WriteLiteral(" />\r\n    <link rel=\"stylesheet\" type=\"text/css\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 299, "\"", 345, 1);
#line 9 "F:\G 166g\task 4 adv ecommerce\TASK 4 advecom\task 4 adv ecommerce\MobileShop\MobileShop\Views\MobileStore\Shoppingcart.cshtml"
WriteAttributeValue("", 306, Url.Content("~/css/bootstrap.min.css"), 306, 39, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(346, 47, true);
                WriteLiteral(" />\r\n    <link rel=\"stylesheet\" type=\"text/css\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 393, "\"", 437, 1);
#line 10 "F:\G 166g\task 4 adv ecommerce\TASK 4 advecom\task 4 adv ecommerce\MobileShop\MobileShop\Views\MobileStore\Shoppingcart.cshtml"
WriteAttributeValue("", 400, Url.Content("~/css/index_style.css"), 400, 37, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(438, 47, true);
                WriteLiteral(" />\r\n    <link rel=\"stylesheet\" type=\"text/css\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 485, "\"", 530, 1);
#line 11 "F:\G 166g\task 4 adv ecommerce\TASK 4 advecom\task 4 adv ecommerce\MobileShop\MobileShop\Views\MobileStore\Shoppingcart.cshtml"
WriteAttributeValue("", 492, Url.Content("~/css/shoppingcart.css"), 492, 38, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(531, 31, true);
                WriteLiteral(" />\r\n    <link rel=\"stylesheet\"");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 562, "\"", 640, 1);
#line 12 "F:\G 166g\task 4 adv ecommerce\TASK 4 advecom\task 4 adv ecommerce\MobileShop\MobileShop\Views\MobileStore\Shoppingcart.cshtml"
WriteAttributeValue("", 569, Url.Content("https://use.fontawesome.com/releases/v5.5.0/css/all.css"), 569, 71, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(641, 238, true);
                WriteLiteral(" integrity=\"sha384-B4dIYHKNBt8Bc12p+WXckhzcICo0wtJAoU8YZTY5qE0Id1GSseTk6S+L3BlXeVIU\" crossorigin=\"anonymous\">\r\n\r\n\r\n    <style type=\"text/css\">\r\n        body {\r\n            margin: 0px;\r\n            padding: 0px;\r\n        }\r\n    </style>\r\n");
                EndContext();
            }
            );
            BeginContext(882, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(911, 13, true);
                WriteLiteral("\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 924, "\"", 970, 1);
#line 27 "F:\G 166g\task 4 adv ecommerce\TASK 4 advecom\task 4 adv ecommerce\MobileShop\MobileShop\Views\MobileStore\Shoppingcart.cshtml"
WriteAttributeValue("", 930, Url.Content("~/js/jquery-3.3.1.min.js"), 930, 40, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(971, 23, true);
                WriteLiteral("></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 994, "\"", 1036, 1);
#line 28 "F:\G 166g\task 4 adv ecommerce\TASK 4 advecom\task 4 adv ecommerce\MobileShop\MobileShop\Views\MobileStore\Shoppingcart.cshtml"
WriteAttributeValue("", 1000, Url.Content("~/js/Shoppingcart.js"), 1000, 36, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1037, 16, true);
                WriteLiteral("></script>\r\n    ");
                EndContext();
            }
            );
            BeginContext(1056, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(1087, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(1119, 609, true);
            WriteLiteral(@"



<div class=""shopping-cart py-5 mx-0 px-0"" style=""background-color:black;color:crimson;padding:30px auto;width:100%;font-size:12px"">

    <div class=""column-labels"">
        <label class=""product-image"">Image</label>
        <label class=""product-details"">Product</label>
        <label class=""product-price"">Price</label>
        <label class=""product-quantity"">Quantity</label>
        <label class=""product-removal"">Remove</label>
        <label class=""product-line-price"">Total</label>
    </div>

    <div class=""product w-75 mx-auto"">
        <div class=""product-image"">
            ");
            EndContext();
            BeginContext(1728, 26, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "bc3a3006560244f495078b91f20bdd89", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1754, 1026, true);
            WriteLiteral(@"
        </div>
        <div class=""product-details"">
            <div class=""product-title"">Apple iPhone 6 - 32GB - Space Gray</div>
            <p class=""product-description"">iPhone 6 is not simply bigger — it’s better in every way. Larger, yet dramatically thinner. More powerful, but remarkably power efficient. With a smooth metal surface that seamlessly meets the new Retina HD display. It’s one continuous form where hardware and software function in perfect unison, creating a new generation of iPhone that’s better by any measure.</p>
        </div>
        <div class=""product-price"">12552$</div>
        <div class=""product-quantity"">
            <input type=""number"" value=""2"" min=""1"">
        </div>
        <div class=""product-removal"">
            <button class=""remove-product"">
                Remove
            </button>
        </div>
        <div class=""product-line-price"">1000$</div>
    </div>

    <div class=""product w-75 mx-auto"">
        <div class=""product-image"">
          ");
            WriteLiteral("  ");
            EndContext();
            BeginContext(2780, 26, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "97ea23506101498089977e405cbdfe68", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2806, 1660, true);
            WriteLiteral(@"
        </div>
        <div class=""product-details"">
            <div class=""product-title"">Xiaomi Redmi 6 - 5.45-inch 64GB - 4G Mobile Phone - Blue</div>
            <p class=""product-description"">
                Redmi 6 has a 5.45-inch 18:9 HD+ Full Screen Display with a screen-to-body ratio of 80.5%. Its polycarbonate back panel has a brushed metal surface, and is symmetrically curved and gently tapered toward the edges so it feels great in the hand.

            </p>
        </div>
        <div class=""product-price"">6500$</div>
        <div class=""product-quantity"">
            <input type=""number"" value=""1"" min=""1"">
        </div>
        <div class=""product-removal"">
            <button class=""remove-product"">
                Remove
            </button>
        </div>
        <div class=""product-line-price"">850$</div>
    </div>

    <div class=""totals w-75 mx-auto"">
        <div class=""totals-item"">
            <label>Subtotal</label>
            <div class=""totals-value"" id=");
            WriteLiteral(@"""cart-subtotal"">71.97</div>
        </div>
        <div class=""totals-item"">
            <label>Tax (5%)</label>
            <div class=""totals-value"" id=""cart-tax"">3.60</div>
        </div>
        <div class=""totals-item"">
            <label>Shipping</label>
            <div class=""totals-value"" id=""cart-shipping"">15.00</div>
        </div>
        <div class=""totals-item totals-item-total"">
            <label>Grand Total</label>
            <div class=""totals-value"" id=""cart-total"">90.57</div>
        </div>
    </div>

    <button class=""checkout w-25 mx-auto"">Checkout</button>

</div>
<!--JAVA SCRIPT-->
");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
