#pragma checksum "D:\Диплом (ахахаха)\SpacecraftSite\SpacecraftSite\Pages\Year.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cbefafaa19fd9ab8a27c10103f2a3c65468b8d99"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(SpacecraftSite.Pages.Pages_Year), @"mvc.1.0.razor-page", @"/Pages/Year.cshtml")]
namespace SpacecraftSite.Pages
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
#line 1 "D:\Диплом (ахахаха)\SpacecraftSite\SpacecraftSite\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Диплом (ахахаха)\SpacecraftSite\SpacecraftSite\Pages\_ViewImports.cshtml"
using SpacecraftSite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Диплом (ахахаха)\SpacecraftSite\SpacecraftSite\Pages\_ViewImports.cshtml"
using SpacecraftSite.SpacecraftData;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{year}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cbefafaa19fd9ab8a27c10103f2a3c65468b8d99", @"/Pages/Year.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4182ce6d3ce9f608bf5a0287a57ef93ad687410e", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Year : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\Диплом (ахахаха)\SpacecraftSite\SpacecraftSite\Pages\Year.cshtml"
  
    ViewData["Title"] = Model.Year;


#line default
#line hidden
#nullable disable
            WriteLiteral("    <h3>");
#nullable restore
#line 6 "D:\Диплом (ахахаха)\SpacecraftSite\SpacecraftSite\Pages\Year.cshtml"
   Write(Model.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n    <br />\r\n");
            WriteLiteral("    <div>\r\n");
#nullable restore
#line 10 "D:\Диплом (ахахаха)\SpacecraftSite\SpacecraftSite\Pages\Year.cshtml"
         if (Model.previousYear)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div><a");
            BeginWriteAttribute("href", " href=\"", 213, "\"", 241, 2);
            WriteAttributeValue("", 220, "/Year/", 220, 6, true);
#nullable restore
#line 12 "D:\Диплом (ахахаха)\SpacecraftSite\SpacecraftSite\Pages\Year.cshtml"
WriteAttributeValue("", 226, Model.Year-1, 226, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 12 "D:\Диплом (ахахаха)\SpacecraftSite\SpacecraftSite\Pages\Year.cshtml"
                                             Write(Model.Year-1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></div>\r\n");
#nullable restore
#line 13 "D:\Диплом (ахахаха)\SpacecraftSite\SpacecraftSite\Pages\Year.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div><a");
            BeginWriteAttribute("href", " href=\"", 296, "\"", 320, 2);
            WriteAttributeValue("", 303, "/Year/", 303, 6, true);
#nullable restore
#line 14 "D:\Диплом (ахахаха)\SpacecraftSite\SpacecraftSite\Pages\Year.cshtml"
WriteAttributeValue("", 309, Model.Year, 309, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 14 "D:\Диплом (ахахаха)\SpacecraftSite\SpacecraftSite\Pages\Year.cshtml"
                                    Write(Model.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></div>\r\n");
#nullable restore
#line 15 "D:\Диплом (ахахаха)\SpacecraftSite\SpacecraftSite\Pages\Year.cshtml"
         if (Model.nextYear)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div><a");
            BeginWriteAttribute("href", " href=\"", 405, "\"", 433, 2);
            WriteAttributeValue("", 412, "/Year/", 412, 6, true);
#nullable restore
#line 17 "D:\Диплом (ахахаха)\SpacecraftSite\SpacecraftSite\Pages\Year.cshtml"
WriteAttributeValue("", 418, Model.Year+1, 418, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 17 "D:\Диплом (ахахаха)\SpacecraftSite\SpacecraftSite\Pages\Year.cshtml"
                                             Write(Model.Year+1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></div>\r\n");
#nullable restore
#line 18 "D:\Диплом (ахахаха)\SpacecraftSite\SpacecraftSite\Pages\Year.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n    <br />\r\n");
            WriteLiteral(@"    <h3>Статистика</h3>
    <table border=""1"" cellpadding=""4"">
        <tr>
            <th>Країна</th>
            <th>Всього польотів</th>
            <th>Успішних</th>
            <th>Провальних</th>
            <th>Відсоток успіху</th>
        </tr>
");
#nullable restore
#line 31 "D:\Диплом (ахахаха)\SpacecraftSite\SpacecraftSite\Pages\Year.cshtml"
         foreach (var countryStatistics in Model.statistics)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n        <td><a");
            BeginWriteAttribute("href", " href=\"", 859, "\"", 905, 3);
            WriteAttributeValue("", 866, "/Country/", 866, 9, true);
#nullable restore
#line 34 "D:\Диплом (ахахаха)\SpacecraftSite\SpacecraftSite\Pages\Year.cshtml"
WriteAttributeValue("", 875, countryStatistics.country.Id, 875, 29, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 904, ".", 904, 1, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 34 "D:\Диплом (ахахаха)\SpacecraftSite\SpacecraftSite\Pages\Year.cshtml"
                                                         Write(countryStatistics.country.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>></td>\r\n        <td>");
#nullable restore
#line 35 "D:\Диплом (ахахаха)\SpacecraftSite\SpacecraftSite\Pages\Year.cshtml"
       Write(countryStatistics.allSpacecraft);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 36 "D:\Диплом (ахахаха)\SpacecraftSite\SpacecraftSite\Pages\Year.cshtml"
       Write(countryStatistics.successfull);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 37 "D:\Диплом (ахахаха)\SpacecraftSite\SpacecraftSite\Pages\Year.cshtml"
       Write(countryStatistics.failed);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 38 "D:\Диплом (ахахаха)\SpacecraftSite\SpacecraftSite\Pages\Year.cshtml"
        Write(countryStatistics.percentage);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</td>\r\n    </tr>\r\n");
#nullable restore
#line 40 "D:\Диплом (ахахаха)\SpacecraftSite\SpacecraftSite\Pages\Year.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n        <th>Всього</th>\r\n        <th>");
#nullable restore
#line 43 "D:\Диплом (ахахаха)\SpacecraftSite\SpacecraftSite\Pages\Year.cshtml"
       Write(Model.completeStatistics.allSpacecraft);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n        <th>");
#nullable restore
#line 44 "D:\Диплом (ахахаха)\SpacecraftSite\SpacecraftSite\Pages\Year.cshtml"
       Write(Model.completeStatistics.successfull);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n        <th>");
#nullable restore
#line 45 "D:\Диплом (ахахаха)\SpacecraftSite\SpacecraftSite\Pages\Year.cshtml"
       Write(Model.completeStatistics.failed);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n        <th>");
#nullable restore
#line 46 "D:\Диплом (ахахаха)\SpacecraftSite\SpacecraftSite\Pages\Year.cshtml"
        Write(Model.completeStatistics.percentage);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</th>\r\n    </tr>\r\n    </table>\r\n    <br />\r\n");
            WriteLiteral("    <h3>Апарати</h3>\r\n    <table border=\"1\" cellpadding=\"4\">\r\n        <tr>\r\n            <th>Супутник</th>\r\n            <th>Дата запуску</th>\r\n            <th>Мета</th>\r\n            <th>Країна</th>\r\n            <th>Результат</th>\r\n        </tr>\r\n");
#nullable restore
#line 60 "D:\Диплом (ахахаха)\SpacecraftSite\SpacecraftSite\Pages\Year.cshtml"
         foreach (var spacecraft in Model.spacecrafts)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td><a");
            BeginWriteAttribute("href", " href=\"", 1816, "\"", 1849, 2);
            WriteAttributeValue("", 1823, "/Spacecraft/", 1823, 12, true);
#nullable restore
#line 63 "D:\Диплом (ахахаха)\SpacecraftSite\SpacecraftSite\Pages\Year.cshtml"
WriteAttributeValue("", 1835, spacecraft.Id, 1835, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 63 "D:\Диплом (ахахаха)\SpacecraftSite\SpacecraftSite\Pages\Year.cshtml"
                                                    Write(spacecraft.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n                <td>");
#nullable restore
#line 64 "D:\Диплом (ахахаха)\SpacecraftSite\SpacecraftSite\Pages\Year.cshtml"
               Write(spacecraft.Launch.LaunchDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 65 "D:\Диплом (ахахаха)\SpacecraftSite\SpacecraftSite\Pages\Year.cshtml"
               Write(spacecraft.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td><a");
            BeginWriteAttribute("href", " href=\"", 2019, "\"", 2057, 2);
            WriteAttributeValue("", 2026, "/Country/", 2026, 9, true);
#nullable restore
#line 66 "D:\Диплом (ахахаха)\SpacecraftSite\SpacecraftSite\Pages\Year.cshtml"
WriteAttributeValue("", 2035, spacecraft.Country.Id, 2035, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 66 "D:\Диплом (ахахаха)\SpacecraftSite\SpacecraftSite\Pages\Year.cshtml"
                                                         Write(spacecraft.Country.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n");
#nullable restore
#line 67 "D:\Диплом (ахахаха)\SpacecraftSite\SpacecraftSite\Pages\Year.cshtml"
                 if (spacecraft.Launch.Success == true)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>Успіх</td>\r\n");
#nullable restore
#line 70 "D:\Диплом (ахахаха)\SpacecraftSite\SpacecraftSite\Pages\Year.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>Провал</td>\r\n");
#nullable restore
#line 74 "D:\Диплом (ахахаха)\SpacecraftSite\SpacecraftSite\Pages\Year.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tr>\r\n");
#nullable restore
#line 76 "D:\Диплом (ахахаха)\SpacecraftSite\SpacecraftSite\Pages\Year.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SpacecraftSite.Pages.YearModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SpacecraftSite.Pages.YearModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SpacecraftSite.Pages.YearModel>)PageContext?.ViewData;
        public SpacecraftSite.Pages.YearModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
