#pragma checksum "E:\projects\EvaBot\EvaBot\Web\EvaWeb\Areas\Identity\Views\Users\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a10503e038a355ec6f14844ac3d27b09a4adb68f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Views_Users_Index), @"mvc.1.0.view", @"/Areas/Identity/Views/Users/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a10503e038a355ec6f14844ac3d27b09a4adb68f", @"/Areas/Identity/Views/Users/Index.cshtml")]
    public class Areas_Identity_Views_Users_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EvaWeb.Areas.Identity.Models.User>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "E:\projects\EvaBot\EvaBot\Web\EvaWeb\Areas\Identity\Views\Users\Index.cshtml"
  
    ViewBag.Title = "Список пользователей";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<a asp-action=\"Create\">Добавить пользователя</a>\r\n\r\n<table class=\"table\">\r\n    <tr><th>Email</th><th>Год</th><th></th></tr>\r\n");
#nullable restore
#line 12 "E:\projects\EvaBot\EvaBot\Web\EvaWeb\Areas\Identity\Views\Users\Index.cshtml"
     foreach (var user in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 15 "E:\projects\EvaBot\EvaBot\Web\EvaWeb\Areas\Identity\Views\Users\Index.cshtml"
           Write(user.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 16 "E:\projects\EvaBot\EvaBot\Web\EvaWeb\Areas\Identity\Views\Users\Index.cshtml"
           Write(user.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n                <form asp-action=\"Delete\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 446, "\"", 469, 1);
#nullable restore
#line 18 "E:\projects\EvaBot\EvaBot\Web\EvaWeb\Areas\Identity\Views\Users\Index.cshtml"
WriteAttributeValue("", 461, user.Id, 461, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" method=\"post\">\r\n                    <a class=\"btn btn-sm btn-primary\" asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 558, "\"", 581, 1);
#nullable restore
#line 19 "E:\projects\EvaBot\EvaBot\Web\EvaWeb\Areas\Identity\Views\Users\Index.cshtml"
WriteAttributeValue("", 573, user.Id, 573, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Изменить</a>\r\n                    <button type=\"submit\" class=\"btn btn-sm btn-danger\">\r\n                        Удалить\r\n                    </button>\r\n                </form>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 26 "E:\projects\EvaBot\EvaBot\Web\EvaWeb\Areas\Identity\Views\Users\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EvaWeb.Areas.Identity.Models.User>> Html { get; private set; }
    }
}
#pragma warning restore 1591
