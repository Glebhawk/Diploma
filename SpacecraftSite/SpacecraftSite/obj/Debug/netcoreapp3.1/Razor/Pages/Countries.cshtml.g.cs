#pragma checksum "D:\Диплом (ахахаха)\SpacecraftSite\SpacecraftSite\Pages\Countries.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8c9fba6f097417d84d83a503140dcf3115b087c5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(SpacecraftSite.Pages.Pages_Countries), @"mvc.1.0.razor-page", @"/Pages/Countries.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c9fba6f097417d84d83a503140dcf3115b087c5", @"/Pages/Countries.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4182ce6d3ce9f608bf5a0287a57ef93ad687410e", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Countries : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\Диплом (ахахаха)\SpacecraftSite\SpacecraftSite\Pages\Countries.cshtml"
  
    ViewData["Title"] = "Країни";


#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>Країни</h1>\r\n    <br />\r\n");
            WriteLiteral("    <div>\r\n");
#nullable restore
#line 10 "D:\Диплом (ахахаха)\SpacecraftSite\SpacecraftSite\Pages\Countries.cshtml"
         foreach (var countryStatistics in Model.statistics)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div");
            BeginWriteAttribute("onclick", " onclick=\"", 227, "\"", 300, 5);
            WriteAttributeValue("", 237, "window.location.href", 237, 20, true);
            WriteAttributeValue(" ", 257, "=", 258, 2, true);
            WriteAttributeValue(" ", 259, "\'/Country/", 260, 11, true);
#nullable restore
#line 12 "D:\Диплом (ахахаха)\SpacecraftSite\SpacecraftSite\Pages\Countries.cshtml"
WriteAttributeValue("", 270, countryStatistics.country.Id, 270, 29, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 299, "\'", 299, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                <h5>");
#nullable restore
#line 13 "D:\Диплом (ахахаха)\SpacecraftSite\SpacecraftSite\Pages\Countries.cshtml"
               Write(countryStatistics.country.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                <table border=\"1\" cellpadding=\"4\">\r\n                    <tr><td>Всього польотів</td><td>");
#nullable restore
#line 15 "D:\Диплом (ахахаха)\SpacecraftSite\SpacecraftSite\Pages\Countries.cshtml"
                                               Write(countryStatistics.allSpacecraft);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\r\n                    <tr><td>Успішних</td><td>");
#nullable restore
#line 16 "D:\Диплом (ахахаха)\SpacecraftSite\SpacecraftSite\Pages\Countries.cshtml"
                                        Write(countryStatistics.successfull);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\r\n                    <tr><td>Провальних</td><td>");
#nullable restore
#line 17 "D:\Диплом (ахахаха)\SpacecraftSite\SpacecraftSite\Pages\Countries.cshtml"
                                          Write(countryStatistics.failed);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\r\n                    <tr><td>Відсоток успіху</td><td>");
#nullable restore
#line 18 "D:\Диплом (ахахаха)\SpacecraftSite\SpacecraftSite\Pages\Countries.cshtml"
                                                Write(countryStatistics.percentage);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</td></tr>\r\n                </table>\r\n            </div>\r\n");
#nullable restore
#line 21 "D:\Диплом (ахахаха)\SpacecraftSite\SpacecraftSite\Pages\Countries.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SpacecraftSite.Pages.CountriesModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SpacecraftSite.Pages.CountriesModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SpacecraftSite.Pages.CountriesModel>)PageContext?.ViewData;
        public SpacecraftSite.Pages.CountriesModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591