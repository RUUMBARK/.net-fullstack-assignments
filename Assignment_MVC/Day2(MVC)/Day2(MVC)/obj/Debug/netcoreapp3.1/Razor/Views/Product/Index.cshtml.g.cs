#pragma checksum "C:\Users\RUUMBARK\source\repos\Day2(MVC)\Day2(MVC)\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b9ef978e771ddaf54836e74fa3ba885d18d1b9f3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
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
#line 1 "C:\Users\RUUMBARK\source\repos\Day2(MVC)\Day2(MVC)\Views\_ViewImports.cshtml"
using Day2_MVC_;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\RUUMBARK\source\repos\Day2(MVC)\Day2(MVC)\Views\_ViewImports.cshtml"
using Day2_MVC_.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9ef978e771ddaf54836e74fa3ba885d18d1b9f3", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c50fdfba283d8a141def9b0c722823684c9fc12", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Day2_MVC_.Models.Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h2>Product list as on: ");
#nullable restore
#line 2 "C:\Users\RUUMBARK\source\repos\Day2(MVC)\Day2(MVC)\Views\Product\Index.cshtml"
                   Write(DateTime.Now.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>");
#nullable restore
#line 2 "C:\Users\RUUMBARK\source\repos\Day2(MVC)\Day2(MVC)\Views\Product\Index.cshtml"
                                                       foreach (var p in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>Product Id: ");
#nullable restore
#line 3 "C:\Users\RUUMBARK\source\repos\Day2(MVC)\Day2(MVC)\Views\Product\Index.cshtml"
                Write(p.ProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n    <h3>Product Name: ");
#nullable restore
#line 4 "C:\Users\RUUMBARK\source\repos\Day2(MVC)\Day2(MVC)\Views\Product\Index.cshtml"
                 Write(p.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n    <h3>Price: ");
#nullable restore
#line 5 "C:\Users\RUUMBARK\source\repos\Day2(MVC)\Day2(MVC)\Views\Product\Index.cshtml"
          Write(p.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n    <hr />\r\n");
#nullable restore
#line 7 "C:\Users\RUUMBARK\source\repos\Day2(MVC)\Day2(MVC)\Views\Product\Index.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Day2_MVC_.Models.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
