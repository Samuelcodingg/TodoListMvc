#pragma checksum "D:\Samuel\Desarrollo Web\C#\TodoListMvc\TodoListMvc\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eb1851c8ca6cf3a2d8cc78750c15b7a230725402"
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
#line 1 "D:\Samuel\Desarrollo Web\C#\TodoListMvc\TodoListMvc\Views\_ViewImports.cshtml"
using TodoListMvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Samuel\Desarrollo Web\C#\TodoListMvc\TodoListMvc\Views\_ViewImports.cshtml"
using TodoListMvc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb1851c8ca6cf3a2d8cc78750c15b7a230725402", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"82d2c9e157f49b778de9b90e5000706e6b369309", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TodoListMvc.Models.Todo>>
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
#line 2 "D:\Samuel\Desarrollo Web\C#\TodoListMvc\TodoListMvc\Views\Home\Index.cshtml"
   ViewData["Title"] = "Home"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"p-3 mx-auto\">\r\n    <h2>Todo List</h2>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eb1851c8ca6cf3a2d8cc78750c15b7a2307254023486", async() => {
                WriteLiteral("\r\n        <div class=\"d-flex\">\r\n            <input type=\"text\" placeholder=\"Add your new todo\" class=\"form-control\" />\r\n            <button class=\"btn btn-success ml-1\"><i class=\"fas fa-plus\"></i></button>\r\n        </div>\r\n");
#nullable restore
#line 11 "D:\Samuel\Desarrollo Web\C#\TodoListMvc\TodoListMvc\Views\Home\Index.cshtml"
         if (Model.Count() > 0)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"            <div class=""py-2"">
                <div class=""bg-light p-2 mt-2 d-flex justify-content-between"">
                    <h5>This is a todo :)</h5>
                    <div>
                        <button class=""btn btn-secondary""><i class=""far fa-edit""></i></button>
                        <button class=""btn btn-danger""><i class=""far fa-trash-alt""></i></button>
                    </div>
                </div>
            </div>
            <div class=""d-flex align-items-center py-5 justify-content-between"">
                <h5>You have # pending tasks</h5>
                <button class=""btn btn-info"">Clear All</button>
            </div>
");
#nullable restore
#line 26 "D:\Samuel\Desarrollo Web\C#\TodoListMvc\TodoListMvc\Views\Home\Index.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <h5 class=\"text-center mt-3\">There is not any todo.</h5>\r\n");
#nullable restore
#line 30 "D:\Samuel\Desarrollo Web\C#\TodoListMvc\TodoListMvc\Views\Home\Index.cshtml"
        }

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
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TodoListMvc.Models.Todo>> Html { get; private set; }
    }
}
#pragma warning restore 1591
