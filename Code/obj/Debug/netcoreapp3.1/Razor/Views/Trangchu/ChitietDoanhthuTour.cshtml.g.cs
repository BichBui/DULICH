#pragma checksum "C:\Users\DELL\Desktop\DULICH\Views\Trangchu\ChitietDoanhthuTour.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4e3fd12051a571c20460173ec8c450fd144ea073"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Trangchu_ChitietDoanhthuTour), @"mvc.1.0.view", @"/Views/Trangchu/ChitietDoanhthuTour.cshtml")]
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
#line 1 "C:\Users\DELL\Desktop\DULICH\Views\_ViewImports.cshtml"
using DULICH;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\DELL\Desktop\DULICH\Views\_ViewImports.cshtml"
using DULICH.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\DELL\Desktop\DULICH\Views\Trangchu\ChitietDoanhthuTour.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e3fd12051a571c20460173ec8c450fd144ea073", @"/Views/Trangchu/ChitietDoanhthuTour.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7e6dc8b99aaa79c31e4e5aeae00a2808448b3de", @"/Views/_ViewImports.cshtml")]
    public class Views_Trangchu_ChitietDoanhthuTour : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DULICH.Models.ChitietDoanhthu>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\DELL\Desktop\DULICH\Views\Trangchu\ChitietDoanhthuTour.cshtml"
  
    ViewData["Title"] = "ChitietDoanhthu";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Thống kê doanh thu Tour</h1>


<table class=""table"">
    <thead>
        <tr>
            <th>
                #
            </th>
            <th>
                Đoàn đi
            </th>
            <th>
                Số khách
            </th>
            <th>
                Giá Tour
            </th>
            <th>
                Doanh thu
            </th>
            <th>
                Tổng chi phí
            </th>
            <th>
                Lãi
            </th>
            
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 39 "C:\Users\DELL\Desktop\DULICH\Views\Trangchu\ChitietDoanhthuTour.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 43 "C:\Users\DELL\Desktop\DULICH\Views\Trangchu\ChitietDoanhthuTour.cshtml"
               Write(Html.DisplayFor(modelItem => item.doan_id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 46 "C:\Users\DELL\Desktop\DULICH\Views\Trangchu\ChitietDoanhthuTour.cshtml"
               Write(Html.DisplayFor(modelItem => item.doan_ten));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 49 "C:\Users\DELL\Desktop\DULICH\Views\Trangchu\ChitietDoanhthuTour.cshtml"
               Write(Html.DisplayFor(modelItem => item.sokhach));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 52 "C:\Users\DELL\Desktop\DULICH\Views\Trangchu\ChitietDoanhthuTour.cshtml"
               Write(Html.DisplayFor(modelItem => item.giatour));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 55 "C:\Users\DELL\Desktop\DULICH\Views\Trangchu\ChitietDoanhthuTour.cshtml"
               Write(Html.DisplayFor(modelItem => item.doanhthu));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 58 "C:\Users\DELL\Desktop\DULICH\Views\Trangchu\ChitietDoanhthuTour.cshtml"
               Write(Html.DisplayFor(modelItem => item.chiphi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 61 "C:\Users\DELL\Desktop\DULICH\Views\Trangchu\ChitietDoanhthuTour.cshtml"
               Write(Html.DisplayFor(modelItem => item.lai));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n\r\n            </tr>\r\n");
#nullable restore
#line 65 "C:\Users\DELL\Desktop\DULICH\Views\Trangchu\ChitietDoanhthuTour.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    \r\n\r\n    </tbody>\r\n</table>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DULICH.Models.ChitietDoanhthu>> Html { get; private set; }
    }
}
#pragma warning restore 1591
