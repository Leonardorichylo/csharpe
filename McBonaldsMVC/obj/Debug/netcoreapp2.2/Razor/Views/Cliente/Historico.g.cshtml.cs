#pragma checksum "C:\Users\40349113874\Downloads\McBonaldsMVC\McBonaldsMVC\Views\Cliente\Historico.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a3342606b2755371f2fb7d9c3655102ddd813161"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cliente_Historico), @"mvc.1.0.view", @"/Views/Cliente/Historico.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cliente/Historico.cshtml", typeof(AspNetCore.Views_Cliente_Historico))]
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
#line 1 "C:\Users\40349113874\Downloads\McBonaldsMVC\McBonaldsMVC\Views\_ViewImports.cshtml"
using McBonaldsMVC;

#line default
#line hidden
#line 2 "C:\Users\40349113874\Downloads\McBonaldsMVC\McBonaldsMVC\Views\_ViewImports.cshtml"
using McBonaldsMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3342606b2755371f2fb7d9c3655102ddd813161", @"/Views/Cliente/Historico.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57177a2332d7bbd6b3532411ed5e910c130f158a", @"/Views/_ViewImports.cshtml")]
    public class Views_Cliente_Historico : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<McBonaldsMVC.ViewModels.HistoricoViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\40349113874\Downloads\McBonaldsMVC\McBonaldsMVC\Views\Cliente\Historico.cshtml"
  
    ViewData["Title"] = "Pedidos - McBonald's";
    ViewData["H2"] = "Histórico de Pedidos";

#line default
#line hidden
            BeginContext(153, 16, true);
            WriteLiteral("<main>\r\n    <h2>");
            EndContext();
            BeginContext(170, 14, false);
#line 7 "C:\Users\40349113874\Downloads\McBonaldsMVC\McBonaldsMVC\Views\Cliente\Historico.cshtml"
   Write(ViewData["H2"]);

#line default
#line hidden
            EndContext();
            BeginContext(184, 241, true);
            WriteLiteral("</h2>\r\n    <table>\r\n        <thead>\r\n            <tr>\r\n                <th>Data</th>\r\n                <th>Hamburguer</th>\r\n                <th>Shake</th>\r\n                <th>Preço</th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
            EndContext();
#line 18 "C:\Users\40349113874\Downloads\McBonaldsMVC\McBonaldsMVC\Views\Cliente\Historico.cshtml"
             foreach( var pedido in Model.Pedidos ) {

#line default
#line hidden
            BeginContext(480, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(527, 19, false);
#line 20 "C:\Users\40349113874\Downloads\McBonaldsMVC\McBonaldsMVC\Views\Cliente\Historico.cshtml"
                   Write(pedido.DataDoPedido);

#line default
#line hidden
            EndContext();
            BeginContext(546, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(578, 22, false);
#line 21 "C:\Users\40349113874\Downloads\McBonaldsMVC\McBonaldsMVC\Views\Cliente\Historico.cshtml"
                   Write(pedido.Hamburguer.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(600, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(632, 17, false);
#line 22 "C:\Users\40349113874\Downloads\McBonaldsMVC\McBonaldsMVC\Views\Cliente\Historico.cshtml"
                   Write(pedido.Shake.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(649, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(681, 17, false);
#line 23 "C:\Users\40349113874\Downloads\McBonaldsMVC\McBonaldsMVC\Views\Cliente\Historico.cshtml"
                   Write(pedido.PrecoTotal);

#line default
#line hidden
            EndContext();
            BeginContext(698, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 25 "C:\Users\40349113874\Downloads\McBonaldsMVC\McBonaldsMVC\Views\Cliente\Historico.cshtml"
            }

#line default
#line hidden
            BeginContext(743, 41, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n\r\n</main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<McBonaldsMVC.ViewModels.HistoricoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
