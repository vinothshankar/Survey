#pragma checksum "F:\Projects\Survey\Views\Survey\Questions.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0c77f339a239e2812dbce99d72f7acc69a35a353"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Survey_Questions), @"mvc.1.0.view", @"/Views/Survey/Questions.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c77f339a239e2812dbce99d72f7acc69a35a353", @"/Views/Survey/Questions.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f26f51eb28d116973617f5ce63736259ac94b8c4", @"/Views/_ViewImports.cshtml")]
    public class Views_Survey_Questions : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Questions>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "F:\Projects\Survey\Views\Survey\Questions.cshtml"
  
    int count = 1, countR = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container\">\r\n\r\n    <div class=\"Survey\">\r\n\r\n        <h4 style=\"margin-top: 4%;\"> <span class=\"label label-info\">Questions :</span> </h4>\r\n\r\n");
#nullable restore
#line 11 "F:\Projects\Survey\Views\Survey\Questions.cshtml"
         if (Model != null && Model.Any())
        {

            foreach (var question in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""BlockQ"" style=""border: 1px solid #bdbdbd; width: 75%; border-radius: 4px; margin-top: 40px; background-color: #f0ffff; padding: 8px;"">

                    <div class=""Question"" style=""padding: 2%;"">
                        <span class=""label label-warning""> ");
#nullable restore
#line 19 "F:\Projects\Survey\Views\Survey\Questions.cshtml"
                                                      Write(string.Format("{0}{1}.", "Q", count));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        <span");
            BeginWriteAttribute("id", " id=\"", 696, "\"", 740, 1);
#nullable restore
#line 20 "F:\Projects\Survey\Views\Survey\Questions.cshtml"
WriteAttributeValue("", 701, string.Format("{0}{1}", "ID_Q", count), 701, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"display:none;\">");
#nullable restore
#line 20 "F:\Projects\Survey\Views\Survey\Questions.cshtml"
                                                                                            Write(question.QuestionId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        <p style=\"display: inline; padding: 2%;\"");
            BeginWriteAttribute("id", " id=\"", 857, "\"", 898, 1);
#nullable restore
#line 21 "F:\Projects\Survey\Views\Survey\Questions.cshtml"
WriteAttributeValue("", 862, string.Format("{0}{1}", "Q", count), 862, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 21 "F:\Projects\Survey\Views\Survey\Questions.cshtml"
                                                                                                      Write(question.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (");
#nullable restore
#line 21 "F:\Projects\Survey\Views\Survey\Questions.cshtml"
                                                                                                                       Write(question.SubTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</p>\r\n                    </div>\r\n\r\n                    <div class=\"Choices\" style=\"margin-left: 8%;\">\r\n\r\n");
#nullable restore
#line 26 "F:\Projects\Survey\Views\Survey\Questions.cshtml"
                         foreach (var choice in question.options)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <label class=\"radio-inline\">\r\n                                <input type=\"radio\"");
            BeginWriteAttribute("name", " name=\"", 1245, "\"", 1304, 1);
#nullable restore
#line 29 "F:\Projects\Survey\Views\Survey\Questions.cshtml"
WriteAttributeValue("", 1252, string.Format("{0}{1}", "inlineRadioOptions",count), 1252, 52, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 1305, "\"", 1357, 1);
#nullable restore
#line 29 "F:\Projects\Survey\Views\Survey\Questions.cshtml"
WriteAttributeValue("", 1310, string.Format("{0}{1}", "inlineRadio", countR), 1310, 47, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 1358, "\"", 1382, 1);
#nullable restore
#line 29 "F:\Projects\Survey\Views\Survey\Questions.cshtml"
WriteAttributeValue("", 1366, choice.OptionId, 1366, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"margin-left: -16px;\"> ");
#nullable restore
#line 29 "F:\Projects\Survey\Views\Survey\Questions.cshtml"
                                                                                                                                                                                                                      Write(choice.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </label><br />\r\n");
#nullable restore
#line 31 "F:\Projects\Survey\Views\Survey\Questions.cshtml"
                            countR++;
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 36 "F:\Projects\Survey\Views\Survey\Questions.cshtml"
                count++;
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <span id=\"countQuections\" style=\"display:none;\">");
#nullable restore
#line 38 "F:\Projects\Survey\Views\Survey\Questions.cshtml"
                                                       Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            <button type=\"button\" id=\"SubmitSurvey\" class=\"btn btn-light\" style=\"margin-top: 10px;\"><span class=\"glyphicon glyphicon-ok\"></span>   Submit Survey </button>\r\n            <a href=\"/Survey/Index\" class=\"btn btn-default\">Back</a>\r\n");
#nullable restore
#line 41 "F:\Projects\Survey\Views\Survey\Questions.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    </div>
</div>

<script type=""text/javascript"">


    $(document).ready(function () {

        $('#SubmitSurvey').on('click', function () {

            //count Questions
            var sel = $('#countQuections').text();
            var resultSurvey = [], countQuestion = parseInt(sel), question = {}, j = 1;

            for (var i = 1; i < countQuestion; i++) {
                resultSurvey.push({
                    QuestionID: $('#ID_Q' + i).text(),
                    OptionId: $('input[name=inlineRadioOptions' + i + ']:checked').val()
                });
            }

            $.ajax({
                url: 'SaveResult',
                type: 'POST',
                data: JSON.stringify(resultSurvey),
                success: function (response) {
                    alert(""Survey Completed Successfully"");
                    window.location.href = ""/Survey/Index"";
                },
                error: function (response) {

                }
            });

");
            WriteLiteral("        });\r\n    });\r\n\r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Questions>> Html { get; private set; }
    }
}
#pragma warning restore 1591
