#pragma checksum "C:\Users\karac\Desktop\HotelProject\Frontend\HotelProject.WebUI\Views\Guest\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "59e0850fc4f28f35bcca052dc474ed86f824614611fa322791c7d05bab5c6e80"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Guest_Index), @"mvc.1.0.view", @"/Views/Guest/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"59e0850fc4f28f35bcca052dc474ed86f824614611fa322791c7d05bab5c6e80", @"/Views/Guest/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"e24b105a43b79ea08797449bba90ec4251f4da5ab1c9baa5877b7f2732c208a5", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Guest_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ResultGuestDto>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\karac\Desktop\HotelProject\Frontend\HotelProject.WebUI\Views\Guest\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/AdminLayout/_AdminLayout.cshtml";
    int count = 0;

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>#</th>\r\n        <th>Ad</th>\r\n        <th>Soyad</th>\r\n        <th>Şehir</th>\r\n        <th>Sil</th>\r\n        <th>Güncelle</th>\r\n    </tr>\r\n");
#nullable restore
#line 18 "C:\Users\karac\Desktop\HotelProject\Frontend\HotelProject.WebUI\Views\Guest\Index.cshtml"
     foreach (var item in Model)
    {
        count++;

#line default
#line hidden
#nullable disable

            WriteLiteral("        <tr>\r\n            <th>");
            Write(
#nullable restore
#line 22 "C:\Users\karac\Desktop\HotelProject\Frontend\HotelProject.WebUI\Views\Guest\Index.cshtml"
                 count

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</th>\r\n            <td>");
            Write(
#nullable restore
#line 23 "C:\Users\karac\Desktop\HotelProject\Frontend\HotelProject.WebUI\Views\Guest\Index.cshtml"
                 item.Name

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n            <td>");
            Write(
#nullable restore
#line 24 "C:\Users\karac\Desktop\HotelProject\Frontend\HotelProject.WebUI\Views\Guest\Index.cshtml"
                 item.Surname

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n            <td>");
            Write(
#nullable restore
#line 25 "C:\Users\karac\Desktop\HotelProject\Frontend\HotelProject.WebUI\Views\Guest\Index.cshtml"
                 item.City

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 570, "\"", 609, 2);
            WriteAttributeValue("", 577, "/Guest/DeleteGuest/", 577, 19, true);
            WriteAttributeValue("", 596, 
#nullable restore
#line 26 "C:\Users\karac\Desktop\HotelProject\Frontend\HotelProject.WebUI\Views\Guest\Index.cshtml"
                                             item.GuestID

#line default
#line hidden
#nullable disable
            , 596, 13, false);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn mb-1 btn-rounded btn-outline-danger\">Sil</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 691, "\"", 730, 2);
            WriteAttributeValue("", 698, "/Guest/UpdateGuest/", 698, 19, true);
            WriteAttributeValue("", 717, 
#nullable restore
#line 27 "C:\Users\karac\Desktop\HotelProject\Frontend\HotelProject.WebUI\Views\Guest\Index.cshtml"
                                             item.GuestID

#line default
#line hidden
#nullable disable
            , 717, 13, false);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn mb-1 btn-rounded btn-outline-success\">Güncelle</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 29 "C:\Users\karac\Desktop\HotelProject\Frontend\HotelProject.WebUI\Views\Guest\Index.cshtml"
    }

#line default
#line hidden
#nullable disable

            WriteLiteral("</table>\r\n<a href=\"/Guest/AddGuest/\" class=\"btn mb-1 btn-rounded btn-outline-info\">Yeni Misafir Girişi</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ResultGuestDto>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591