#pragma checksum "C:\Users\karac\Desktop\HotelProject\Frontend\HotelProject.WebUI\Views\WorkLocation\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "224a8f377c9e6d54ee17f2420fd2d87bf3802559b26209819d9403414c520ca4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_WorkLocation_Index), @"mvc.1.0.view", @"/Views/WorkLocation/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"224a8f377c9e6d54ee17f2420fd2d87bf3802559b26209819d9403414c520ca4", @"/Views/WorkLocation/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"e24b105a43b79ea08797449bba90ec4251f4da5ab1c9baa5877b7f2732c208a5", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_WorkLocation_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ResultWorkLocationDto>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\karac\Desktop\HotelProject\Frontend\HotelProject.WebUI\Views\WorkLocation\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/AdminLayout/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>#</th>\r\n        <th>Lokasyon Adı</th>\r\n        <th>Şehir</th>\r\n        <th>Sil</th>\r\n        <th>Güncelle</th>\r\n    </tr>\r\n");
#nullable restore
#line 16 "C:\Users\karac\Desktop\HotelProject\Frontend\HotelProject.WebUI\Views\WorkLocation\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable

            WriteLiteral("        <tr>\r\n            <td>");
            Write(
#nullable restore
#line 19 "C:\Users\karac\Desktop\HotelProject\Frontend\HotelProject.WebUI\Views\WorkLocation\Index.cshtml"
                 item.WorkLocationID

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n            <td>");
            Write(
#nullable restore
#line 20 "C:\Users\karac\Desktop\HotelProject\Frontend\HotelProject.WebUI\Views\WorkLocation\Index.cshtml"
                 item.WorkLocationName

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n            <td>");
            Write(
#nullable restore
#line 21 "C:\Users\karac\Desktop\HotelProject\Frontend\HotelProject.WebUI\Views\WorkLocation\Index.cshtml"
                 item.WorkLocationCity

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 527, "\"", 587, 2);
            WriteAttributeValue("", 534, "/WorkLocation/DeleteWorkLocation/", 534, 33, true);
            WriteAttributeValue("", 567, 
#nullable restore
#line 22 "C:\Users\karac\Desktop\HotelProject\Frontend\HotelProject.WebUI\Views\WorkLocation\Index.cshtml"
                                                           item.WorkLocationID

#line default
#line hidden
#nullable disable
            , 567, 20, false);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn mb-1 btn-rounded btn-outline-danger\">Sil</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 669, "\"", 729, 2);
            WriteAttributeValue("", 676, "/WorkLocation/UpdateWorkLocation/", 676, 33, true);
            WriteAttributeValue("", 709, 
#nullable restore
#line 23 "C:\Users\karac\Desktop\HotelProject\Frontend\HotelProject.WebUI\Views\WorkLocation\Index.cshtml"
                                                           item.WorkLocationID

#line default
#line hidden
#nullable disable
            , 709, 20, false);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn mb-1 btn-rounded btn-outline-success\">Güncelle</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 25 "C:\Users\karac\Desktop\HotelProject\Frontend\HotelProject.WebUI\Views\WorkLocation\Index.cshtml"
    }

#line default
#line hidden
#nullable disable

            WriteLiteral("</table>\r\n<a href=\"/AdminRoom/AddRoom/\" class=\"btn mb-1 btn-rounded btn-outline-info\">Yeni Lokasyon Girişi</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ResultWorkLocationDto>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591