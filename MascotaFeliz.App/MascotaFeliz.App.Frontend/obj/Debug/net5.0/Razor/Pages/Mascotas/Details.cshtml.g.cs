#pragma checksum "D:\Ciclo 3\Proyecto\Aplicacion 5.0\ProyectoMascotasCiclo3\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Mascotas\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d6986c433a56d4454f1a0842600494f27ac57d0a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MascotaFeliz.App.Frontend.Pages.Mascotas.Pages_Mascotas_Details), @"mvc.1.0.razor-page", @"/Pages/Mascotas/Details.cshtml")]
namespace MascotaFeliz.App.Frontend.Pages.Mascotas
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
#line 1 "D:\Ciclo 3\Proyecto\Aplicacion 5.0\ProyectoMascotasCiclo3\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\_ViewImports.cshtml"
using MascotaFeliz.App.Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6986c433a56d4454f1a0842600494f27ac57d0a", @"/Pages/Mascotas/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0db3109f5b6f5af41669f0604e1d2d85ed50411c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Mascotas_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./List", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<section id=\"hero\">\r\n\r\n<h2>Datos Detallados de Mascota ");
#nullable restore
#line 7 "D:\Ciclo 3\Proyecto\Aplicacion 5.0\ProyectoMascotasCiclo3\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Mascotas\Details.cshtml"
                           Write(Model.Mascota.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<div>\r\n    Nombre: ");
#nullable restore
#line 9 "D:\Ciclo 3\Proyecto\Aplicacion 5.0\ProyectoMascotasCiclo3\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Mascotas\Details.cshtml"
       Write(Model.Mascota.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<div>\r\n    Especie: ");
#nullable restore
#line 12 "D:\Ciclo 3\Proyecto\Aplicacion 5.0\ProyectoMascotasCiclo3\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Mascotas\Details.cshtml"
        Write(Model.Mascota.Especie);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<div>\r\n    Raza: ");
#nullable restore
#line 15 "D:\Ciclo 3\Proyecto\Aplicacion 5.0\ProyectoMascotasCiclo3\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Mascotas\Details.cshtml"
     Write(Model.Mascota.Raza);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<div>\r\n    Color: ");
#nullable restore
#line 18 "D:\Ciclo 3\Proyecto\Aplicacion 5.0\ProyectoMascotasCiclo3\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Mascotas\Details.cshtml"
      Write(Model.Mascota.Color);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d6986c433a56d4454f1a0842600494f27ac57d0a5343", async() => {
                WriteLiteral("Volver a la Lista de Mascotas.. ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MascotaFeliz.App.Frontend.Pages.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MascotaFeliz.App.Frontend.Pages.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MascotaFeliz.App.Frontend.Pages.DetailsModel>)PageContext?.ViewData;
        public MascotaFeliz.App.Frontend.Pages.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
