#pragma checksum "C:\Users\karac\Desktop\HotelProject\Frontend\HotelProject.WebUI\Views\Shared\Components\_DashboardLast6Bookings\Default.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9b4b564cfc60b30b19e491ef385ee1e5467ae836ceb08baf0b2cc246af7f3ac0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components__DashboardLast6Bookings_Default), @"mvc.1.0.view", @"/Views/Shared/Components/_DashboardLast6Bookings/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"9b4b564cfc60b30b19e491ef385ee1e5467ae836ceb08baf0b2cc246af7f3ac0", @"/Views/Shared/Components/_DashboardLast6Bookings/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"e24b105a43b79ea08797449bba90ec4251f4da5ab1c9baa5877b7f2732c208a5", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components__DashboardLast6Bookings_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<HotelProject.WebUI.Dtos.BookingDto.ResultLast6BookingDto>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-lg-12"">
        <div class=""card"">
            <div class=""card-body"">
                <div class=""active-member"">
                    <div class=""table-responsive"">
                        <table class=""table table-xs mb-0"">
                            <thead>
                                <tr>
                                    <th>Müşteri</th>
                                    <th>Şehir</th>
                                    <th>Ülke</th>
                                    <th>Durum</th>
                                </tr>
                            </thead>
                            <tbody>
");
#nullable restore
#line 19 "C:\Users\karac\Desktop\HotelProject\Frontend\HotelProject.WebUI\Views\Shared\Components\_DashboardLast6Bookings\Default.cshtml"
                                 foreach (var item in Model)
                                {

#line default
#line hidden
#nullable disable

            WriteLiteral("                                    <tr>\r\n                                        <td>");
            Write(
#nullable restore
#line 22 "C:\Users\karac\Desktop\HotelProject\Frontend\HotelProject.WebUI\Views\Shared\Components\_DashboardLast6Bookings\Default.cshtml"
                                             item.Name

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                                        <td>");
            Write(
#nullable restore
#line 23 "C:\Users\karac\Desktop\HotelProject\Frontend\HotelProject.WebUI\Views\Shared\Components\_DashboardLast6Bookings\Default.cshtml"
                                             item.City

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                                        <td>\r\n                                            <span>");
            Write(
#nullable restore
#line 25 "C:\Users\karac\Desktop\HotelProject\Frontend\HotelProject.WebUI\Views\Shared\Components\_DashboardLast6Bookings\Default.cshtml"
                                                   item.Country

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</span>\r\n                                        </td>\r\n");
#nullable restore
#line 27 "C:\Users\karac\Desktop\HotelProject\Frontend\HotelProject.WebUI\Views\Shared\Components\_DashboardLast6Bookings\Default.cshtml"
                                         if (item.Status == "Onaylandı")
                                        {

#line default
#line hidden
#nullable disable

            WriteLiteral(@"                                            <td>
                                                <div>
                                                    <div class=""progress"" style=""height: 6px"">
                                                        <div class=""progress-bar bg-success"" style=""width: 100%""></div>
                                                    </div>
                                                </div>
                                            </td>
                                            <td><i class=""fa fa-circle-o text-success  mr-2""></i> ");
            Write(
#nullable restore
#line 36 "C:\Users\karac\Desktop\HotelProject\Frontend\HotelProject.WebUI\Views\Shared\Components\_DashboardLast6Bookings\Default.cshtml"
                                                                                                   item.Status

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n");
#nullable restore
#line 37 "C:\Users\karac\Desktop\HotelProject\Frontend\HotelProject.WebUI\Views\Shared\Components\_DashboardLast6Bookings\Default.cshtml"
                                        }

#line default
#line hidden
#nullable disable

#nullable restore
#line 38 "C:\Users\karac\Desktop\HotelProject\Frontend\HotelProject.WebUI\Views\Shared\Components\_DashboardLast6Bookings\Default.cshtml"
                                         if (item.Status == "Müşteri Aranacak")
                                        {

#line default
#line hidden
#nullable disable

            WriteLiteral(@"                                            <td>
                                                <div>
                                                    <div class=""progress"" style=""height: 6px"">
                                                        <div class=""progress-bar bg-warning"" style=""width: 100%""></div>
                                                    </div>
                                                </div>
                                            </td>
                                            <td><i class=""fa fa-circle-o text-warning  mr-2""></i> ");
            Write(
#nullable restore
#line 47 "C:\Users\karac\Desktop\HotelProject\Frontend\HotelProject.WebUI\Views\Shared\Components\_DashboardLast6Bookings\Default.cshtml"
                                                                                                   item.Status

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n");
#nullable restore
#line 48 "C:\Users\karac\Desktop\HotelProject\Frontend\HotelProject.WebUI\Views\Shared\Components\_DashboardLast6Bookings\Default.cshtml"
                                        }

#line default
#line hidden
#nullable disable

#nullable restore
#line 49 "C:\Users\karac\Desktop\HotelProject\Frontend\HotelProject.WebUI\Views\Shared\Components\_DashboardLast6Bookings\Default.cshtml"
                                         if (item.Status == "İptal Edildi")
                                        {

#line default
#line hidden
#nullable disable

            WriteLiteral(@"                                            <td>
                                                <div>
                                                    <div class=""progress"" style=""height: 6px"">
                                                        <div class=""progress-bar bg-danger"" style=""width: 100%""></div>
                                                    </div>
                                                </div>
                                            </td>
                                            <td><i class=""fa fa-circle-o text-danger  mr-2""></i> ");
            Write(
#nullable restore
#line 58 "C:\Users\karac\Desktop\HotelProject\Frontend\HotelProject.WebUI\Views\Shared\Components\_DashboardLast6Bookings\Default.cshtml"
                                                                                                  item.Status

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n");
#nullable restore
#line 59 "C:\Users\karac\Desktop\HotelProject\Frontend\HotelProject.WebUI\Views\Shared\Components\_DashboardLast6Bookings\Default.cshtml"
                                        }

#line default
#line hidden
#nullable disable

#nullable restore
#line 60 "C:\Users\karac\Desktop\HotelProject\Frontend\HotelProject.WebUI\Views\Shared\Components\_DashboardLast6Bookings\Default.cshtml"
                                         if (item.Status == "Onay Bekliyor")
                                        {

#line default
#line hidden
#nullable disable

            WriteLiteral(@"                                            <td>
                                                <div>
                                                    <div class=""progress"" style=""height: 6px"">
                                                        <div class=""progress-bar bg-info"" style=""width: 100%""></div>
                                                    </div>
                                                </div>
                                            </td>
                                            <td><i class=""fa fa-circle-o text-info  mr-2""></i> ");
            Write(
#nullable restore
#line 69 "C:\Users\karac\Desktop\HotelProject\Frontend\HotelProject.WebUI\Views\Shared\Components\_DashboardLast6Bookings\Default.cshtml"
                                                                                                item.Status

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n");
#nullable restore
#line 70 "C:\Users\karac\Desktop\HotelProject\Frontend\HotelProject.WebUI\Views\Shared\Components\_DashboardLast6Bookings\Default.cshtml"
                                        }

#line default
#line hidden
#nullable disable

            WriteLiteral("                                    </tr>\r\n");
#nullable restore
#line 72 "C:\Users\karac\Desktop\HotelProject\Frontend\HotelProject.WebUI\Views\Shared\Components\_DashboardLast6Bookings\Default.cshtml"
                                }

#line default
#line hidden
#nullable disable

            WriteLiteral("                            </tbody>\r\n                        </table>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<HotelProject.WebUI.Dtos.BookingDto.ResultLast6BookingDto>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
