#pragma checksum "C:\Users\d.stojanov\Desktop\FileZipper-main\FileZipper\FileArchiver.MVC\Views\Home\_UpdateClientData.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "71596cad073057e777ea7bd33fe8c05737dc1ce1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home__UpdateClientData), @"mvc.1.0.view", @"/Views/Home/_UpdateClientData.cshtml")]
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
#line 1 "C:\Users\d.stojanov\Desktop\FileZipper-main\FileZipper\FileArchiver.MVC\Views\_ViewImports.cshtml"
using FileArchiver.MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\d.stojanov\Desktop\FileZipper-main\FileZipper\FileArchiver.MVC\Views\Home\_UpdateClientData.cshtml"
using FileArchiver.Common.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"71596cad073057e777ea7bd33fe8c05737dc1ce1", @"/Views/Home/_UpdateClientData.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c35eb4e80649c65915fce8a9c9a9889c4b6715b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home__UpdateClientData : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UpdateUsersViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UpdateUser", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mt-4 btn btn-lg text-center btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mt-4 text-center pb-4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "71596cad073057e777ea7bd33fe8c05737dc1ce15532", async() => {
                WriteLiteral("\n    <div class=\"form-group text-center mb-4\">\n        <div class=\"row\">\n            <div class=\"col-md-12\">\n                ");
#nullable restore
#line 8 "C:\Users\d.stojanov\Desktop\FileZipper-main\FileZipper\FileArchiver.MVC\Views\Home\_UpdateClientData.cshtml"
           Write(Html.LabelFor(x => x.UsersNewName, "Insert new name for the user"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n            </div>\n        </div>\n        <div class=\"row\">\n            <div class=\"col-md-12\">\n                ");
#nullable restore
#line 13 "C:\Users\d.stojanov\Desktop\FileZipper-main\FileZipper\FileArchiver.MVC\Views\Home\_UpdateClientData.cshtml"
           Write(Html.TextBoxFor(x => x.UsersNewName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n            </div>\n        </div>\n        <div class=\"row mt-4\">\n            <div class=\"col-md-12\">\n                ");
#nullable restore
#line 18 "C:\Users\d.stojanov\Desktop\FileZipper-main\FileZipper\FileArchiver.MVC\Views\Home\_UpdateClientData.cshtml"
           Write(Html.LabelFor(x => x.ZipPassword, "Insert new zip password for user"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n            </div>\n        </div>\n        <div class=\"row\">\n            <div class=\"col-md-12\">\n                ");
#nullable restore
#line 23 "C:\Users\d.stojanov\Desktop\FileZipper-main\FileZipper\FileArchiver.MVC\Views\Home\_UpdateClientData.cshtml"
           Write(Html.PasswordFor(x => x.ZipPassword, new { placeholder = "Enter zip password" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n            </div>\n        </div>\n        <div class=\"row mt-2\">\n            <div class=\"col-md-12\">\n                ");
#nullable restore
#line 28 "C:\Users\d.stojanov\Desktop\FileZipper-main\FileZipper\FileArchiver.MVC\Views\Home\_UpdateClientData.cshtml"
           Write(Html.LabelFor(x => x.ConfirmZipPassword, "Confirm password"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n            </div>\n        </div>\n        <div class=\"row\">\n            <div class=\"col-md-12\">\n                ");
#nullable restore
#line 33 "C:\Users\d.stojanov\Desktop\FileZipper-main\FileZipper\FileArchiver.MVC\Views\Home\_UpdateClientData.cshtml"
           Write(Html.PasswordFor(x => x.ConfirmZipPassword, new { placeholder = "Confirm inserted password" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n            </div>\n        </div>\n    </div>\n\n    <div class=\"row\">\n        <div class=\"col-md-12\">\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "71596cad073057e777ea7bd33fe8c05737dc1ce18539", async() => {
                    WriteLiteral("Save changes");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n        </div>\n    </div>\n    <div class=\"row mt-4\">\n        <div class=\"col-md-12\">\n");
#nullable restore
#line 45 "C:\Users\d.stojanov\Desktop\FileZipper-main\FileZipper\FileArchiver.MVC\Views\Home\_UpdateClientData.cshtml"
                 if (ViewBag.ErrorMessage != "Success" || ViewBag.ErrorMessage != null)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div class=\"row mt-4\">\n                        <div class=\"col-md-12\">\n                            <h4 class=\"text-danger\">");
#nullable restore
#line 49 "C:\Users\d.stojanov\Desktop\FileZipper-main\FileZipper\FileArchiver.MVC\Views\Home\_UpdateClientData.cshtml"
                                               Write(ViewBag.ErrorMessage);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h4>\n                        </div>\n                    </div>\n");
#nullable restore
#line 52 "C:\Users\d.stojanov\Desktop\FileZipper-main\FileZipper\FileArchiver.MVC\Views\Home\_UpdateClientData.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </div>\n    </div>\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UpdateUsersViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
