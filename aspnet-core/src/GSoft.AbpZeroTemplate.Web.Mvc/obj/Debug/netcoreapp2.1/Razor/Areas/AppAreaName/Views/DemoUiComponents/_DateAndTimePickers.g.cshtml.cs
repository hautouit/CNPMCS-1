#pragma checksum "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\DemoUiComponents\_DateAndTimePickers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6d7a3d2f237687253fac15065c7212361e03a52d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AppAreaName_Views_DemoUiComponents__DateAndTimePickers), @"mvc.1.0.view", @"/Areas/AppAreaName/Views/DemoUiComponents/_DateAndTimePickers.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/AppAreaName/Views/DemoUiComponents/_DateAndTimePickers.cshtml", typeof(AspNetCore.Areas_AppAreaName_Views_DemoUiComponents__DateAndTimePickers))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d7a3d2f237687253fac15065c7212361e03a52d", @"/Areas/AppAreaName/Views/DemoUiComponents/_DateAndTimePickers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4eef59065c4b39f709eb64b90c2355595a8a2772", @"/Areas/AppAreaName/Views/_ViewImports.cshtml")]
    public class Areas_AppAreaName_Views_DemoUiComponents__DateAndTimePickers : GSoft.AbpZeroTemplate.Web.Views.AbpZeroTemplateRazorPage<dynamic>
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
            BeginContext(241, 23, false);
#line 6 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\DemoUiComponents\_DateAndTimePickers.cshtml"
               Write(L("DateAndTimePickers"));

#line default
#line hidden
            EndContext();
            BeginContext(264, 110, true);
            WriteLiteral("\n                </h3>\n            </div>\n        </div>\n    </div>\n    <div class=\"m-portlet__body\">\n        ");
            EndContext();
            BeginContext(374, 1700, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c4081b952a8e4e4bbacf4dd619d2f9df", async() => {
                BeginContext(392, 446, true);
                WriteLiteral(@"
            
            <div class=""form-group m-form__group"">
                <label for=""SampleDatePicker"">Default date picker</label>
                <div id=""SampleDatePicker"" class=""input-group"">
                    <input type=""datetime"" name=""SampleDatePicker"" class=""form-control date-picker"">
                    <span class=""input-group-btn"">
                        <button class=""btn btn-primary test-btn-date-picker"" type=""button"">");
                EndContext();
                BeginContext(839, 11, false);
#line 19 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\DemoUiComponents\_DateAndTimePickers.cshtml"
                                                                                      Write(L("Submit"));

#line default
#line hidden
                EndContext();
                BeginContext(850, 549, true);
                WriteLiteral(@"</button>
                    </span>
                </div>
            </div>
            
            <div class=""form-group m-form__group"">
                <label for=""SampleDateTimePicker"">Default datetime picker</label>
                <div id=""SampleDateTimePicker"" class=""input-group"">
                    <input type=""datetime"" name=""SampleDateTimePicker"" class=""form-control datetime-picker"">
                    <span class=""input-group-btn"">
                        <button class=""btn btn-primary test-btn-datetime-picker"" type=""button"">");
                EndContext();
                BeginContext(1400, 11, false);
#line 29 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\DemoUiComponents\_DateAndTimePickers.cshtml"
                                                                                          Write(L("Submit"));

#line default
#line hidden
                EndContext();
                BeginContext(1411, 555, true);
                WriteLiteral(@"</button>
                    </span>
                </div>
            </div>
            
            <div class=""form-group m-form__group"">
                <label for=""SampleDateRangePicker"">Default daterange picker</label>
                <div id=""SampleDateRangePicker"" class=""input-group"">
                    <input type=""datetime"" name=""SampleDateRangePicker"" class=""form-control daterange-picker"">
                    <span class=""input-group-btn"">
                        <button class=""btn btn-primary test-btn-daterange-picker"" type=""button"">");
                EndContext();
                BeginContext(1967, 11, false);
#line 39 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\DemoUiComponents\_DateAndTimePickers.cshtml"
                                                                                           Write(L("Submit"));

#line default
#line hidden
                EndContext();
                BeginContext(1978, 89, true);
                WriteLiteral("</button>\n                    </span>\n                </div>\n            </div>\n\n        ");
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
            BeginContext(2074, 19, true);
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
