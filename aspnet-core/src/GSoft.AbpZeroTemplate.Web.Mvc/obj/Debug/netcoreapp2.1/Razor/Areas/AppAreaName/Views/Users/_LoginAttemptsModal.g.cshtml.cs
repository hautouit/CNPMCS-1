#pragma checksum "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Users\_LoginAttemptsModal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bacd09352dd623b01c0810441c13049d2d225ec8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AppAreaName_Views_Users__LoginAttemptsModal), @"mvc.1.0.view", @"/Areas/AppAreaName/Views/Users/_LoginAttemptsModal.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/AppAreaName/Views/Users/_LoginAttemptsModal.cshtml", typeof(AspNetCore.Areas_AppAreaName_Views_Users__LoginAttemptsModal))]
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
#line 1 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Users\_LoginAttemptsModal.cshtml"
using Abp.Timing;

#line default
#line hidden
#line 2 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Users\_LoginAttemptsModal.cshtml"
using GSoft.AbpZeroTemplate.Web.Areas.AppAreaName.Models.Common.Modals;

#line default
#line hidden
#line 3 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Users\_LoginAttemptsModal.cshtml"
using GSoft.AbpZeroTemplate.Web.Areas.AppAreaName.Models.Users;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bacd09352dd623b01c0810441c13049d2d225ec8", @"/Areas/AppAreaName/Views/Users/_LoginAttemptsModal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4eef59065c4b39f709eb64b90c2355595a8a2772", @"/Areas/AppAreaName/Views/_ViewImports.cshtml")]
    public class Areas_AppAreaName_Views_Users__LoginAttemptsModal : GSoft.AbpZeroTemplate.Web.Views.AbpZeroTemplateRazorPage<UserLoginAttemptModalViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("loginAttemptsModalForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(193, 121, false);
#line 5 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Users\_LoginAttemptsModal.cshtml"
Write(Html.Partial("~/Areas/AppAreaName/Views/Common/Modals/_ModalHeader.cshtml", new ModalHeaderViewModel(L("LoginAttempts"))));

#line default
#line hidden
            EndContext();
            BeginContext(314, 30, true);
            WriteLiteral("\n<div class=\"modal-body\">\n    ");
            EndContext();
            BeginContext(344, 3806, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6983014f04964fc99f5c0f92f15b20b3", async() => {
                BeginContext(402, 103, true);
                WriteLiteral("\n        <div class=\"form-body\">\n            <div class=\"row\">\n                <div class=\"col-sm-12\">\n");
                EndContext();
#line 11 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Users\_LoginAttemptsModal.cshtml"
                     foreach (var loginAttempt in Model.LoginAttempts)
                    {

#line default
#line hidden
                BeginContext(598, 28, true);
                WriteLiteral("                        <div");
                EndContext();
                BeginWriteAttribute("class", " class=\"", 626, "\"", 766, 6);
                WriteAttributeValue("", 634, "m-alert", 634, 7, true);
                WriteAttributeValue(" ", 641, "m-alert--icon", 642, 14, true);
                WriteAttributeValue(" ", 655, "m-alert--icon-solid", 656, 20, true);
                WriteAttributeValue(" ", 675, "m-alert--outline", 676, 17, true);
                WriteAttributeValue(" ", 692, "alert", 693, 6, true);
#line 13 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Users\_LoginAttemptsModal.cshtml"
WriteAttributeValue(" ", 698, loginAttempt.Result == "Success" ?"alert-success":"alert-danger", 699, 67, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(767, 107, true);
                WriteLiteral(" role=\"alert\">\n                            <div class=\"m-alert__icon\">\n                                <img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 874, "\"", 1108, 1);
#line 15 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Users\_LoginAttemptsModal.cshtml"
WriteAttributeValue("", 880, loginAttempt.Result == "Success" ?
                                                "/Profile/GetProfilePicture?v="+Clock.Now.Ticks :
                                                "/Common/Images/default-profile-picture.png", 880, 228, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1109, 178, true);
                WriteLiteral(" class=\"m--img-rounded m--marginless m--img-centered\" width=\"50\" height=\"50\">\n                                <span></span>\n                                <small class=\"label\"> ");
                EndContext();
                BeginContext(1289, 61, false);
#line 19 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Users\_LoginAttemptsModal.cshtml"
                                                  Write(loginAttempt.Result == "Success" ? L("Success") : L("Failed"));

#line default
#line hidden
                EndContext();
                BeginContext(1351, 101, true);
                WriteLiteral(" </small>\n                            </div>\n                            <div class=\"m-alert__text\">\n");
                EndContext();
#line 22 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Users\_LoginAttemptsModal.cshtml"
                                 if (!string.IsNullOrEmpty(loginAttempt.ClientIpAddress))
                                {

#line default
#line hidden
                BeginContext(1576, 143, true);
                WriteLiteral("                                    <div class=\"row\">\n                                        <label class=\"control-label col-sm-3 text-right\">");
                EndContext();
                BeginContext(1720, 14, false);
#line 25 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Users\_LoginAttemptsModal.cshtml"
                                                                                    Write(L("IpAddress"));

#line default
#line hidden
                EndContext();
                BeginContext(1734, 196, true);
                WriteLiteral("</label>\n                                        <div class=\"col-sm-9\">\n                                            <p class=\"form-control-static\">\n                                                ");
                EndContext();
                BeginContext(1931, 28, false);
#line 28 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Users\_LoginAttemptsModal.cshtml"
                                           Write(loginAttempt.ClientIpAddress);

#line default
#line hidden
                EndContext();
                BeginContext(1959, 140, true);
                WriteLiteral("\n                                            </p>\n                                        </div>\n                                    </div>\n");
                EndContext();
#line 32 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Users\_LoginAttemptsModal.cshtml"
                                }

#line default
#line hidden
                BeginContext(2133, 32, true);
                WriteLiteral("                                ");
                EndContext();
#line 33 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Users\_LoginAttemptsModal.cshtml"
                                 if (!string.IsNullOrEmpty(loginAttempt.ClientName))
                                {

#line default
#line hidden
                BeginContext(2252, 143, true);
                WriteLiteral("                                    <div class=\"row\">\n                                        <label class=\"control-label col-sm-3 text-right\">");
                EndContext();
                BeginContext(2396, 11, false);
#line 36 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Users\_LoginAttemptsModal.cshtml"
                                                                                    Write(L("Client"));

#line default
#line hidden
                EndContext();
                BeginContext(2407, 196, true);
                WriteLiteral("</label>\n                                        <div class=\"col-sm-9\">\n                                            <p class=\"form-control-static\">\n                                                ");
                EndContext();
                BeginContext(2604, 23, false);
#line 39 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Users\_LoginAttemptsModal.cshtml"
                                           Write(loginAttempt.ClientName);

#line default
#line hidden
                EndContext();
                BeginContext(2627, 140, true);
                WriteLiteral("\n                                            </p>\n                                        </div>\n                                    </div>\n");
                EndContext();
#line 43 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Users\_LoginAttemptsModal.cshtml"
                                }

#line default
#line hidden
                BeginContext(2801, 32, true);
                WriteLiteral("                                ");
                EndContext();
#line 44 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Users\_LoginAttemptsModal.cshtml"
                                 if (!string.IsNullOrEmpty(loginAttempt.BrowserInfo))
                                {

#line default
#line hidden
                BeginContext(2921, 143, true);
                WriteLiteral("                                    <div class=\"row\">\n                                        <label class=\"control-label col-sm-3 text-right\">");
                EndContext();
                BeginContext(3065, 12, false);
#line 47 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Users\_LoginAttemptsModal.cshtml"
                                                                                    Write(L("Browser"));

#line default
#line hidden
                EndContext();
                BeginContext(3077, 196, true);
                WriteLiteral("</label>\n                                        <div class=\"col-sm-9\">\n                                            <p class=\"form-control-static\">\n                                                ");
                EndContext();
                BeginContext(3274, 24, false);
#line 50 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Users\_LoginAttemptsModal.cshtml"
                                           Write(loginAttempt.BrowserInfo);

#line default
#line hidden
                EndContext();
                BeginContext(3298, 140, true);
                WriteLiteral("\n                                            </p>\n                                        </div>\n                                    </div>\n");
                EndContext();
#line 54 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Users\_LoginAttemptsModal.cshtml"
                                }

#line default
#line hidden
                BeginContext(3472, 135, true);
                WriteLiteral("                                <div class=\"row\">\n                                    <label class=\"control-label col-sm-3 text-right\">");
                EndContext();
                BeginContext(3608, 9, false);
#line 56 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Users\_LoginAttemptsModal.cshtml"
                                                                                Write(L("Time"));

#line default
#line hidden
                EndContext();
                BeginContext(3617, 169, true);
                WriteLiteral("</label>\n                                    <div class=\"col-sm-9\">\n                                        <p class=\"form-control-static login-attempt-date\" data-date=\"");
                EndContext();
                BeginContext(3787, 76, false);
#line 58 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Users\_LoginAttemptsModal.cshtml"
                                                                                                Write(loginAttempt.CreationTime.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ"));

#line default
#line hidden
                EndContext();
                BeginContext(3863, 197, true);
                WriteLiteral("\">\n\n                                        </p>\n                                    </div>\n                                </div>\n                            </div>\n                        </div>\n");
                EndContext();
#line 65 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Users\_LoginAttemptsModal.cshtml"
                    }

#line default
#line hidden
                BeginContext(4082, 61, true);
                WriteLiteral("                </div>\n            </div>\n        </div>\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4150, 115, true);
            WriteLiteral("\n</div>\n<div class=\"modal-footer\">\n    <button type=\"button\" class=\"btn default close-button\" data-dismiss=\"modal\">");
            EndContext();
            BeginContext(4266, 10, false);
#line 72 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Users\_LoginAttemptsModal.cshtml"
                                                                           Write(L("Close"));

#line default
#line hidden
            EndContext();
            BeginContext(4276, 17, true);
            WriteLiteral("</button>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UserLoginAttemptModalViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
