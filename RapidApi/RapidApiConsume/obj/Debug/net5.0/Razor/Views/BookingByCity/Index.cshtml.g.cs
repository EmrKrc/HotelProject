#pragma checksum "C:\Users\karac\Desktop\HotelProject\RapidApi\RapidApiConsume\Views\BookingByCity\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "11f9d9aeec7563cb5a162aa611c0e5c658675d83df7e34f9e6dda9c8aa456777"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BookingByCity_Index), @"mvc.1.0.view", @"/Views/BookingByCity/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"11f9d9aeec7563cb5a162aa611c0e5c658675d83df7e34f9e6dda9c8aa456777", @"/Views/BookingByCity/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"bbc88734109d7b577c175d5d797213ff38393202e091634827b97667cdaa38a0", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_BookingByCity_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<BookingApiViewModel.Result>>
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\karac\Desktop\HotelProject\RapidApi\RapidApiConsume\Views\BookingByCity\Index.cshtml"
  
    Layout = null;
    int count = 0;

#line default
#line hidden
#nullable disable

            WriteLiteral("<div class=\"container\">\r\n    <br /><br />\r\n");
#nullable restore
#line 9 "C:\Users\karac\Desktop\HotelProject\RapidApi\RapidApiConsume\Views\BookingByCity\Index.cshtml"
     using (Html.BeginForm("Index", "BookingByCity", FormMethod.Post))
    {

#line default
#line hidden
#nullable disable

            WriteLiteral("        <label>Şehir ID Bilgisini Giriniz</label>\r\n        <input type=\"text\" class=\"form-control\" name=\"cityID\" />\r\n        <br />\r\n        <button class=\"btn btn-primary\">Şehir İçin Otelleri Listele</button>\r\n");
#nullable restore
#line 15 "C:\Users\karac\Desktop\HotelProject\RapidApi\RapidApiConsume\Views\BookingByCity\Index.cshtml"
    }

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n    <br />\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "11f9d9aeec7563cb5a162aa611c0e5c658675d83df7e34f9e6dda9c8aa4567775133", async() => {
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
            WriteLiteral("\r\n\r\n    <table class=\"table table-bordered\">\r\n        <tr>\r\n            <th>#</th>\r\n            <th>Otel Adı</th>\r\n            <th>Otel Puanı</th>\r\n            <th>Otel Detaylar</th>\r\n        </tr>\r\n");
#nullable restore
#line 28 "C:\Users\karac\Desktop\HotelProject\RapidApi\RapidApiConsume\Views\BookingByCity\Index.cshtml"
         foreach (var item in Model)
        {
            count++;

#line default
#line hidden
#nullable disable

            WriteLiteral("            <tr>\r\n                <th>");
            Write(
#nullable restore
#line 32 "C:\Users\karac\Desktop\HotelProject\RapidApi\RapidApiConsume\Views\BookingByCity\Index.cshtml"
                     count

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</th>\r\n                <td>");
            Write(
#nullable restore
#line 33 "C:\Users\karac\Desktop\HotelProject\RapidApi\RapidApiConsume\Views\BookingByCity\Index.cshtml"
                     item.name

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                <td>");
            Write(
#nullable restore
#line 34 "C:\Users\karac\Desktop\HotelProject\RapidApi\RapidApiConsume\Views\BookingByCity\Index.cshtml"
                     item.reviewScore

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                <td><a href=\"#\" class=\"btn btn-outline-dark\">Detaylar</a></td>\r\n            </tr>\r\n");
#nullable restore
#line 37 "C:\Users\karac\Desktop\HotelProject\RapidApi\RapidApiConsume\Views\BookingByCity\Index.cshtml"
        }

#line default
#line hidden
#nullable disable

            WriteLiteral("    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<BookingApiViewModel.Result>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591