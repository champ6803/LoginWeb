#pragma checksum "D:\jidapa\ITO\LoginWeb\Views\Password\ResetPassword.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ae1a5de8a121819bd994d24ca0427ed6596fa23"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Password_ResetPassword), @"mvc.1.0.view", @"/Views/Password/ResetPassword.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Password/ResetPassword.cshtml", typeof(AspNetCore.Views_Password_ResetPassword))]
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
#line 1 "D:\jidapa\ITO\LoginWeb\Views\_ViewImports.cshtml"
using LoginWeb;

#line default
#line hidden
#line 2 "D:\jidapa\ITO\LoginWeb\Views\_ViewImports.cshtml"
using LoginWeb.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ae1a5de8a121819bd994d24ca0427ed6596fa23", @"/Views/Password/ResetPassword.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"77d76d1bc6ced84fdf8c6374444e8182f523a509", @"/Views/_ViewImports.cshtml")]
    public class Views_Password_ResetPassword : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "D:\jidapa\ITO\LoginWeb\Views\Password\ResetPassword.cshtml"
  
    ViewData["Title"] = "ResetPassword";

#line default
#line hidden
            BeginContext(51, 1541, true);
            WriteLiteral(@"
<section class=""section-resetpassword"">
    <div class=""container top"">
        <div class=""row justify-content-center"">
            <div class=""col-sm-6 text-resetpassword"">
                Reset Password

                <p class=""detail-resetpassword"">Please input your new password to reset your password.</p>
                <hr class=""top-line"" />
            </div>
        </div>
        <div class=""row justify-content-center top"">
            <div class=""col-sm-4"">
                <div class=""input-group"">
                    <div class=""input-group-prepend"">
                        <div class=""input-group-text""><i class=""fa fa-lock"" aria-hidden=""true""></i></div>
                    </div>
                    <input type=""text"" class=""form-control"" ng-model=""loginForm.username"" id="""" placeholder=""New Password"">
                </div>
            </div>
        </div>
        <div class=""row justify-content-center top"">
            <div class=""col-sm-4"">
                <div class");
            WriteLiteral(@"=""input-group"">
                    <div class=""input-group-prepend"">
                        <div class=""input-group-text""><i class=""fa fa-lock"" aria-hidden=""true""></i></div>
                    </div>
                    <input type=""text"" class=""form-control"" ng-model=""loginForm.username"" id="""" placeholder=""Confirm New Password"">
                </div>
                <button class=""btn btn-default width-button top"">Change Password</button>
            </div>
        </div>
    </div>
</section>

");
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
