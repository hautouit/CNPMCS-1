#pragma checksum "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Editions\_CreateOrEditModal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "88caa677e378cf1968bc911ada0596275b94e75f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AppAreaName_Views_Editions__CreateOrEditModal), @"mvc.1.0.view", @"/Areas/AppAreaName/Views/Editions/_CreateOrEditModal.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/AppAreaName/Views/Editions/_CreateOrEditModal.cshtml", typeof(AspNetCore.Areas_AppAreaName_Views_Editions__CreateOrEditModal))]
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
#line 1 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Editions\_CreateOrEditModal.cshtml"
using Abp.Application.Editions;

#line default
#line hidden
#line 2 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Editions\_CreateOrEditModal.cshtml"
using Abp.Application.Services.Dto;

#line default
#line hidden
#line 3 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Editions\_CreateOrEditModal.cshtml"
using Abp.Extensions;

#line default
#line hidden
#line 4 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Editions\_CreateOrEditModal.cshtml"
using GSoft.AbpZeroTemplate.Web.Areas.AppAreaName.Models.Common.Modals;

#line default
#line hidden
#line 5 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Editions\_CreateOrEditModal.cshtml"
using GSoft.AbpZeroTemplate.Web.Areas.AppAreaName.Models.Editions;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88caa677e378cf1968bc911ada0596275b94e75f", @"/Areas/AppAreaName/Views/Editions/_CreateOrEditModal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4eef59065c4b39f709eb64b90c2355595a8a2772", @"/Areas/AppAreaName/Views/_ViewImports.cshtml")]
    public class Areas_AppAreaName_Views_Editions__CreateOrEditModal : GSoft.AbpZeroTemplate.Web.Views.AbpZeroTemplateRazorPage<CreateOrEditEditionModalViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("EditionInformationsForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-validation"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(270, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(272, 199, false);
#line 8 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Editions\_CreateOrEditModal.cshtml"
Write(Html.Partial("~/Areas/AppAreaName/Views/Common/Modals/_ModalHeader.cshtml", new ModalHeaderViewModel(Model.IsEditMode ? (L("EditEdition") + ": " + Model.Edition.DisplayName) : L("CreateNewEdition"))));

#line default
#line hidden
            EndContext();
            BeginContext(471, 258, true);
            WriteLiteral(@"

<div class=""modal-body"">

    <ul class=""nav nav-tabs  m-tabs-line"" role=""tablist"">
        <li class=""nav-item m-tabs__item"">
            <a href=""#EditionInformationsTab"" class=""nav-link m-tabs__link active"" data-toggle=""tab"" role=""tab"">
                ");
            EndContext();
            BeginContext(730, 22, false);
#line 15 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Editions\_CreateOrEditModal.cshtml"
           Write(L("EditionProperties"));

#line default
#line hidden
            EndContext();
            BeginContext(752, 186, true);
            WriteLiteral("\n            </a>\n        </li>\n        <li class=\"nav-item m-tabs__item\">\n            <a href=\"#FeaturesTab\" class=\"nav-link m-tabs__link\" data-toggle=\"tab\" role=\"tab\">\n                ");
            EndContext();
            BeginContext(939, 13, false);
#line 20 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Editions\_CreateOrEditModal.cshtml"
           Write(L("Features"));

#line default
#line hidden
            EndContext();
            BeginContext(952, 168, true);
            WriteLiteral("\n            </a>\n        </li>\n    </ul>\n\n    <div class=\"tab-content\">\n        <div class=\"tab-pane active\" id=\"EditionInformationsTab\" role=\"tabpanel\">\n\n            ");
            EndContext();
            BeginContext(1120, 6518, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0125299c1676423c8a3f952d39a5187c", async() => {
                BeginContext(1204, 2, true);
                WriteLiteral("\n\n");
                EndContext();
#line 30 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Editions\_CreateOrEditModal.cshtml"
                 if (Model.IsEditMode)
                {

#line default
#line hidden
                BeginContext(1263, 50, true);
                WriteLiteral("                    <input type=\"hidden\" name=\"Id\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1313, "\"", 1338, 1);
#line 32 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Editions\_CreateOrEditModal.cshtml"
WriteAttributeValue("", 1321, Model.Edition.Id, 1321, 17, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1339, 4, true);
                WriteLiteral(" />\n");
                EndContext();
#line 33 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Editions\_CreateOrEditModal.cshtml"
                }

#line default
#line hidden
                BeginContext(1361, 88, true);
                WriteLiteral("\n                <div class=\"form-group \">\n                    <label for=\"DisplayName\">");
                EndContext();
                BeginContext(1450, 16, false);
#line 36 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Editions\_CreateOrEditModal.cshtml"
                                        Write(L("EditionName"));

#line default
#line hidden
                EndContext();
                BeginContext(1466, 35, true);
                WriteLiteral("</label>\n                    <input");
                EndContext();
                BeginWriteAttribute("class", " class=\"", 1501, "\"", 1582, 2);
                WriteAttributeValue("", 1509, "form-control", 1509, 12, true);
#line 37 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Editions\_CreateOrEditModal.cshtml"
WriteAttributeValue("", 1521, Model.Edition.DisplayName.IsNullOrEmpty() ? "" : " edited", 1521, 61, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1583, 129, true);
                WriteLiteral("\n                           type=\"text\"\n                           name=\"DisplayName\"\n                           id=\"DisplayName\"");
                EndContext();
                BeginWriteAttribute("value", "\n                           value=\"", 1712, "\"", 1773, 1);
#line 41 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Editions\_CreateOrEditModal.cshtml"
WriteAttributeValue("", 1747, Model.Edition.DisplayName, 1747, 26, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1774, 36, true);
                WriteLiteral("\n                           required");
                EndContext();
                BeginWriteAttribute("maxlength", "\n                           maxlength=\"", 1810, "\"", 1878, 1);
#line 43 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Editions\_CreateOrEditModal.cshtml"
WriteAttributeValue("", 1849, Edition.MaxDisplayNameLength, 1849, 29, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1879, 49, true);
                WriteLiteral(">\n                </div>\n\n                <label>");
                EndContext();
                BeginContext(1929, 22, false);
#line 46 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Editions\_CreateOrEditModal.cshtml"
                  Write(L("SubscriptionPrice"));

#line default
#line hidden
                EndContext();
                BeginContext(1951, 203, true);
                WriteLiteral("</label>\n                <div class=\"m-radio-inline\">\n                    <label for=\"EditEdition_IsFree\" class=\"m-radio\">\n                        <input id=\"EditEdition_IsFree\" name=\"SubscriptionPrice\" ");
                EndContext();
                BeginContext(2156, 104, false);
#line 49 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Editions\_CreateOrEditModal.cshtml"
                                                                            Write(!Model.Edition.MonthlyPrice.HasValue && !Model.Edition.AnnualPrice.HasValue ? "checked=\"checked\"" : "");

#line default
#line hidden
                EndContext();
                BeginContext(2261, 39, true);
                WriteLiteral(" type=\"radio\">\n                        ");
                EndContext();
                BeginContext(2301, 9, false);
#line 50 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Editions\_CreateOrEditModal.cshtml"
                   Write(L("Free"));

#line default
#line hidden
                EndContext();
                BeginContext(2310, 217, true);
                WriteLiteral("\n                        <span></span>\n                    </label>\n                    <label for=\"EditEdition_IsPaid\" class=\"m-radio\">\n                        <input id=\"EditEdition_IsPaid\" name=\"SubscriptionPrice\" ");
                EndContext();
                BeginContext(2529, 102, false);
#line 54 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Editions\_CreateOrEditModal.cshtml"
                                                                            Write(Model.Edition.MonthlyPrice.HasValue || Model.Edition.AnnualPrice.HasValue ? "checked=\"checked\"" : "");

#line default
#line hidden
                EndContext();
                BeginContext(2632, 39, true);
                WriteLiteral(" type=\"radio\">\n                        ");
                EndContext();
                BeginContext(2672, 9, false);
#line 55 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Editions\_CreateOrEditModal.cshtml"
                   Write(L("Paid"));

#line default
#line hidden
                EndContext();
                BeginContext(2681, 350, true);
                WriteLiteral(@"
                        <span></span>
                    </label>
                </div>

                <div class=""paid-features"">
                    <div class=""row SubscriptionPrice"">
                        <div class=""col-md-6"">
                            <div class=""form-group"">
                                <label for=""MonthlyPrice"">");
                EndContext();
                BeginContext(3032, 17, false);
#line 64 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Editions\_CreateOrEditModal.cshtml"
                                                     Write(L("MonthlyPrice"));

#line default
#line hidden
                EndContext();
                BeginContext(3049, 175, true);
                WriteLiteral("</label>\n                                <input name=\"MonthlyPrice\"\n                                       id=\"MonthlyPrice\"\n                                       type=\"text\"");
                EndContext();
                BeginWriteAttribute("class", "\n                                       class=\"", 3224, "\"", 3339, 2);
                WriteAttributeValue("", 3271, "form-control", 3271, 12, true);
#line 68 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Editions\_CreateOrEditModal.cshtml"
WriteAttributeValue("", 3283, !Model.Edition.MonthlyPrice.HasValue ? "" : " edited", 3283, 56, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("value", "\n                                       value=\"", 3340, "\"", 3485, 1);
#line 69 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Editions\_CreateOrEditModal.cshtml"
WriteAttributeValue("", 3387, Model.Edition.MonthlyPrice?.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture), 3387, 98, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3486, 227, true);
                WriteLiteral(" />\n                            </div>\n                        </div>\n                        <div class=\"col-md-6\">\n                            <div class=\"form-group\">\n                                <label for=\"AnnualPrice\">");
                EndContext();
                BeginContext(3714, 16, false);
#line 74 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Editions\_CreateOrEditModal.cshtml"
                                                    Write(L("AnnualPrice"));

#line default
#line hidden
                EndContext();
                BeginContext(3730, 173, true);
                WriteLiteral("</label>\n                                <input name=\"AnnualPrice\"\n                                       id=\"AnnualPrice\"\n                                       type=\"text\"");
                EndContext();
                BeginWriteAttribute("class", "\n                                       class=\"", 3903, "\"", 4017, 2);
                WriteAttributeValue("", 3950, "form-control", 3950, 12, true);
#line 78 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Editions\_CreateOrEditModal.cshtml"
WriteAttributeValue("", 3962, !Model.Edition.AnnualPrice.HasValue ? "" : " edited", 3962, 55, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("value", "\n                                       value=\"", 4018, "\"", 4160, 1);
#line 79 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Editions\_CreateOrEditModal.cshtml"
WriteAttributeValue("", 4065, Model.Edition.AnnualPrice?.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture), 4065, 95, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4161, 364, true);
                WriteLiteral(@" />
                            </div>
                        </div>
                    </div>

                    <div class=""m-checkbox-list"">
                        <label for=""EditEdition_IsTrialActive"" class=""m-checkbox"">
                            <input id=""EditEdition_IsTrialActive"" class=""md-check"" type=""checkbox"" name=""IsTrialActive"" value=""true"" ");
                EndContext();
                BeginContext(4527, 65, false);
#line 86 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Editions\_CreateOrEditModal.cshtml"
                                                                                                                                 Write(Model.Edition.TrialDayCount.HasValue ? "checked=\"checked\"" : "");

#line default
#line hidden
                EndContext();
                BeginContext(4593, 32, true);
                WriteLiteral(" />\n                            ");
                EndContext();
                BeginContext(4626, 18, false);
#line 87 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Editions\_CreateOrEditModal.cshtml"
                       Write(L("IsTrialActive"));

#line default
#line hidden
                EndContext();
                BeginContext(4644, 216, true);
                WriteLiteral("\n                            <span></span>\n                        </label>\n                    </div>\n\n                    <div class=\"form-group trial-day-count\">\n                        <label for=\"TrialDayCount\">");
                EndContext();
                BeginContext(4861, 18, false);
#line 93 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Editions\_CreateOrEditModal.cshtml"
                                              Write(L("TrialDayCount"));

#line default
#line hidden
                EndContext();
                BeginContext(4879, 39, true);
                WriteLiteral("</label>\n                        <input");
                EndContext();
                BeginWriteAttribute("class", " class=\"", 4918, "\"", 4995, 2);
                WriteAttributeValue("", 4926, "form-control", 4926, 12, true);
#line 94 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Editions\_CreateOrEditModal.cshtml"
WriteAttributeValue("", 4938, !Model.Edition.TrialDayCount.HasValue ? "" : " edited", 4938, 57, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4996, 148, true);
                WriteLiteral("\n                               type=\"number\" \n                               name=\"TrialDayCount\"\n                               id=\"TrialDayCount\"");
                EndContext();
                BeginWriteAttribute("value", "\n                               value=\"", 5144, "\"", 5211, 1);
#line 98 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Editions\_CreateOrEditModal.cshtml"
WriteAttributeValue("", 5183, Model.Edition.TrialDayCount, 5183, 28, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(5212, 294, true);
                WriteLiteral(@">
                    </div>

                    <div class=""m-checkbox-list"">
                        <label for=""EditEdition_IsWaitingDayActive"" class=""m-checkbox"">
                            <input id=""EditEdition_IsWaitingDayActive"" type=""checkbox"" name=""IsWaitingDayActive"" value=""true"" ");
                EndContext();
                BeginContext(5508, 73, false);
#line 103 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Editions\_CreateOrEditModal.cshtml"
                                                                                                                          Write(Model.Edition.WaitingDayAfterExpire.HasValue ? "checked=\"checked\"" : "");

#line default
#line hidden
                EndContext();
                BeginContext(5582, 32, true);
                WriteLiteral(" />\n                            ");
                EndContext();
                BeginContext(5615, 36, false);
#line 104 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Editions\_CreateOrEditModal.cshtml"
                       Write(L("WaitAfterSubscriptionExpireDate"));

#line default
#line hidden
                EndContext();
                BeginContext(5651, 233, true);
                WriteLiteral("\n                            <span></span>\n                        </label>\n                    </div>\n\n                    <div class=\"form-group waiting-day-after-expire\">\n                        <label for=\"WaitingDayAfterExpire\">");
                EndContext();
                BeginContext(5885, 26, false);
#line 110 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Editions\_CreateOrEditModal.cshtml"
                                                      Write(L("WaitingDayAfterExpire"));

#line default
#line hidden
                EndContext();
                BeginContext(5911, 39, true);
                WriteLiteral("</label>\n                        <input");
                EndContext();
                BeginWriteAttribute("class", " class=\"", 5950, "\"", 6035, 2);
                WriteAttributeValue("", 5958, "form-control", 5958, 12, true);
#line 111 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Editions\_CreateOrEditModal.cshtml"
WriteAttributeValue("", 5970, !Model.Edition.WaitingDayAfterExpire.HasValue ? "" : " edited", 5970, 65, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(6036, 164, true);
                WriteLiteral("\n                               type=\"number\" \n                               name=\"WaitingDayAfterExpire\"\n                               id=\"WaitingDayAfterExpire\"");
                EndContext();
                BeginWriteAttribute("value", "\n                               value=\"", 6200, "\"", 6275, 1);
#line 115 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Editions\_CreateOrEditModal.cshtml"
WriteAttributeValue("", 6239, Model.Edition.WaitingDayAfterExpire, 6239, 36, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(6276, 57, true);
                WriteLiteral(">\n                    </div>\n\n                    <label>");
                EndContext();
                BeginContext(6334, 40, false);
#line 118 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Editions\_CreateOrEditModal.cshtml"
                      Write(L("WhatWillDoneAfterSubscriptionExpiry"));

#line default
#line hidden
                EndContext();
                BeginContext(6374, 248, true);
                WriteLiteral("</label>\n                    <div class=\"m-radio-inline\">\n                        <label for=\"EditEdition_ExpireAction_DeactiveUser\" class=\"m-radio\">\n                            <input id=\"EditEdition_ExpireAction_DeactiveUser\" name=\"ExpireAction\" ");
                EndContext();
                BeginContext(6624, 70, false);
#line 121 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Editions\_CreateOrEditModal.cshtml"
                                                                                              Write(!Model.Edition.ExpiringEditionId.HasValue ? "checked=\"checked\"" : "");

#line default
#line hidden
                EndContext();
                BeginContext(6695, 43, true);
                WriteLiteral(" type=\"radio\">\n                            ");
                EndContext();
                BeginContext(6739, 19, false);
#line 122 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Editions\_CreateOrEditModal.cshtml"
                       Write(L("DeactiveTenant"));

#line default
#line hidden
                EndContext();
                BeginContext(6758, 288, true);
                WriteLiteral(@"
                            <span></span>
                        </label>
                        <label for=""EditEdition_ExpireAction_AssignEdition"" class=""m-radio"">
                            <input id=""EditEdition_ExpireAction_AssignEdition"" name=""ExpireAction"" class=""md-radiobtn"" ");
                EndContext();
                BeginContext(7048, 69, false);
#line 126 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Editions\_CreateOrEditModal.cshtml"
                                                                                                                   Write(Model.Edition.ExpiringEditionId.HasValue ? "checked=\"checked\"" : "");

#line default
#line hidden
                EndContext();
                BeginContext(7118, 43, true);
                WriteLiteral(" type=\"radio\">\n                            ");
                EndContext();
                BeginContext(7162, 27, false);
#line 127 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Editions\_CreateOrEditModal.cshtml"
                       Write(L("AssignToAnotherEdition"));

#line default
#line hidden
                EndContext();
                BeginContext(7189, 186, true);
                WriteLiteral("\n                            <span></span>\n                        </label>\n                    </div>\n\n                    <div class=\"form-group edition-list\">\n                        ");
                EndContext();
                BeginContext(7376, 192, false);
#line 133 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Editions\_CreateOrEditModal.cshtml"
                   Write(Html.DropDownList("ExpiringEditionId", Model.FreeEditionItems.Select(i => i.ToSelectListItem()), new { @class = "form-control" + (Model.Edition.DisplayName.IsNullOrEmpty() ? "" : " edited") }));

#line default
#line hidden
                EndContext();
                BeginContext(7568, 63, true);
                WriteLiteral("\n                    </div>\n                </div>\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("novalidate", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7638, 93, true);
            WriteLiteral("\n\n        </div>\n        <div class=\"tab-pane\" id=\"FeaturesTab\" role=\"tabpanel\">\n            ");
            EndContext();
            BeginContext(7732, 76, false);
#line 140 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Editions\_CreateOrEditModal.cshtml"
       Write(Html.Partial("~/Areas/AppAreaName/Views/Common/_FeaturesTree.cshtml", Model));

#line default
#line hidden
            EndContext();
            BeginContext(7808, 35, true);
            WriteLiteral("\n        </div>\n    </div>\n</div>\n\n");
            EndContext();
            BeginContext(7844, 92, false);
#line 145 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Editions\_CreateOrEditModal.cshtml"
Write(Html.Partial("~/Areas/AppAreaName/Views/Common/Modals/_ModalFooterWithSaveAndCancel.cshtml"));

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CreateOrEditEditionModalViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
