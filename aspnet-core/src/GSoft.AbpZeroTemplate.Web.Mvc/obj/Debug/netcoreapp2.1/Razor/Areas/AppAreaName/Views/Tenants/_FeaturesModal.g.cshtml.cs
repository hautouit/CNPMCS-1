#pragma checksum "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Tenants\_FeaturesModal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2e7896581ae373a3317ab2663aedf8d8f78de05f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AppAreaName_Views_Tenants__FeaturesModal), @"mvc.1.0.view", @"/Areas/AppAreaName/Views/Tenants/_FeaturesModal.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/AppAreaName/Views/Tenants/_FeaturesModal.cshtml", typeof(AspNetCore.Areas_AppAreaName_Views_Tenants__FeaturesModal))]
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
#line 1 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Tenants\_FeaturesModal.cshtml"
using GSoft.AbpZeroTemplate.Web.Areas.AppAreaName.Models.Common.Modals;

#line default
#line hidden
#line 2 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Tenants\_FeaturesModal.cshtml"
using GSoft.AbpZeroTemplate.Web.Areas.AppAreaName.Models.Tenants;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e7896581ae373a3317ab2663aedf8d8f78de05f", @"/Areas/AppAreaName/Views/Tenants/_FeaturesModal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4eef59065c4b39f709eb64b90c2355595a8a2772", @"/Areas/AppAreaName/Views/_ViewImports.cshtml")]
    public class Areas_AppAreaName_Views_Tenants__FeaturesModal : GSoft.AbpZeroTemplate.Web.Views.AbpZeroTemplateRazorPage<TenantFeaturesEditViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(173, 2, true);
            WriteLiteral("\n\n");
            EndContext();
            BeginContext(176, 144, false);
#line 6 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Tenants\_FeaturesModal.cshtml"
Write(Html.Partial("~/Areas/AppAreaName/Views/Common/Modals/_ModalHeader.cshtml", new ModalHeaderViewModel(L("Features") + " - " + Model.Tenant.Name)));

#line default
#line hidden
            EndContext();
            BeginContext(320, 31, true);
            WriteLiteral("\n\n<div class=\"modal-body\">\n    ");
            EndContext();
            BeginContext(352, 76, false);
#line 9 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Tenants\_FeaturesModal.cshtml"
Write(Html.Partial("~/Areas/AppAreaName/Views/Common/_FeaturesTree.cshtml", Model));

#line default
#line hidden
            EndContext();
            BeginContext(428, 139, true);
            WriteLiteral("\n</div>\n\n<div class=\"modal-footer\">\n    <button type=\"button\" class=\"btn btn-default pull-left reset-features-button\" data-toggle=\"tooltip\"");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 567, "\"", 601, 1);
#line 13 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Tenants\_FeaturesModal.cshtml"
WriteAttributeValue("", 575, L("ResetFeaturesTooltip"), 575, 26, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(602, 29, true);
            WriteLiteral(" data-placement=\"left\"><span>");
            EndContext();
            BeginContext(632, 25, false);
#line 13 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Tenants\_FeaturesModal.cshtml"
                                                                                                                                                                  Write(L("ResetSpecialFeatures"));

#line default
#line hidden
            EndContext();
            BeginContext(657, 97, true);
            WriteLiteral("</span></button>\n    <button type=\"button\" class=\"btn default close-button\" data-dismiss=\"modal\">");
            EndContext();
            BeginContext(755, 11, false);
#line 14 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Tenants\_FeaturesModal.cshtml"
                                                                           Write(L("Cancel"));

#line default
#line hidden
            EndContext();
            BeginContext(766, 105, true);
            WriteLiteral("</button>\n    <button type=\"button\" class=\"btn btn-primary save-button\"><i class=\"fa fa-save\"></i> <span>");
            EndContext();
            BeginContext(872, 9, false);
#line 15 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Areas\AppAreaName\Views\Tenants\_FeaturesModal.cshtml"
                                                                                          Write(L("Save"));

#line default
#line hidden
            EndContext();
            BeginContext(881, 25, true);
            WriteLiteral("</span></button>\n</div>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TenantFeaturesEditViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
