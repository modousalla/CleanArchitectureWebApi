#pragma checksum "C:\Users\mbom0015\source\repos\CleanArchitectureWebApi\CleanArchitectureWebApi\src\Clean.Architecture.Web\Pages\ToDoRazorPage\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a834bf40e86f27340091916b15de6a33e9984c45"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_ToDoRazorPage_Index), @"mvc.1.0.razor-page", @"/Pages/ToDoRazorPage/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a834bf40e86f27340091916b15de6a33e9984c45", @"/Pages/ToDoRazorPage/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23ac09be4bcfaa7f9829a01d1a134874eaae1f3b", @"/Pages/_ViewImports.cshtml")]
    public class Pages_ToDoRazorPage_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h2>To Do Items (Razor Page)</h2>\r\n<ul>\r\n");
#nullable restore
#line 6 "C:\Users\mbom0015\source\repos\CleanArchitectureWebApi\CleanArchitectureWebApi\src\Clean.Architecture.Web\Pages\ToDoRazorPage\Index.cshtml"
     foreach (var item in Model.ToDoItems)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>\r\n            ");
#nullable restore
#line 9 "C:\Users\mbom0015\source\repos\CleanArchitectureWebApi\CleanArchitectureWebApi\src\Clean.Architecture.Web\Pages\ToDoRazorPage\Index.cshtml"
       Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 9 "C:\Users\mbom0015\source\repos\CleanArchitectureWebApi\CleanArchitectureWebApi\src\Clean.Architecture.Web\Pages\ToDoRazorPage\Index.cshtml"
                         if (item.IsDone)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <span>DONE!</span>\r\n");
#nullable restore
#line 12 "C:\Users\mbom0015\source\repos\CleanArchitectureWebApi\CleanArchitectureWebApi\src\Clean.Architecture.Web\Pages\ToDoRazorPage\Index.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <span>NOT DONE</span>\r\n");
#nullable restore
#line 16 "C:\Users\mbom0015\source\repos\CleanArchitectureWebApi\CleanArchitectureWebApi\src\Clean.Architecture.Web\Pages\ToDoRazorPage\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <br />");
#nullable restore
#line 17 "C:\Users\mbom0015\source\repos\CleanArchitectureWebApi\CleanArchitectureWebApi\src\Clean.Architecture.Web\Pages\ToDoRazorPage\Index.cshtml"
             Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </li>\r\n");
#nullable restore
#line 19 "C:\Users\mbom0015\source\repos\CleanArchitectureWebApi\CleanArchitectureWebApi\src\Clean.Architecture.Web\Pages\ToDoRazorPage\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Clean.Architecture.Web.Pages.ToDoRazorPage.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Clean.Architecture.Web.Pages.ToDoRazorPage.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Clean.Architecture.Web.Pages.ToDoRazorPage.IndexModel>)PageContext?.ViewData;
        public Clean.Architecture.Web.Pages.ToDoRazorPage.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
