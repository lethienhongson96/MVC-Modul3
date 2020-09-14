#pragma checksum "D:\MVC-Modul3\StoreManagement\StoreManagement\Views\Category\MoveDefaultToAnother.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a19f14703944702649f5ca06e332d7b01c1281e4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_MoveDefaultToAnother), @"mvc.1.0.view", @"/Views/Category/MoveDefaultToAnother.cshtml")]
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
#line 1 "D:\MVC-Modul3\StoreManagement\StoreManagement\Views\_ViewImports.cshtml"
using StoreManagement;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\MVC-Modul3\StoreManagement\StoreManagement\Views\_ViewImports.cshtml"
using StoreManagement.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\MVC-Modul3\StoreManagement\StoreManagement\Views\_ViewImports.cshtml"
using StoreManagement.Models.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\MVC-Modul3\StoreManagement\StoreManagement\Views\_ViewImports.cshtml"
using StoreManagement.Enum;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\MVC-Modul3\StoreManagement\StoreManagement\Views\_ViewImports.cshtml"
using StoreManagement.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\MVC-Modul3\StoreManagement\StoreManagement\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a19f14703944702649f5ca06e332d7b01c1281e4", @"/Views/Category/MoveDefaultToAnother.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb0b44958437566fca3177b722b5e62da6d1d631", @"/Views/_ViewImports.cshtml")]
    public class Views_Category_MoveDefaultToAnother : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<MoveDefaultView>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\MVC-Modul3\StoreManagement\StoreManagement\Views\Category\MoveDefaultToAnother.cshtml"
  
    var CategoryList = context.Categories.ToList();
    const int DefaultCategoryId = 4; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 9 "D:\MVC-Modul3\StoreManagement\StoreManagement\Views\Category\MoveDefaultToAnother.cshtml"
 using (Html.BeginForm("MoveDefaultToAnother", "Category", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table class=\"table\">\r\n");
#nullable restore
#line 12 "D:\MVC-Modul3\StoreManagement\StoreManagement\Views\Category\MoveDefaultToAnother.cshtml"
         for (int i = 0; i < Model.Count; i++)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\MVC-Modul3\StoreManagement\StoreManagement\Views\Category\MoveDefaultToAnother.cshtml"
       Write(Html.Hidden("MoveDefaultViews.Index", (@i + 10)));

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\MVC-Modul3\StoreManagement\StoreManagement\Views\Category\MoveDefaultToAnother.cshtml"
       Write(Html.Hidden("MoveDefaultViews[" + (@i + 10) + "].Id",
                   Model[i].Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 20 "D:\MVC-Modul3\StoreManagement\StoreManagement\Views\Category\MoveDefaultToAnother.cshtml"
               Write(Html.TextBox("MoveDefaultViews[" + (@i + 10) + "].Name",
                    Model[i].Name, new { @readonly = "readonly", @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 24 "D:\MVC-Modul3\StoreManagement\StoreManagement\Views\Category\MoveDefaultToAnother.cshtml"
               Write(Html.DropDownList("MoveDefaultViews[" + (@i + 10) + "].CategoryId",
                        new SelectList(CategoryList, "Id", "Name", DefaultCategoryId),
                        new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 29 "D:\MVC-Modul3\StoreManagement\StoreManagement\Views\Category\MoveDefaultToAnother.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                <button type=\"submit\" class=\"btn btn-success\">Lưu Tất Cả Thay đổi</button>\r\n            </td>\r\n        </tr>\r\n    </table>\r\n");
#nullable restore
#line 36 "D:\MVC-Modul3\StoreManagement\StoreManagement\Views\Category\MoveDefaultToAnother.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public StoreDbContext context { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<MoveDefaultView>> Html { get; private set; }
    }
}
#pragma warning restore 1591
