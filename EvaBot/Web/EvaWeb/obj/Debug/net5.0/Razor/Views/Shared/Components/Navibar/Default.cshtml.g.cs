#pragma checksum "D:\Projects\c#\EvaBot\GitHub\EvaBot\Web\EvaWeb\Views\Shared\Components\Navibar\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f835247a5a9f37d1a2d2a70f8ae80144a11b1b7d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Navibar_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Navibar/Default.cshtml")]
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
#line 1 "D:\Projects\c#\EvaBot\GitHub\EvaBot\Web\EvaWeb\Views\_ViewImports.cshtml"
using EvaWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\c#\EvaBot\GitHub\EvaBot\Web\EvaWeb\Views\_ViewImports.cshtml"
using EvaWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f835247a5a9f37d1a2d2a70f8ae80144a11b1b7d", @"/Views/Shared/Components/Navibar/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd9b355673bf6f8fc3d025bc2c05402afbd821dc", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_Navibar_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<EvaWeb.Models.NavibarLink>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Projects\c#\EvaBot\GitHub\EvaBot\Web\EvaWeb\Views\Shared\Components\Navibar\Default.cshtml"
  
    int gId = -1;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 6 "D:\Projects\c#\EvaBot\GitHub\EvaBot\Web\EvaWeb\Views\Shared\Components\Navibar\Default.cshtml"
 foreach (var link in Model)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Projects\c#\EvaBot\GitHub\EvaBot\Web\EvaWeb\Views\Shared\Components\Navibar\Default.cshtml"
Write(Html.Raw(link.GetOpLi()));

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Projects\c#\EvaBot\GitHub\EvaBot\Web\EvaWeb\Views\Shared\Components\Navibar\Default.cshtml"
     if (link.content)

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Projects\c#\EvaBot\GitHub\EvaBot\Web\EvaWeb\Views\Shared\Components\Navibar\Default.cshtml"
                 Write(Html.Raw("<div class= " + '\u0022' + "content nav-link text-white " + '\u0022' +">"));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <a");
            BeginWriteAttribute("href", " href=\"", 247, "\"", 264, 1);
#nullable restore
#line 10 "D:\Projects\c#\EvaBot\GitHub\EvaBot\Web\EvaWeb\Views\Shared\Components\Navibar\Default.cshtml"
WriteAttributeValue("", 254, link.link, 254, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 265, "\"", 302, 2);
            WriteAttributeValue("", 273, "nav-link", 273, 8, true);
#nullable restore
#line 10 "D:\Projects\c#\EvaBot\GitHub\EvaBot\Web\EvaWeb\Views\Shared\Components\Navibar\Default.cshtml"
WriteAttributeValue(" ", 281, link.classParametrs, 282, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" >\r\n        <svg class=\"bi me-2\" width=\"16\" height=\"16\"><use");
            BeginWriteAttribute("xlink:href", " xlink:href=\"", 363, "\"", 387, 1);
#nullable restore
#line 11 "D:\Projects\c#\EvaBot\GitHub\EvaBot\Web\EvaWeb\Views\Shared\Components\Navibar\Default.cshtml"
WriteAttributeValue("", 376, link.image, 376, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></use></svg>\r\n        ");
#nullable restore
#line 12 "D:\Projects\c#\EvaBot\GitHub\EvaBot\Web\EvaWeb\Views\Shared\Components\Navibar\Default.cshtml"
   Write(link.text);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </a>\r\n");
#nullable restore
#line 14 "D:\Projects\c#\EvaBot\GitHub\EvaBot\Web\EvaWeb\Views\Shared\Components\Navibar\Default.cshtml"
Write(Html.Raw(link.GetEndLi()));

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\Projects\c#\EvaBot\GitHub\EvaBot\Web\EvaWeb\Views\Shared\Components\Navibar\Default.cshtml"
                               

}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<EvaWeb.Models.NavibarLink>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
