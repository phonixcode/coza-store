#pragma checksum "C:\Users\HP PAVILLION\3D Objects\.net core\Coza\Coza\Views\Shared\_Modal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7a5d589549acef367d847e8e8b89253f9699d132"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Modal), @"mvc.1.0.view", @"/Views/Shared/_Modal.cshtml")]
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
#line 1 "C:\Users\HP PAVILLION\3D Objects\.net core\Coza\Coza\Views\_ViewImports.cshtml"
using Coza;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP PAVILLION\3D Objects\.net core\Coza\Coza\Views\_ViewImports.cshtml"
using Coza.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a5d589549acef367d847e8e8b89253f9699d132", @"/Views/Shared/_Modal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7be3da48c7f606c621c2f85a5a99917cf1a6c2d", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Modal : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Coza.Models.Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/icons/icon-close.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("CLOSE"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<!-- Modal1 -->
<div class=""wrap-modal1 js-modal1 p-t-60 p-b-20"">
    <div class=""overlay-modal1 js-hide-modal1""></div>

    <div class=""container"">
        <div class=""bg0 p-t-60 p-b-30 p-lr-15-lg how-pos3-parent"">
            <button class=""how-pos3 hov3 trans-04 js-hide-modal1"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7a5d589549acef367d847e8e8b89253f9699d1324115", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </button>

            <div class=""row"">
                <div class=""col-md-6 col-lg-7 p-b-30"">
                    <div class=""p-l-25 p-r-30 p-lr-0-lg"">
                        <div class=""wrap-slick3 flex-sb flex-w"">
                            <div class=""wrap-slick3-dots""></div>
                            <div class=""wrap-slick3-arrows flex-sb-m flex-w""></div>

                            <div class=""slick3 gallery-lb"">
                                <div class=""item-slick3"" data-thumb=""");
#nullable restore
#line 20 "C:\Users\HP PAVILLION\3D Objects\.net core\Coza\Coza\Views\Shared\_Modal.cshtml"
                                                                Write(Model.ImageUrl);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\n                                    <div class=\"wrap-pic-w pos-relative\">\n                                        <img");
            BeginWriteAttribute("src", " src=\"", 1026, "\"", 1047, 1);
#nullable restore
#line 22 "C:\Users\HP PAVILLION\3D Objects\.net core\Coza\Coza\Views\Shared\_Modal.cshtml"
WriteAttributeValue("", 1032, Model.ImageUrl, 1032, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"IMG-PRODUCT\">\n\n                                        <a class=\"flex-c-m size-108 how-pos1 bor0 fs-16 cl10 bg0 hov-btn3 trans-04\"");
            BeginWriteAttribute("href", " href=\"", 1184, "\"", 1206, 1);
#nullable restore
#line 24 "C:\Users\HP PAVILLION\3D Objects\.net core\Coza\Coza\Views\Shared\_Modal.cshtml"
WriteAttributeValue("", 1191, Model.ImageUrl, 1191, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                            <i class=""fa fa-expand""></i>
                                        </a>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>

                <div class=""col-md-6 col-lg-5 p-b-30"">
                    <div class=""p-r-50 p-t-5 p-lr-0-lg"">
                        <h4 class=""mtext-105 cl2 js-name-detail p-b-14"">
                            ");
#nullable restore
#line 37 "C:\Users\HP PAVILLION\3D Objects\.net core\Coza\Coza\Views\Shared\_Modal.cshtml"
                       Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </h4>\n\n                        <span class=\"mtext-106 cl2\">\n                            $");
#nullable restore
#line 41 "C:\Users\HP PAVILLION\3D Objects\.net core\Coza\Coza\Views\Shared\_Modal.cshtml"
                        Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </span>\n\n                        <p class=\"stext-102 cl3 p-t-23\">\n                            ");
#nullable restore
#line 45 "C:\Users\HP PAVILLION\3D Objects\.net core\Coza\Coza\Views\Shared\_Modal.cshtml"
                       Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </p>

                        <!--  -->
                        <div class=""p-t-33"">
                            <div class=""flex-w flex-r-m p-b-10"">

                                <div class=""size-204 flex-w flex-m respon6-next"">
                                    <div class=""wrap-num-product flex-w m-r-20 m-tb-10"">
                                        <div class=""btn-num-product-down cl8 hov-btn3 trans-04 flex-c-m"">
                                            <i class=""fs-16 zmdi zmdi-minus""></i>
                                        </div>

                                        <input class=""mtext-104 cl3 txt-center num-product"" type=""number"" name=""num-product"" value=""1"">

                                        <div class=""btn-num-product-up cl8 hov-btn3 trans-04 flex-c-m"">
                                            <i class=""fs-16 zmdi zmdi-plus""></i>
                                        </div>
                                    </div>

                            ");
            WriteLiteral(@"        <button class=""flex-c-m stext-101 cl0 size-101 bg1 bor1 hov-btn1 p-lr-15 trans-04 js-addcart-detail"">
                                        Add to cart
                                    </button>
                                </div>
                            </div>
                        </div>

                        <!--  -->
                        <div class=""flex-w flex-m p-l-100 p-t-40 respon7"">
                            <div class=""flex-m bor9 p-r-10 m-r-11"">
                                <a href=""#"" class=""fs-14 cl3 hov-cl1 trans-04 lh-10 p-lr-5 p-tb-2 js-addwish-detail tooltip100"" data-tooltip=""Add to Wishlist"">
                                    <i class=""zmdi zmdi-favorite""></i>
                                </a>
                            </div>

                            <a href=""#"" class=""fs-14 cl3 hov-cl1 trans-04 lh-10 p-lr-5 p-tb-2 m-r-8 tooltip100"" data-tooltip=""Facebook"">
                                <i class=""fa fa-facebook""></i>
                            <");
            WriteLiteral(@"/a>

                            <a href=""#"" class=""fs-14 cl3 hov-cl1 trans-04 lh-10 p-lr-5 p-tb-2 m-r-8 tooltip100"" data-tooltip=""Twitter"">
                                <i class=""fa fa-twitter""></i>
                            </a>

                            <a href=""#"" class=""fs-14 cl3 hov-cl1 trans-04 lh-10 p-lr-5 p-tb-2 m-r-8 tooltip100"" data-tooltip=""Google Plus"">
                                <i class=""fa fa-google-plus""></i>
                            </a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Coza.Models.Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
