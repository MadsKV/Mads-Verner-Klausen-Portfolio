#pragma checksum "C:\Users\MadsV\OneDrive\Dokumenter\GitHub\Mads-Verner-Klausen-Portfolio\H3\XML\XML H3SCHOOL\XML H3SCHOOL MVC\XML H3SCHOOL MVC\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "38b2ad6b9124fcbc5c28e48941efd1a3c0fe8885"
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
#line 1 "C:\Users\MadsV\OneDrive\Dokumenter\GitHub\Mads-Verner-Klausen-Portfolio\H3\XML\XML H3SCHOOL\XML H3SCHOOL MVC\XML H3SCHOOL MVC\Views\_ViewImports.cshtml"
using XML_H3SCHOOL_MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\MadsV\OneDrive\Dokumenter\GitHub\Mads-Verner-Klausen-Portfolio\H3\XML\XML H3SCHOOL\XML H3SCHOOL MVC\XML H3SCHOOL MVC\Views\_ViewImports.cshtml"
using XML_H3SCHOOL_MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"38b2ad6b9124fcbc5c28e48941efd1a3c0fe8885", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"351f886fe6bf8ab0ad311d1eee363b1567f9485a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\MadsV\OneDrive\Dokumenter\GitHub\Mads-Verner-Klausen-Portfolio\H3\XML\XML H3SCHOOL\XML H3SCHOOL MVC\XML H3SCHOOL MVC\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "38b2ad6b9124fcbc5c28e48941efd1a3c0fe88853746", async() => {
                WriteLiteral("\r\n        <h1 class=\"display-4\">Welcome</h1>\r\n        <input type=\"button\" value=\"xmlTransformator\"");
                BeginWriteAttribute("onclick", " onclick=\"", 183, "\"", 248, 3);
                WriteAttributeValue("", 193, "location.href=\'", 193, 15, true);
#nullable restore
#line 8 "C:\Users\MadsV\OneDrive\Dokumenter\GitHub\Mads-Verner-Klausen-Portfolio\H3\XML\XML H3SCHOOL\XML H3SCHOOL MVC\XML H3SCHOOL MVC\Views\Home\Index.cshtml"
WriteAttributeValue("", 208, Url.Action("xmlTransformator", "Home"), 208, 39, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 247, "\'", 247, 1, true);
                EndWriteAttribute();
                WriteLiteral(" />\r\n        <p>Transformation</p>\r\n        ");
#nullable restore
#line 10 "C:\Users\MadsV\OneDrive\Dokumenter\GitHub\Mads-Verner-Klausen-Portfolio\H3\XML\XML H3SCHOOL\XML H3SCHOOL MVC\XML H3SCHOOL MVC\Views\Home\Index.cshtml"
   Write(ViewBag.TransformMessage);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n        <input type=\"button\" value=\"Validator\"");
                BeginWriteAttribute("onclick", " onclick=\"", 368, "\"", 432, 3);
                WriteAttributeValue("", 378, "location.href=\'", 378, 15, true);
#nullable restore
#line 12 "C:\Users\MadsV\OneDrive\Dokumenter\GitHub\Mads-Verner-Klausen-Portfolio\H3\XML\XML H3SCHOOL\XML H3SCHOOL MVC\XML H3SCHOOL MVC\Views\Home\Index.cshtml"
WriteAttributeValue("", 393, Url.Action("XPathValidation", "Home"), 393, 38, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 431, "\'", 431, 1, true);
                EndWriteAttribute();
                WriteLiteral(" />\r\n        <p>Validate</p>\r\n        ");
#nullable restore
#line 14 "C:\Users\MadsV\OneDrive\Dokumenter\GitHub\Mads-Verner-Klausen-Portfolio\H3\XML\XML H3SCHOOL\XML H3SCHOOL MVC\XML H3SCHOOL MVC\Views\Home\Index.cshtml"
   Write(ViewBag.ValidateMessage);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
