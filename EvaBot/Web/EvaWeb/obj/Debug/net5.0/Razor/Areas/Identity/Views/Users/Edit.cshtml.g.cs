#pragma checksum "D:\Projects\c#\EvaBot\GitHub\EvaBot\Web\EvaWeb\Areas\Identity\Views\Users\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9cfea564e050195e438c5845a3b7014d2fac16c3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Views_Users_Edit), @"mvc.1.0.view", @"/Areas/Identity/Views/Users/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9cfea564e050195e438c5845a3b7014d2fac16c3", @"/Areas/Identity/Views/Users/Edit.cshtml")]
    #nullable restore
    public class Areas_Identity_Views_Users_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EvaWeb.Areas.Identity.ViewModels.EditUserViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Projects\c#\EvaBot\GitHub\EvaBot\Web\EvaWeb\Areas\Identity\Views\Users\Edit.cshtml"
  
    ViewBag.Title = "Редактирование пользователя";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<form asp-action=""Edit"" asp-controller=""Users"" asp-area=""Identity"">
    <div asp-validation-summary=""All"" class=""text-danger""></div>
    <div class=""form-group"">
        <input type=""hidden"" asp-for=""Id"" />
    </div>
    <div class=""form-group"">
        <label asp-for=""Email"" class=""control-label"">Email</label>
        <input type=""text"" asp-for=""Email"" class=""form-control"" />
    </div>
    <div class=""form-group"">
        <label asp-for=""Year"" class=""control-label"">Год рождения</label>
        <input type=""number"" asp-for=""Year"" class=""form-control"" />
    </div>
    <div class=""form-group"">
        <input type=""submit"" value=""Сохранить"" class=""btn btn-outline-secondary"" />
    </div>
    
</form>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EvaWeb.Areas.Identity.ViewModels.EditUserViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
