#pragma checksum "C:\Users\RUUMBARK\source\repos\Day4(MVC)\Day4(MVC)\Views\Home\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f2fea4601a47c8fcceb0b0b95a638ac6e6c0d0ca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Edit), @"mvc.1.0.view", @"/Views/Home/Edit.cshtml")]
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
#line 1 "C:\Users\RUUMBARK\source\repos\Day4(MVC)\Day4(MVC)\Views\_ViewImports.cshtml"
using Day4_MVC_;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\RUUMBARK\source\repos\Day4(MVC)\Day4(MVC)\Views\_ViewImports.cshtml"
using Day4_MVC_.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2fea4601a47c8fcceb0b0b95a638ac6e6c0d0ca", @"/Views/Home/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef485994c8dfe9c57f7d0839adb51912bc902ac8", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Account>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\RUUMBARK\source\repos\Day4(MVC)\Day4(MVC)\Views\Home\Edit.cshtml"
  
    ViewData["Title"] = "Edit";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Editing Details for Account No. ");
#nullable restore
#line 6 "C:\Users\RUUMBARK\source\repos\Day4(MVC)\Day4(MVC)\Views\Home\Edit.cshtml"
                               Write(Model.AccountNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n");
#nullable restore
#line 8 "C:\Users\RUUMBARK\source\repos\Day4(MVC)\Day4(MVC)\Views\Home\Edit.cshtml"
 using (Html.BeginForm("EditAccount", "Home"))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\RUUMBARK\source\repos\Day4(MVC)\Day4(MVC)\Views\Home\Edit.cshtml"
Write(Html.HiddenFor(a => a.AccountNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>\r\n        Name: ");
#nullable restore
#line 13 "C:\Users\RUUMBARK\source\repos\Day4(MVC)\Day4(MVC)\Views\Home\Edit.cshtml"
         Write(Html.TextBoxFor(a => a.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </p>\r\n");
            WriteLiteral("    <p>\r\n        Current Balance: ");
#nullable restore
#line 17 "C:\Users\RUUMBARK\source\repos\Day4(MVC)\Day4(MVC)\Views\Home\Edit.cshtml"
                    Write(Html.TextBoxFor(a => a.CurrentBalance));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </p>\r\n");
            WriteLiteral("    <input type=\"submit\" value=\"Save Modifications\" />\r\n");
#nullable restore
#line 21 "C:\Users\RUUMBARK\source\repos\Day4(MVC)\Day4(MVC)\Views\Home\Edit.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Account> Html { get; private set; }
    }
}
#pragma warning restore 1591
