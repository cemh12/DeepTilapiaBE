#pragma checksum "C:\Users\cemh_\source\repos\DeepTilapiaBackEnd\DeepTilapiaBackEnd\Views\GrupoTilapia\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd098a3c5bc3b76d486135981803775fafff8738"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_GrupoTilapia_Delete), @"mvc.1.0.view", @"/Views/GrupoTilapia/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/GrupoTilapia/Delete.cshtml", typeof(AspNetCore.Views_GrupoTilapia_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd098a3c5bc3b76d486135981803775fafff8738", @"/Views/GrupoTilapia/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5c929d0518e77dee25b9f2c1856862a09df991c", @"/Views/_ViewImports.cshtml")]
    public class Views_GrupoTilapia_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DeepTilapiaBackEnd.Models.GrupoTilapia>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(47, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\cemh_\source\repos\DeepTilapiaBackEnd\DeepTilapiaBackEnd\Views\GrupoTilapia\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(91, 173, true);
            WriteLiteral("\r\n<h2>Delete</h2>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>GrupoTilapia</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(265, 44, false);
#line 15 "C:\Users\cemh_\source\repos\DeepTilapiaBackEnd\DeepTilapiaBackEnd\Views\GrupoTilapia\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Cantidad));

#line default
#line hidden
            EndContext();
            BeginContext(309, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(353, 40, false);
#line 18 "C:\Users\cemh_\source\repos\DeepTilapiaBackEnd\DeepTilapiaBackEnd\Views\GrupoTilapia\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Cantidad));

#line default
#line hidden
            EndContext();
            BeginContext(393, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(437, 48, false);
#line 21 "C:\Users\cemh_\source\repos\DeepTilapiaBackEnd\DeepTilapiaBackEnd\Views\GrupoTilapia\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.PesoPromedio));

#line default
#line hidden
            EndContext();
            BeginContext(485, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(529, 44, false);
#line 24 "C:\Users\cemh_\source\repos\DeepTilapiaBackEnd\DeepTilapiaBackEnd\Views\GrupoTilapia\Delete.cshtml"
       Write(Html.DisplayFor(model => model.PesoPromedio));

#line default
#line hidden
            EndContext();
            BeginContext(573, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(617, 41, false);
#line 27 "C:\Users\cemh_\source\repos\DeepTilapiaBackEnd\DeepTilapiaBackEnd\Views\GrupoTilapia\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Etapa));

#line default
#line hidden
            EndContext();
            BeginContext(658, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(702, 37, false);
#line 30 "C:\Users\cemh_\source\repos\DeepTilapiaBackEnd\DeepTilapiaBackEnd\Views\GrupoTilapia\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Etapa));

#line default
#line hidden
            EndContext();
            BeginContext(739, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(783, 48, false);
#line 33 "C:\Users\cemh_\source\repos\DeepTilapiaBackEnd\DeepTilapiaBackEnd\Views\GrupoTilapia\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.FechaLlegada));

#line default
#line hidden
            EndContext();
            BeginContext(831, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(875, 44, false);
#line 36 "C:\Users\cemh_\source\repos\DeepTilapiaBackEnd\DeepTilapiaBackEnd\Views\GrupoTilapia\Delete.cshtml"
       Write(Html.DisplayFor(model => model.FechaLlegada));

#line default
#line hidden
            EndContext();
            BeginContext(919, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(963, 46, false);
#line 39 "C:\Users\cemh_\source\repos\DeepTilapiaBackEnd\DeepTilapiaBackEnd\Views\GrupoTilapia\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CostoXPeso));

#line default
#line hidden
            EndContext();
            BeginContext(1009, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1053, 42, false);
#line 42 "C:\Users\cemh_\source\repos\DeepTilapiaBackEnd\DeepTilapiaBackEnd\Views\GrupoTilapia\Delete.cshtml"
       Write(Html.DisplayFor(model => model.CostoXPeso));

#line default
#line hidden
            EndContext();
            BeginContext(1095, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1139, 48, false);
#line 45 "C:\Users\cemh_\source\repos\DeepTilapiaBackEnd\DeepTilapiaBackEnd\Views\GrupoTilapia\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CostoXUnidad));

#line default
#line hidden
            EndContext();
            BeginContext(1187, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1231, 44, false);
#line 48 "C:\Users\cemh_\source\repos\DeepTilapiaBackEnd\DeepTilapiaBackEnd\Views\GrupoTilapia\Delete.cshtml"
       Write(Html.DisplayFor(model => model.CostoXUnidad));

#line default
#line hidden
            EndContext();
            BeginContext(1275, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1319, 55, false);
#line 51 "C:\Users\cemh_\source\repos\DeepTilapiaBackEnd\DeepTilapiaBackEnd\Views\GrupoTilapia\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TemperaturaSuplidor));

#line default
#line hidden
            EndContext();
            BeginContext(1374, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1418, 51, false);
#line 54 "C:\Users\cemh_\source\repos\DeepTilapiaBackEnd\DeepTilapiaBackEnd\Views\GrupoTilapia\Delete.cshtml"
       Write(Html.DisplayFor(model => model.TemperaturaSuplidor));

#line default
#line hidden
            EndContext();
            BeginContext(1469, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1513, 46, false);
#line 57 "C:\Users\cemh_\source\repos\DeepTilapiaBackEnd\DeepTilapiaBackEnd\Views\GrupoTilapia\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.PhSuplidor));

#line default
#line hidden
            EndContext();
            BeginContext(1559, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1603, 42, false);
#line 60 "C:\Users\cemh_\source\repos\DeepTilapiaBackEnd\DeepTilapiaBackEnd\Views\GrupoTilapia\Delete.cshtml"
       Write(Html.DisplayFor(model => model.PhSuplidor));

#line default
#line hidden
            EndContext();
            BeginContext(1645, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1689, 57, false);
#line 63 "C:\Users\cemh_\source\repos\DeepTilapiaBackEnd\DeepTilapiaBackEnd\Views\GrupoTilapia\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TemperaturaTransporte));

#line default
#line hidden
            EndContext();
            BeginContext(1746, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1790, 53, false);
#line 66 "C:\Users\cemh_\source\repos\DeepTilapiaBackEnd\DeepTilapiaBackEnd\Views\GrupoTilapia\Delete.cshtml"
       Write(Html.DisplayFor(model => model.TemperaturaTransporte));

#line default
#line hidden
            EndContext();
            BeginContext(1843, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1887, 48, false);
#line 69 "C:\Users\cemh_\source\repos\DeepTilapiaBackEnd\DeepTilapiaBackEnd\Views\GrupoTilapia\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.PhTransporte));

#line default
#line hidden
            EndContext();
            BeginContext(1935, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1979, 44, false);
#line 72 "C:\Users\cemh_\source\repos\DeepTilapiaBackEnd\DeepTilapiaBackEnd\Views\GrupoTilapia\Delete.cshtml"
       Write(Html.DisplayFor(model => model.PhTransporte));

#line default
#line hidden
            EndContext();
            BeginContext(2023, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2067, 59, false);
#line 75 "C:\Users\cemh_\source\repos\DeepTilapiaBackEnd\DeepTilapiaBackEnd\Views\GrupoTilapia\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TemperaturaRecibimiento));

#line default
#line hidden
            EndContext();
            BeginContext(2126, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2170, 55, false);
#line 78 "C:\Users\cemh_\source\repos\DeepTilapiaBackEnd\DeepTilapiaBackEnd\Views\GrupoTilapia\Delete.cshtml"
       Write(Html.DisplayFor(model => model.TemperaturaRecibimiento));

#line default
#line hidden
            EndContext();
            BeginContext(2225, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2269, 50, false);
#line 81 "C:\Users\cemh_\source\repos\DeepTilapiaBackEnd\DeepTilapiaBackEnd\Views\GrupoTilapia\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.PhRecibimiento));

#line default
#line hidden
            EndContext();
            BeginContext(2319, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2363, 46, false);
#line 84 "C:\Users\cemh_\source\repos\DeepTilapiaBackEnd\DeepTilapiaBackEnd\Views\GrupoTilapia\Delete.cshtml"
       Write(Html.DisplayFor(model => model.PhRecibimiento));

#line default
#line hidden
            EndContext();
            BeginContext(2409, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2453, 55, false);
#line 87 "C:\Users\cemh_\source\repos\DeepTilapiaBackEnd\DeepTilapiaBackEnd\Views\GrupoTilapia\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DistanciaTransporte));

#line default
#line hidden
            EndContext();
            BeginContext(2508, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2552, 51, false);
#line 90 "C:\Users\cemh_\source\repos\DeepTilapiaBackEnd\DeepTilapiaBackEnd\Views\GrupoTilapia\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DistanciaTransporte));

#line default
#line hidden
            EndContext();
            BeginContext(2603, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2647, 47, false);
#line 93 "C:\Users\cemh_\source\repos\DeepTilapiaBackEnd\DeepTilapiaBackEnd\Views\GrupoTilapia\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.FechaSalida));

#line default
#line hidden
            EndContext();
            BeginContext(2694, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2738, 43, false);
#line 96 "C:\Users\cemh_\source\repos\DeepTilapiaBackEnd\DeepTilapiaBackEnd\Views\GrupoTilapia\Delete.cshtml"
       Write(Html.DisplayFor(model => model.FechaSalida));

#line default
#line hidden
            EndContext();
            BeginContext(2781, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2825, 52, false);
#line 99 "C:\Users\cemh_\source\repos\DeepTilapiaBackEnd\DeepTilapiaBackEnd\Views\GrupoTilapia\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MetodoTransporte));

#line default
#line hidden
            EndContext();
            BeginContext(2877, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2921, 48, false);
#line 102 "C:\Users\cemh_\source\repos\DeepTilapiaBackEnd\DeepTilapiaBackEnd\Views\GrupoTilapia\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MetodoTransporte));

#line default
#line hidden
            EndContext();
            BeginContext(2969, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(3007, 207, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ea9a72706c8b427da2846ecd3c2f43d0", async() => {
                BeginContext(3033, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(3043, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "15bc61b746bf4d70b9f3c31de8cfde5f", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 107 "C:\Users\cemh_\source\repos\DeepTilapiaBackEnd\DeepTilapiaBackEnd\Views\GrupoTilapia\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ID);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3079, 84, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n        ");
                EndContext();
                BeginContext(3163, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2997cfc742eb490392d5ea3572174c7f", async() => {
                    BeginContext(3185, 12, true);
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
                BeginContext(3201, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3214, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DeepTilapiaBackEnd.Models.GrupoTilapia> Html { get; private set; }
    }
}
#pragma warning restore 1591