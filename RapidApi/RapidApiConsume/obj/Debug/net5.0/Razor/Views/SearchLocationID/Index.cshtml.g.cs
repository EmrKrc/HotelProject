#pragma checksum "C:\Users\karac\Desktop\HotelProject\RapidApi\RapidApiConsume\Views\SearchLocationID\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0e19820f0f12000925952ca7475ad50f7da4866f57971c4d8778588ac0c4e47d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SearchLocationID_Index), @"mvc.1.0.view", @"/Views/SearchLocationID/Index.cshtml")]
namespace AspNetCore
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\karac\Desktop\HotelProject\RapidApi\RapidApiConsume\Views\_ViewImports.cshtml"
using RapidApiConsume

#nullable disable
    ;
#nullable restore
#line 2 "C:\Users\karac\Desktop\HotelProject\RapidApi\RapidApiConsume\Views\_ViewImports.cshtml"
using RapidApiConsume.Models

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"0e19820f0f12000925952ca7475ad50f7da4866f57971c4d8778588ac0c4e47d", @"/Views/SearchLocationID/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"bbc88734109d7b577c175d5d797213ff38393202e091634827b97667cdaa38a0", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_SearchLocationID_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<BookingApiLocationSearchViewModel>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\karac\Desktop\HotelProject\RapidApi\RapidApiConsume\Views\SearchLocationID\Index.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable

            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0e19820f0f12000925952ca7475ad50f7da4866f57971c4d8778588ac0c4e47d4269", async() => {
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
            WriteLiteral("\r\n\r\n<div class=\"container\">\r\n    <br />\r\n");
#nullable restore
#line 9 "C:\Users\karac\Desktop\HotelProject\RapidApi\RapidApiConsume\Views\SearchLocationID\Index.cshtml"
     using (Html.BeginForm("Index", "SearchLocationID", FormMethod.Post))
    {

#line default
#line hidden
#nullable disable

            WriteLiteral("        <label>Şehir Adını Giriniz</label>\r\n        <input type=\"text\" class=\"form-control\" name=\"cityName\" />\r\n        <br />\r\n        <button class=\"btn btn-primary\">Şehir İçin ID Bul</button>\r\n");
#nullable restore
#line 15 "C:\Users\karac\Desktop\HotelProject\RapidApi\RapidApiConsume\Views\SearchLocationID\Index.cshtml"
    }

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n    <table class=\"table table-bordered\">\r\n");
#nullable restore
#line 18 "C:\Users\karac\Desktop\HotelProject\RapidApi\RapidApiConsume\Views\SearchLocationID\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable

            WriteLiteral("            <tr>\r\n                <td>");
            Write(
#nullable restore
#line 21 "C:\Users\karac\Desktop\HotelProject\RapidApi\RapidApiConsume\Views\SearchLocationID\Index.cshtml"
                     item.dest_id

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 23 "C:\Users\karac\Desktop\HotelProject\RapidApi\RapidApiConsume\Views\SearchLocationID\Index.cshtml"
        }

#line default
#line hidden
#nullable disable

            WriteLiteral("    </table>\r\n    <br />\r\n    <a href=\"/BookingByCity/Index/\" class=\"btn btn-dark\">Yeni Otel Rezervasyon Bilgisi</a>\r\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<BookingApiLocationSearchViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591