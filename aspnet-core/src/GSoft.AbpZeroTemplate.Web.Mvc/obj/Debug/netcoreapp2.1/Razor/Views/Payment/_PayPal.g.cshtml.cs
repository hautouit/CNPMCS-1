#pragma checksum "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Payment\_PayPal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "098a23b21ec2d240f777276bae59febac81bad53"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Payment__PayPal), @"mvc.1.0.view", @"/Views/Payment/_PayPal.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Payment/_PayPal.cshtml", typeof(AspNetCore.Views_Payment__PayPal))]
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
#line 1 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\_ViewImports.cshtml"
using Abp.Localization;

#line default
#line hidden
#line 1 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Payment\_PayPal.cshtml"
using IdentityServer4.Extensions;

#line default
#line hidden
#line 2 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Payment\_PayPal.cshtml"
using GSoft.AbpZeroTemplate.MultiTenancy.Payments;

#line default
#line hidden
#line 3 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Payment\_PayPal.cshtml"
using GSoft.AbpZeroTemplate.Web.Resources;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"098a23b21ec2d240f777276bae59febac81bad53", @"/Views/Payment/_PayPal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4eef59065c4b39f709eb64b90c2355595a8a2772", @"/Views/_ViewImports.cshtml")]
    public class Views_Payment__PayPal : GSoft.AbpZeroTemplate.Web.Views.AbpZeroTemplateRazorPage<GSoft.AbpZeroTemplate.Web.Models.Payment.PaymentViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 6 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Payment\_PayPal.cshtml"
  
    WebResourceManager.AddScript("https://www.paypalobjects.com/api/checkout.js");
    WebResourceManager.AddScript(ApplicationPath + "view-resources/Views/Payment/_PayPal.js");

#line default
#line hidden
            BeginContext(423, 45, true);
            WriteLiteral("\n<input type=\"hidden\" id=\"paypal-environment\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 468, "\"", 554, 1);
#line 11 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Payment\_PayPal.cshtml"
WriteAttributeValue("", 476, Model.GetAdditionalData(SubscriptionPaymentGatewayType.Paypal, "Environment"), 476, 78, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(555, 102, true);
            WriteLiteral(" />\n<input type=\"hidden\" name=\"PaymentId\" value=\"\" />\n<input type=\"hidden\" name=\"PayerId\" value=\"\" />\n");
            EndContext();
#line 14 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Payment\_PayPal.cshtml"
 if (!Model.GetAdditionalData(SubscriptionPaymentGatewayType.Paypal, "DemoUsername").IsNullOrEmpty())
{

#line default
#line hidden
            BeginContext(761, 215, true);
            WriteLiteral("    <div class=\"m-alert m-alert--icon m-alert--icon-solid m-alert--outline alert alert-brand alert-dismissible fade show\" role=\"alert\">\n        <div class=\"m-alert__icon\">\n            <i class=\"flaticon-exclamation\"");
            EndContext();
            BeginWriteAttribute("aria-label", " aria-label=\"", 976, "\"", 1002, 1);
#line 18 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Payment\_PayPal.cshtml"
WriteAttributeValue("", 989, L("Payment"), 989, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1003, 116, true);
            WriteLiteral("></i>\n            <span></span>\n        </div>\n        <div class=\"m-alert__text\">\n            <h4>\n                ");
            EndContext();
            BeginContext(1120, 22, false);
#line 23 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Payment\_PayPal.cshtml"
           Write(L("DemoPayPalAccount"));

#line default
#line hidden
            EndContext();
            BeginContext(1142, 57, true);
            WriteLiteral("\n            </h4>\n            <p>\n                <span>");
            EndContext();
            BeginContext(1200, 13, false);
#line 26 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Payment\_PayPal.cshtml"
                 Write(L("UserName"));

#line default
#line hidden
            EndContext();
            BeginContext(1213, 10, true);
            WriteLiteral(": <strong>");
            EndContext();
            BeginContext(1224, 78, false);
#line 26 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Payment\_PayPal.cshtml"
                                         Write(Model.GetAdditionalData(SubscriptionPaymentGatewayType.Paypal, "DemoUsername"));

#line default
#line hidden
            EndContext();
            BeginContext(1302, 45, true);
            WriteLiteral("</strong></span><br />\n                <span>");
            EndContext();
            BeginContext(1348, 13, false);
#line 27 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Payment\_PayPal.cshtml"
                 Write(L("Password"));

#line default
#line hidden
            EndContext();
            BeginContext(1361, 10, true);
            WriteLiteral(": <strong>");
            EndContext();
            BeginContext(1372, 78, false);
#line 27 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Payment\_PayPal.cshtml"
                                         Write(Model.GetAdditionalData(SubscriptionPaymentGatewayType.Paypal, "DemoPassword"));

#line default
#line hidden
            EndContext();
            BeginContext(1450, 60, true);
            WriteLiteral("</strong></span>\n            </p>\n        </div>\n    </div>\n");
            EndContext();
#line 31 "D:\Study\CNPM chuyên sâu\CNPMCS\aspnet-core\src\GSoft.AbpZeroTemplate.Web.Mvc\Views\Payment\_PayPal.cshtml"
}

#line default
#line hidden
            BeginContext(1512, 30, true);
            WriteLiteral("<div id=\"paypal-button\"></div>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IWebResourceManager WebResourceManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GSoft.AbpZeroTemplate.Web.Models.Payment.PaymentViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
