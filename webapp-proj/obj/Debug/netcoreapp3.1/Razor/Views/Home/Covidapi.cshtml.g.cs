#pragma checksum "D:\VisualStudioCode\CodeBackUp\webapp-proj\Views\Home\Covidapi.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3d54bf9d83e9b14af28f4eb64172650a91c66338"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Covidapi), @"mvc.1.0.view", @"/Views/Home/Covidapi.cshtml")]
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
#line 1 "D:\VisualStudioCode\CodeBackUp\webapp-proj\Views\_ViewImports.cshtml"
using webapp_proj;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\VisualStudioCode\CodeBackUp\webapp-proj\Views\_ViewImports.cshtml"
using webapp_proj.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d54bf9d83e9b14af28f4eb64172650a91c66338", @"/Views/Home/Covidapi.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ecaeebc2a9a885179d03f45970f349ad24fac02", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Covidapi : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CovidData>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\VisualStudioCode\CodeBackUp\webapp-proj\Views\Home\Covidapi.cshtml"
  
    ViewData["Title"] = "Covid 19 Report";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<table class=""table"">
  <thead>
    <tr>     
      <th scope=""col"">Active Cases</th>
      <th scope=""col"">Active Cases Change</th>
      <th scope=""col"">Vaccine</th>
      <th scope=""col"">Cases</th>
    </tr>
  </thead>
  <tbody>
    <tr>
      <!--<th scope=""row"">1</th>-->
      <td>");
#nullable restore
#line 18 "D:\VisualStudioCode\CodeBackUp\webapp-proj\Views\Home\Covidapi.cshtml"
     Write(Model[0].ActiveCases);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n      <td>");
#nullable restore
#line 19 "D:\VisualStudioCode\CodeBackUp\webapp-proj\Views\Home\Covidapi.cshtml"
     Write(Model[0].ActiveCasesChange);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n      <td>");
#nullable restore
#line 20 "D:\VisualStudioCode\CodeBackUp\webapp-proj\Views\Home\Covidapi.cshtml"
     Write(Model[0].Vaccine);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n      <td>");
#nullable restore
#line 21 "D:\VisualStudioCode\CodeBackUp\webapp-proj\Views\Home\Covidapi.cshtml"
     Write(Model[0].Cases);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n  </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CovidData>> Html { get; private set; }
    }
}
#pragma warning restore 1591
