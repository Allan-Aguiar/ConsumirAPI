#pragma checksum "C:\Users\allan.aguiar\Desktop\API\CRUD\CRUD\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fb7ae86db5dc285dced3c65e4cd7ec7740cf4248"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\allan.aguiar\Desktop\API\CRUD\CRUD\Views\_ViewImports.cshtml"
using CRUD;

#line default
#line hidden
#line 2 "C:\Users\allan.aguiar\Desktop\API\CRUD\CRUD\Views\_ViewImports.cshtml"
using CRUD.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb7ae86db5dc285dced3c65e4cd7ec7740cf4248", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"813d028d5e7480ef09b6d196de8cd6b00c3ad294", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CRUD.Models.Clientes>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(29, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\allan.aguiar\Desktop\API\CRUD\CRUD\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(76, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 8 "C:\Users\allan.aguiar\Desktop\API\CRUD\CRUD\Views\Home\Index.cshtml"
 using (Html.BeginForm("Create", "Home",FormMethod.Post))
{

#line default
#line hidden
            BeginContext(142, 30, true);
            WriteLiteral("    <br/>\r\n    <div>\r\n        ");
            EndContext();
            BeginContext(173, 41, false);
#line 12 "C:\Users\allan.aguiar\Desktop\API\CRUD\CRUD\Views\Home\Index.cshtml"
   Write(Html.TextBoxFor(model => model.idCliente));

#line default
#line hidden
            EndContext();
            BeginContext(214, 84, true);
            WriteLiteral(";\r\n    </div>\r\n    <div>\r\n        <input type=\"submit\" value=\"Create\">\r\n    </div>\r\n");
            EndContext();
#line 17 "C:\Users\allan.aguiar\Desktop\API\CRUD\CRUD\Views\Home\Index.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CRUD.Models.Clientes> Html { get; private set; }
    }
}
#pragma warning restore 1591
