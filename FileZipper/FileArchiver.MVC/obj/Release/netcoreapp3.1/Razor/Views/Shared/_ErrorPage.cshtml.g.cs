#pragma checksum "C:\Projects\FileArchiver\FileArchiver\FileArchiver.MVC\Views\Shared\_ErrorPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0a2aac3ca7ad61ef62528d2894a4b4a876221775"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ErrorPage), @"mvc.1.0.view", @"/Views/Shared/_ErrorPage.cshtml")]
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
#line 1 "C:\Projects\FileArchiver\FileArchiver\FileArchiver.MVC\Views\_ViewImports.cshtml"
using FileArchiver.MVC;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a2aac3ca7ad61ef62528d2894a4b4a876221775", @"/Views/Shared/_ErrorPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff2ad1fd4c3897b540e3e4762a62e8d8ceb4664e", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__ErrorPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h2>An error occured! There was an error with your request</h2>\r\n<h4>Please contact us on contact-us@gmail.com</h4>\r\n<hr />\r\n<h3>Exception detauls</h3>\r\n<div class=\"alert alert-danger\">\r\n    <h5>Exception path:</h5>\r\n    <hr />\r\n    <p>");
#nullable restore
#line 8 "C:\Projects\FileArchiver\FileArchiver\FileArchiver.MVC\Views\Shared\_ErrorPage.cshtml"
  Write(ViewBag.ExceptionPath);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n</div>\r\n\r\n<div class=\"alert alert-danger\">\r\n    <h5>Exception message:</h5>\r\n    <hr />\r\n    <p>");
#nullable restore
#line 14 "C:\Projects\FileArchiver\FileArchiver\FileArchiver.MVC\Views\Shared\_ErrorPage.cshtml"
  Write(ViewBag.ExceptionMessage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n</div>\r\n\r\n\r\n<div class=\"alert alert-danger\">\r\n    <h5>Exception stack trace:</h5>\r\n    <hr />\r\n    <p>");
#nullable restore
#line 21 "C:\Projects\FileArchiver\FileArchiver\FileArchiver.MVC\Views\Shared\_ErrorPage.cshtml"
  Write(ViewBag.StackTrace);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n</div>");
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
