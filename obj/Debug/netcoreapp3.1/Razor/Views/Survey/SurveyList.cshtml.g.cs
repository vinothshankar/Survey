#pragma checksum "F:\Projects\Survey\Views\Survey\SurveyList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cff6fa7130185316af135e4a7afe76c6381470a1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Survey_SurveyList), @"mvc.1.0.view", @"/Views/Survey/SurveyList.cshtml")]
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
#line 1 "F:\Projects\Survey\Views\_ViewImports.cshtml"
using Survey;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Projects\Survey\Views\_ViewImports.cshtml"
using Survey.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cff6fa7130185316af135e4a7afe76c6381470a1", @"/Views/Survey/SurveyList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f26f51eb28d116973617f5ce63736259ac94b8c4", @"/Views/_ViewImports.cshtml")]
    public class Views_Survey_SurveyList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Surveys>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "F:\Projects\Survey\Views\Survey\SurveyList.cshtml"
  
    ViewBag.Title = "SelectSurvey";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n    <div class=\"panel panel-default\">\r\n        <div class=\"panel-heading\">Compass Survey</div>\r\n        <div class=\"panel-body\">\r\n");
#nullable restore
#line 11 "F:\Projects\Survey\Views\Survey\SurveyList.cshtml"
             foreach (var survey in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <a");
            BeginWriteAttribute("href", " href=\"", 302, "\"", 372, 2);
            WriteAttributeValue("", 309, "/Survey/FetchAllQuestionsBySurveyId?surveyId=", 309, 45, true);
#nullable restore
#line 13 "F:\Projects\Survey\Views\Survey\SurveyList.cshtml"
WriteAttributeValue("", 354, survey.SurveyId, 354, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-light\">");
#nullable restore
#line 13 "F:\Projects\Survey\Views\Survey\SurveyList.cshtml"
                                                                                                           Write(survey.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                <br />\r\n                <br />\r\n");
#nullable restore
#line 16 "F:\Projects\Survey\Views\Survey\SurveyList.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Surveys>> Html { get; private set; }
    }
}
#pragma warning restore 1591