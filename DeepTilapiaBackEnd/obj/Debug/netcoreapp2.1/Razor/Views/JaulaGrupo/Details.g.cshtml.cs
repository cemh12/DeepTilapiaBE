#pragma checksum "C:\Users\cemh_\source\repos\DeepTilapiaBackEnd\DeepTilapiaBackEnd\Views\JaulaGrupo\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d9f1ac3fffdb1e9d1957779471427f5be181fb42"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_JaulaGrupo_Details), @"mvc.1.0.view", @"/Views/JaulaGrupo/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/JaulaGrupo/Details.cshtml", typeof(AspNetCore.Views_JaulaGrupo_Details))]
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
#line 1 "C:\Users\cemh_\source\repos\DeepTilapiaBackEnd\DeepTilapiaBackEnd\Views\_ViewImports.cshtml"
using DeepTilapiaBackEnd;

#line default
#line hidden
#line 2 "C:\Users\cemh_\source\repos\DeepTilapiaBackEnd\DeepTilapiaBackEnd\Views\_ViewImports.cshtml"
using DeepTilapiaBackEnd.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d9f1ac3fffdb1e9d1957779471427f5be181fb42", @"/Views/JaulaGrupo/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5c929d0518e77dee25b9f2c1856862a09df991c", @"/Views/_ViewImports.cshtml")]
    public class Views_JaulaGrupo_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DeepTilapiaBackEnd.Models.JaulaGrupo>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(45, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\cemh_\source\repos\DeepTilapiaBackEnd\DeepTilapiaBackEnd\Views\JaulaGrupo\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(90, 124, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>JaulaGrupo</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(215, 43, false);
#line 14 "C:\Users\cemh_\source\repos\DeepTilapiaBackEnd\DeepTilapiaBackEnd\Views\JaulaGrupo\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IDJaula));

#line default
#line hidden
            EndContext();
            BeginContext(258, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(302, 39, false);
#line 17 "C:\Users\cemh_\source\repos\DeepTilapiaBackEnd\DeepTilapiaBackEnd\Views\JaulaGrupo\Details.cshtml"
       Write(Html.DisplayFor(model => model.IDJaula));

#line default
#line hidden
            EndContext();
            BeginContext(341, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(385, 50, false);
#line 20 "C:\Users\cemh_\source\repos\DeepTilapiaBackEnd\DeepTilapiaBackEnd\Views\JaulaGrupo\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IDGrupoTilapia));

#line default
#line hidden
            EndContext();
            BeginContext(435, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(479, 46, false);
#line 23 "C:\Users\cemh_\source\repos\DeepTilapiaBackEnd\DeepTilapiaBackEnd\Views\JaulaGrupo\Details.cshtml"
       Write(Html.DisplayFor(model => model.IDGrupoTilapia));

#line default
#line hidden
            EndContext();
            BeginContext(525, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(569, 44, false);
#line 26 "C:\Users\cemh_\source\repos\DeepTilapiaBackEnd\DeepTilapiaBackEnd\Views\JaulaGrupo\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Cantidad));

#line default
#line hidden
            EndContext();
            BeginContext(613, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(657, 40, false);
#line 29 "C:\Users\cemh_\source\repos\DeepTilapiaBackEnd\DeepTilapiaBackEnd\Views\JaulaGrupo\Details.cshtml"
       Write(Html.DisplayFor(model => model.Cantidad));

#line default
#line hidden
            EndContext();
            BeginContext(697, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(741, 47, false);
#line 32 "C:\Users\cemh_\source\repos\DeepTilapiaBackEnd\DeepTilapiaBackEnd\Views\JaulaGrupo\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FechaInicio));

#line default
#line hidden
            EndContext();
            BeginContext(788, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(832, 43, false);
#line 35 "C:\Users\cemh_\source\repos\DeepTilapiaBackEnd\DeepTilapiaBackEnd\Views\JaulaGrupo\Details.cshtml"
       Write(Html.DisplayFor(model => model.FechaInicio));

#line default
#line hidden
            EndContext();
            BeginContext(875, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(919, 44, false);
#line 38 "C:\Users\cemh_\source\repos\DeepTilapiaBackEnd\DeepTilapiaBackEnd\Views\JaulaGrupo\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FechaFin));

#line default
#line hidden
            EndContext();
            BeginContext(963, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1007, 40, false);
#line 41 "C:\Users\cemh_\source\repos\DeepTilapiaBackEnd\DeepTilapiaBackEnd\Views\JaulaGrupo\Details.cshtml"
       Write(Html.DisplayFor(model => model.FechaFin));

#line default
#line hidden
            EndContext();
            BeginContext(1047, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1091, 56, false);
#line 44 "C:\Users\cemh_\source\repos\DeepTilapiaBackEnd\DeepTilapiaBackEnd\Views\JaulaGrupo\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IDJaulaGrupoAnterior));

#line default
#line hidden
            EndContext();
            BeginContext(1147, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1191, 52, false);
#line 47 "C:\Users\cemh_\source\repos\DeepTilapiaBackEnd\DeepTilapiaBackEnd\Views\JaulaGrupo\Details.cshtml"
       Write(Html.DisplayFor(model => model.IDJaulaGrupoAnterior));

#line default
#line hidden
            EndContext();
            BeginContext(1243, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1290, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0d9a0138b98b43c98c1733cb8b0bd6dd", async() => {
                BeginContext(1336, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 52 "C:\Users\cemh_\source\repos\DeepTilapiaBackEnd\DeepTilapiaBackEnd\Views\JaulaGrupo\Details.cshtml"
                           WriteLiteral(Model.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1344, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1352, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c96c7bde39eb4c1abe539e59358832cb", async() => {
                BeginContext(1374, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1390, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DeepTilapiaBackEnd.Models.JaulaGrupo> Html { get; private set; }
    }
}
#pragma warning restore 1591
