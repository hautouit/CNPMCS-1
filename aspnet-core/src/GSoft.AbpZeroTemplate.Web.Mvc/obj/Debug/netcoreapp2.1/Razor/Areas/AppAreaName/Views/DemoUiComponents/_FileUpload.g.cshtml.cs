#pragma checksum "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\DemoUiComponents\_FileUpload.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ad67331eb8a5b4f3fdf384a7f092c47a7302b60b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AppAreaName_Views_DemoUiComponents__FileUpload), @"mvc.1.0.view", @"/Areas/AppAreaName/Views/DemoUiComponents/_FileUpload.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/AppAreaName/Views/DemoUiComponents/_FileUpload.cshtml", typeof(AspNetCore.Areas_AppAreaName_Views_DemoUiComponents__FileUpload))]
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
#line 1 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\_ViewImports.cshtml"
using Abp.Localization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad67331eb8a5b4f3fdf384a7f092c47a7302b60b", @"/Areas/AppAreaName/Views/DemoUiComponents/_FileUpload.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4eef59065c4b39f709eb64b90c2355595a8a2772", @"/Areas/AppAreaName/Views/_ViewImports.cshtml")]
    public class Areas_AppAreaName_Views_DemoUiComponents__FileUpload : GSoft.AbpZeroTemplate.Web.Views.AbpZeroTemplateRazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(0, 240, true);
            WriteLiteral("<div class=\"m-portlet m-portlet--mobile\">\n    <div class=\"m-portlet__head\">\n        <div class=\"m-portlet__head-caption\">\n            <div class=\"m-portlet__head-title\">\n                <h3 class=\"m-portlet__head-text\">\n                    ");
            EndContext();
            BeginContext(241, 15, false);
#line 6 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\DemoUiComponents\_FileUpload.cshtml"
               Write(L("FileUpload"));

#line default
#line hidden
            EndContext();
            BeginContext(256, 110, true);
            WriteLiteral("\n                </h3>\n            </div>\n        </div>\n    </div>\n    <div class=\"m-portlet__body\">\n        ");
            EndContext();
            BeginContext(366, 1588, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "857744618aba4c1ea9f5126de016aa97", async() => {
                BeginContext(384, 1563, true);
                WriteLiteral(@"

            <div class=""row"">
                <div class=""col-md-2"">
                    <label class=""control-label"">Default file uploader</label>
                </div>
                <div class=""col-md-10"">

                    <div class=""form-group"">
                        <label for=""DefaultFileUploadTextInput"">Free text</label>
                        <input id=""DefaultFileUploadTextInput"" type=""text"" name=""DefaultFileUploadTextInput"" class=""form-control"">
                    </div>

                    <div class=""form-group"">

                        <!-- The fileinput-button span is used to style the file input field as button -->
                        <span class=""btn btn-primary fileinput-button"">
                            <i class=""glyphicon glyphicon-plus""></i>
                            <span>Select files...</span>
                            <!-- The file input field used as target for the file upload widget -->
                            <input id=""fileupload"" type=""file"" name=""file");
                WriteLiteral(@"s"">
                        </span>
                        <br>
                        <br>

                        <!-- The global progress bar -->
                        <div id=""progress"" class=""progress"">
                            <div class=""progress-bar progress-bar-success""></div>
                        </div>

                        <!-- The container for the uploaded files -->
                        <div id=""files"" class=""files""></div>

                    </div>

                </div>

            </div>

        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1954, 19, true);
            WriteLiteral("\n    </div>\n</div>\n");
            EndContext();
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
