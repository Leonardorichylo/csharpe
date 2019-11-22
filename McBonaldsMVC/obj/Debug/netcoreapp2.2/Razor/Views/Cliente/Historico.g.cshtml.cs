#pragma checksum "C:\Users\40349113874\Documents\csharpe\McBonaldsMVC\Views\Cliente\Historico.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8602c85918f4bd08b53aa11af55bc52a3f3b2057"
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
#line 1 "C:\Users\40349113874\Documents\csharpe\McBonaldsMVC\Views\_ViewImports.cshtml"
using McBonaldsMVC;

#line default
#line hidden
#line 2 "C:\Users\40349113874\Documents\csharpe\McBonaldsMVC\Views\_ViewImports.cshtml"
using McBonaldsMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8602c85918f4bd08b53aa11af55bc52a3f3b2057", @"/Views/Cliente/Historico.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cecd1f98a04a4696ecde4ba045dcb777a275b8f0", @"/Views/_ViewImports.cshtml")]
    public class Views_Cliente_Historico : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<McBonaldsMVC.ViewModels.HistoricoViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\40349113874\Documents\csharpe\McBonaldsMVC\Views\Cliente\Historico.cshtml"
  
    ViewData["Title"] = "Pedidos - McBonald's";
    ViewData["H2"] = "Histórico de Pedidos";

#line default
#line hidden
            BeginContext(153, 18, true);
            WriteLiteral("\r\n<main>\r\n    <h2>");
            EndContext();
            BeginContext(172, 14, false);
#line 8 "C:\Users\40349113874\Documents\csharpe\McBonaldsMVC\Views\Cliente\Historico.cshtml"
   Write(ViewData["H2"]);

#line default
#line hidden
            EndContext();
            BeginContext(186, 241, true);
            WriteLiteral("</h2>\r\n    <table>\r\n        <thead>\r\n            <tr>\r\n                <th>Data</th>\r\n                <th>Hamburguer</th>\r\n                <th>Shake</th>\r\n                <th>Preço</th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
            EndContext();
#line 19 "C:\Users\40349113874\Documents\csharpe\McBonaldsMVC\Views\Cliente\Historico.cshtml"
             foreach( var pedido in Model.Pedidos ) {

#line default
#line hidden
            BeginContext(482, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(529, 19, false);
#line 21 "C:\Users\40349113874\Documents\csharpe\McBonaldsMVC\Views\Cliente\Historico.cshtml"
                   Write(pedido.DataDoPedido);

#line default
#line hidden
            EndContext();
            BeginContext(548, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(580, 22, false);
#line 22 "C:\Users\40349113874\Documents\csharpe\McBonaldsMVC\Views\Cliente\Historico.cshtml"
                   Write(pedido.Hamburguer.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(602, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(634, 17, false);
#line 23 "C:\Users\40349113874\Documents\csharpe\McBonaldsMVC\Views\Cliente\Historico.cshtml"
                   Write(pedido.Shake.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(651, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(683, 17, false);
#line 24 "C:\Users\40349113874\Documents\csharpe\McBonaldsMVC\Views\Cliente\Historico.cshtml"
                   Write(pedido.PrecoTotal);

#line default
#line hidden
            EndContext();
            BeginContext(700, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 26 "C:\Users\40349113874\Documents\csharpe\McBonaldsMVC\Views\Cliente\Historico.cshtml"
            }

#line default
#line hidden
            BeginContext(745, 41, true);
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
