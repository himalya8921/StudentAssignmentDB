#pragma checksum "C:\Users\HP\source\repos\StudentAssignmentDb\StudentAssignmentDb\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c3b9b1e71fb5ae591feee83f208076052edb99b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\HP\source\repos\StudentAssignmentDb\StudentAssignmentDb\Views\_ViewImports.cshtml"
using StudentAssignmentDb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\source\repos\StudentAssignmentDb\StudentAssignmentDb\Views\_ViewImports.cshtml"
using StudentAssignmentDb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c3b9b1e71fb5ae591feee83f208076052edb99b", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d6bc0f389c0cb3b10756b337812f23d8f4e3f56", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<StudentEntities.CustomEntities.StudentModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddNewStudent", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n<h1>DisplayStudentsList</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c3b9b1e71fb5ae591feee83f208076052edb99b3897", async() => {
                WriteLiteral("Add New Student");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n\r\n");
#nullable restore
#line 18 "C:\Users\HP\source\repos\StudentAssignmentDb\StudentAssignmentDb\Views\Home\Index.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>\r\n        Search Name: ");
#nullable restore
#line 21 "C:\Users\HP\source\repos\StudentAssignmentDb\StudentAssignmentDb\Views\Home\Index.cshtml"
                Write(Html.TextBox("Search_Data", ViewBag.FilterValue as string));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <input type=\"submit\" value=\"Find\" />\r\n    </p>\r\n");
#nullable restore
#line 24 "C:\Users\HP\source\repos\StudentAssignmentDb\StudentAssignmentDb\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 29 "C:\Users\HP\source\repos\StudentAssignmentDb\StudentAssignmentDb\Views\Home\Index.cshtml"
           Write(Html.ActionLink("StudentId", "Index", new { Sorting_Order = "Student_Id", Filter_Value = ViewBag.FilterValue }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 32 "C:\Users\HP\source\repos\StudentAssignmentDb\StudentAssignmentDb\Views\Home\Index.cshtml"
           Write(Html.ActionLink("StudentName", "Index", new { Sorting_Order = "Student_Name", Filter_Value = ViewBag.FilterValue }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </th>
            <th>
                StudentCity
            </th>
          
            <th>
                FathersName
            </th>
            <th>
                LastName
            </th>
            <th>
                Teachers Name
            </th>

            <th>
                College Name
            </th>




            <th></th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 59 "C:\Users\HP\source\repos\StudentAssignmentDb\StudentAssignmentDb\Views\Home\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 63 "C:\Users\HP\source\repos\StudentAssignmentDb\StudentAssignmentDb\Views\Home\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.StudentId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 66 "C:\Users\HP\source\repos\StudentAssignmentDb\StudentAssignmentDb\Views\Home\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.StudentName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 69 "C:\Users\HP\source\repos\StudentAssignmentDb\StudentAssignmentDb\Views\Home\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.StudentCity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n          \r\n            <td>\r\n                ");
#nullable restore
#line 73 "C:\Users\HP\source\repos\StudentAssignmentDb\StudentAssignmentDb\Views\Home\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FathersName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 76 "C:\Users\HP\source\repos\StudentAssignmentDb\StudentAssignmentDb\Views\Home\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n\r\n            <td>\r\n                ");
#nullable restore
#line 80 "C:\Users\HP\source\repos\StudentAssignmentDb\StudentAssignmentDb\Views\Home\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TeacherName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 83 "C:\Users\HP\source\repos\StudentAssignmentDb\StudentAssignmentDb\Views\Home\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CollegeName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n\r\n\r\n            <td>\r\n                ");
#nullable restore
#line 88 "C:\Users\HP\source\repos\StudentAssignmentDb\StudentAssignmentDb\Views\Home\Index.cshtml"
           Write(Html.ActionLink("Edit", "UpdateStudent", new { id = item.StudentId }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 89 "C:\Users\HP\source\repos\StudentAssignmentDb\StudentAssignmentDb\Views\Home\Index.cshtml"
           Write(Html.ActionLink("Details", "DisplayIndividualStudent", new { id = item.StudentId }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 90 "C:\Users\HP\source\repos\StudentAssignmentDb\StudentAssignmentDb\Views\Home\Index.cshtml"
           Write(Html.ActionLink("Delete", "DeleteStudent", new { id = item.StudentId }, new { onclick = "return confirm('Do you really want to delete?');" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 93 "C:\Users\HP\source\repos\StudentAssignmentDb\StudentAssignmentDb\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n<br />");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<StudentEntities.CustomEntities.StudentModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
