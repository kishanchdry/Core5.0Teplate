#pragma checksum "F:\POC's\Admin\Web\Views\Account\ResetPassword.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e5b050d78a4a1c46b1db8547bbaeba768f9d584f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_ResetPassword), @"mvc.1.0.view", @"/Views/Account/ResetPassword.cshtml")]
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
#line 1 "F:\POC's\Admin\Web\Views\_ViewImports.cshtml"
using Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\POC's\Admin\Web\Views\_ViewImports.cshtml"
using Data.Entities.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\POC's\Admin\Web\Views\_ViewImports.cshtml"
using Services.IServices.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\POC's\Admin\Web\Views\_ViewImports.cshtml"
using Services.IServices;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\POC's\Admin\Web\Views\_ViewImports.cshtml"
using Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\POC's\Admin\Web\Views\_ViewImports.cshtml"
using Web.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "F:\POC's\Admin\Web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Hosting;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5b050d78a4a1c46b1db8547bbaeba768f9d584f", @"/Views/Account/ResetPassword.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c61419c8fb5cd88a30266fc800672850c9a95789", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_ResetPassword : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Shared.Models.API.ResetPasswordModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "F:\POC's\Admin\Web\Views\Account\ResetPassword.cshtml"
  
    ViewData["Title"] = "Reset Password";
  

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"form-sec\" style=\"padding:20px;\">\r\n    <div class=\"form-heading text-center\">\r\n        <img src=\"../form-logo.png\"");
            BeginWriteAttribute("alt", " alt=\"", 226, "\"", 232, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n        <h1>");
#nullable restore
#line 10 "F:\POC's\Admin\Web\Views\Account\ResetPassword.cshtml"
       Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(".</h1>\r\n        <h2>Create a new account.</h2>\r\n    </div>\r\n");
#nullable restore
#line 13 "F:\POC's\Admin\Web\Views\Account\ResetPassword.cshtml"
     using (Html.BeginForm("ResetPassword", "Account", FormMethod.Post, new { @class = "form-horizontal", area = "", role = "form" }))
    {

        

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "F:\POC's\Admin\Web\Views\Account\ResetPassword.cshtml"
   Write(Html.HiddenFor(m => m.Email));

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "F:\POC's\Admin\Web\Views\Account\ResetPassword.cshtml"
                                     ; 
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "F:\POC's\Admin\Web\Views\Account\ResetPassword.cshtml"
   Write(Html.HiddenFor(m => m.Token));

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "F:\POC's\Admin\Web\Views\Account\ResetPassword.cshtml"
                                     ;
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "F:\POC's\Admin\Web\Views\Account\ResetPassword.cshtml"
   Write(Html.HiddenFor(m => m.Token));

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "F:\POC's\Admin\Web\Views\Account\ResetPassword.cshtml"
                                     ;
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "F:\POC's\Admin\Web\Views\Account\ResetPassword.cshtml"
   Write(Html.ValidationSummary("", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 22 "F:\POC's\Admin\Web\Views\Account\ResetPassword.cshtml"
       Write(Html.LabelFor(m => m.Password, new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 23 "F:\POC's\Admin\Web\Views\Account\ResetPassword.cshtml"
       Write(Html.PasswordFor(m => m.Password, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 26 "F:\POC's\Admin\Web\Views\Account\ResetPassword.cshtml"
       Write(Html.LabelFor(m => m.ConfirmPassword, new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 27 "F:\POC's\Admin\Web\Views\Account\ResetPassword.cshtml"
       Write(Html.PasswordFor(m => m.ConfirmPassword, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <input type=\"submit\" class=\"btn btn-default w-100\" value=\"Register\" />\r\n        </div>\r\n");
#nullable restore
#line 32 "F:\POC's\Admin\Web\Views\Account\ResetPassword.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Shared.Models.API.ResetPasswordModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
