#pragma checksum "C:\Users\karac\Desktop\HotelProject\Frontend\HotelProject.WebUI\Views\AdminLayout\_AdminLayout.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "e3f7f2dcc8bf5f805a0a505c548749925b88692131e0205498ae4e4ecbe8bc58"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminLayout__AdminLayout), @"mvc.1.0.view", @"/Views/AdminLayout/_AdminLayout.cshtml")]
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
#line 1 "C:\Users\karac\Desktop\HotelProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI

#nullable disable
    ;
#nullable restore
#line 2 "C:\Users\karac\Desktop\HotelProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Models

#nullable disable
    ;
#nullable restore
#line 3 "C:\Users\karac\Desktop\HotelProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Models.Staff

#nullable disable
    ;
#nullable restore
#line 4 "C:\Users\karac\Desktop\HotelProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Models.Testimonial

#nullable disable
    ;
#nullable restore
#line 5 "C:\Users\karac\Desktop\HotelProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.ServiceDto

#nullable disable
    ;
#nullable restore
#line 6 "C:\Users\karac\Desktop\HotelProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.RegisterDto

#nullable disable
    ;
#nullable restore
#line 7 "C:\Users\karac\Desktop\HotelProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.LoginDto

#nullable disable
    ;
#nullable restore
#line 8 "C:\Users\karac\Desktop\HotelProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.AboutDto

#nullable disable
    ;
#nullable restore
#line 9 "C:\Users\karac\Desktop\HotelProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.RoomDto

#nullable disable
    ;
#nullable restore
#line 10 "C:\Users\karac\Desktop\HotelProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.TestimonialDto

#nullable disable
    ;
#nullable restore
#line 11 "C:\Users\karac\Desktop\HotelProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.StaffDto

#nullable disable
    ;
#nullable restore
#line 12 "C:\Users\karac\Desktop\HotelProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.SubscribeDto

#nullable disable
    ;
#nullable restore
#line 13 "C:\Users\karac\Desktop\HotelProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.BookingDto

#nullable disable
    ;
#nullable restore
#line 14 "C:\Users\karac\Desktop\HotelProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.ContactDto

#nullable disable
    ;
#nullable restore
#line 15 "C:\Users\karac\Desktop\HotelProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.GuestDto

#nullable disable
    ;
#nullable restore
#line 16 "C:\Users\karac\Desktop\HotelProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.SendMessageDto

#nullable disable
    ;
#nullable restore
#line 17 "C:\Users\karac\Desktop\HotelProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Models.Mail

#nullable disable
    ;
#nullable restore
#line 18 "C:\Users\karac\Desktop\HotelProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.WorkLocationDto

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"e3f7f2dcc8bf5f805a0a505c548749925b88692131e0205498ae4e4ecbe8bc58", @"/Views/AdminLayout/_AdminLayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"e24b105a43b79ea08797449bba90ec4251f4da5ab1c9baa5877b7f2732c208a5", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_AdminLayout__AdminLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\karac\Desktop\HotelProject\Frontend\HotelProject.WebUI\Views\AdminLayout\_AdminLayout.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            Write(
#nullable restore
#line 9 "C:\Users\karac\Desktop\HotelProject\Frontend\HotelProject.WebUI\Views\AdminLayout\_AdminLayout.cshtml"
 await Html.PartialAsync("/Views/AdminLayout/HeadPartial.cshtml")

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e3f7f2dcc8bf5f805a0a505c548749925b88692131e0205498ae4e4ecbe8bc587009", async() => {
                WriteLiteral("\r\n\r\n    ");
                Write(
#nullable restore
#line 13 "C:\Users\karac\Desktop\HotelProject\Frontend\HotelProject.WebUI\Views\AdminLayout\_AdminLayout.cshtml"
     await Html.PartialAsync("/Views/AdminLayout/PreloaderPartial.cshtml")

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\r\n\r\n    <div id=\"main-wrapper\">\r\n\r\n\r\n        ");
                Write(
#nullable restore
#line 18 "C:\Users\karac\Desktop\HotelProject\Frontend\HotelProject.WebUI\Views\AdminLayout\_AdminLayout.cshtml"
         await Html.PartialAsync("/Views/AdminLayout/NavheaderPartial.cshtml")

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\r\n\r\n        ");
                Write(
#nullable restore
#line 20 "C:\Users\karac\Desktop\HotelProject\Frontend\HotelProject.WebUI\Views\AdminLayout\_AdminLayout.cshtml"
         await Html.PartialAsync("/Views/AdminLayout/HeaderPartial.cshtml")

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\r\n\r\n        ");
                Write(
#nullable restore
#line 22 "C:\Users\karac\Desktop\HotelProject\Frontend\HotelProject.WebUI\Views\AdminLayout\_AdminLayout.cshtml"
         await Html.PartialAsync("/Views/AdminLayout/SidebarPartial.cshtml")

#line default
#line hidden
#nullable disable
                );
                WriteLiteral(@"

        <div class=""content-body"">

            <div class=""container-fluid"">
                <div class=""row"">
                    <div class=""col-12"">
                        <div class=""card"">
                            <div class=""card-body"">
                                ");
                Write(
#nullable restore
#line 31 "C:\Users\karac\Desktop\HotelProject\Frontend\HotelProject.WebUI\Views\AdminLayout\_AdminLayout.cshtml"
                                 RenderBody()

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <!-- #/ container -->\r\n        </div>\r\n\r\n        ");
                Write(
#nullable restore
#line 40 "C:\Users\karac\Desktop\HotelProject\Frontend\HotelProject.WebUI\Views\AdminLayout\_AdminLayout.cshtml"
         await Html.PartialAsync("/Views/AdminLayout/FooterPartial.cshtml")

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\r\n    </div>\r\n\r\n    ");
                Write(
#nullable restore
#line 43 "C:\Users\karac\Desktop\HotelProject\Frontend\HotelProject.WebUI\Views\AdminLayout\_AdminLayout.cshtml"
     await Html.PartialAsync("/Views/AdminLayout/ScriptPartial.cshtml")

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
