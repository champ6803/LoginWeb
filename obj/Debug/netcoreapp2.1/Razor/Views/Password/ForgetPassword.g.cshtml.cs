#pragma checksum "D:\jidapa\ITO\LoginWeb\Views\Password\ForgetPassword.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4aa2a87812c14e85af05f7e2c330902b30d17ec2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Password_ForgetPassword), @"mvc.1.0.view", @"/Views/Password/ForgetPassword.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Password/ForgetPassword.cshtml", typeof(AspNetCore.Views_Password_ForgetPassword))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4aa2a87812c14e85af05f7e2c330902b30d17ec2", @"/Views/Password/ForgetPassword.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"77d76d1bc6ced84fdf8c6374444e8182f523a509", @"/Views/_ViewImports.cshtml")]
    public class Views_Password_ForgetPassword : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "D:\jidapa\ITO\LoginWeb\Views\Password\ForgetPassword.cshtml"
  
    ViewData["Title"] = "ForgetPassword";

#line default
#line hidden
            BeginContext(52, 987, true);
            WriteLiteral(@"
<section class=""section-forgetpassword"">
    <div class=""container top"">
        <div class=""row justify-content-center"">
            <div class=""col-sm-6 text-forgetpassword"">
                Forget Password

                <p class=""detail-forgetpassword"">Please input your email for reset your password.</p>
                <hr class=""top-line"" />
            </div>
        </div>
        <div class=""row justify-content-center top"">
            <div class=""col-sm-4"">
                <div class=""input-group"">
                    <div class=""input-group-prepend"">
                        <div class=""input-group-text""><i class=""fas fa-user-tie""></i></div>
                    </div>
                    <input type=""text"" class=""form-control"" ng-model=""loginForm.username"" id="""" placeholder=""Email"">
                </div>
                <button class=""btn btn-default width-button top"">Send</button>
            </div>
        </div>
    </div>
</section>");
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