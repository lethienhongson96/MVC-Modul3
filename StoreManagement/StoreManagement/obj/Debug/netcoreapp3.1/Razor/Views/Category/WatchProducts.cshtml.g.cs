#pragma checksum "D:\MVC-Modul3\StoreManagement\StoreManagement\Views\Category\WatchProducts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7ffedeff64591a961313a2baaedc3714937aca70"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_WatchProducts), @"mvc.1.0.view", @"/Views/Category/WatchProducts.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ffedeff64591a961313a2baaedc3714937aca70", @"/Views/Category/WatchProducts.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f41f201375059d09f257074286663a35831c0600", @"/Views/_ViewImports.cshtml")]
    public class Views_Category_WatchProducts : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StoreManagement.Models.Entities.Category>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\MVC-Modul3\StoreManagement\StoreManagement\Views\Category\WatchProducts.cshtml"
  
    var productList = context.Products.ToList().FindAll(el => el.CategoryId == Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>");
#nullable restore
#line 8 "D:\MVC-Modul3\StoreManagement\StoreManagement\Views\Category\WatchProducts.cshtml"
Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
<table id=""example"" class=""table table-striped table-bordered"" style=""width:100%"">
    <thead>
        <tr>
            <th>#id</th>
            <th>Name</th>
            <th>Price</th>
            <th>Status</th>
        </tr>
    </thead>

    <tbody>

");
#nullable restore
#line 21 "D:\MVC-Modul3\StoreManagement\StoreManagement\Views\Category\WatchProducts.cshtml"
         foreach (var item in productList)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 24 "D:\MVC-Modul3\StoreManagement\StoreManagement\Views\Category\WatchProducts.cshtml"
               Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 25 "D:\MVC-Modul3\StoreManagement\StoreManagement\Views\Category\WatchProducts.cshtml"
               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 26 "D:\MVC-Modul3\StoreManagement\StoreManagement\Views\Category\WatchProducts.cshtml"
               Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 27 "D:\MVC-Modul3\StoreManagement\StoreManagement\Views\Category\WatchProducts.cshtml"
               Write(item.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 29 "D:\MVC-Modul3\StoreManagement\StoreManagement\Views\Category\WatchProducts.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </tbody>\r\n    <tfoot>\r\n    </tfoot>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StoreManagement.Models.Entities.Category> Html { get; private set; }
    }
}
#pragma warning restore 1591
