#pragma checksum "C:\Users\Erick\Desktop\black_shoes\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f898e64dead27f1c9e2c732ad60ea6dc64bf762b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Erick\Desktop\black_shoes\Views\_ViewImports.cshtml"
using black_shoes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Erick\Desktop\black_shoes\Views\_ViewImports.cshtml"
using black_shoes.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f898e64dead27f1c9e2c732ad60ea6dc64bf762b", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24e2bef6744ade15282c572212cc37198985839e", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("Formulario"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"pt-BR\">\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f898e64dead27f1c9e2c732ad60ea6dc64bf762b3880", async() => {
                WriteLiteral(@"
    <title>Página Inicial</title>

    <meta charset=""UTF-8"">
    <meta name=""keywords"" content=""HTML, CSS, JavaScript, SQL"">
    <meta name=""description"" content=""Site de tenis de alta performace."">

    <link rel=""icon"" type=""image/logo.jpg"" href=""img/logo.jpg"">



    <link rel=""stylesheet"" type=""text/css"">
    <style type=""text/css"">
        body {
            font-family: Arial, Helvetica, sans-serif;
            margin: 0;
            padding: 0;
        }


        .cabecalho {
            width: 100%;
            height: 50px;
            background-color: #7e7e7e;
            display: inline;

        }


        .nav {
            text-align: center;
            font-size: 20px;
            color: rgb(0, 0, 0);
            padding: 5px;
            font-family: Arial, Helvetica, sans-serif;
        }

        .nav a:link {
            text-decoration: none;
            color: rgb(0, 0, 0);
            margin: 10px;
        }

        .nav a:visited {
    ");
                WriteLiteral(@"        text-decoration: none;
            color: rgb(255, 0, 0);
        }

        .nav a:hover {
            text-decoration: none;
            color: rgb(194, 194, 194);
        }

        .nav a:active {
            text-decoration: none;
            color: rgb(143, 143, 143);
        }

        .textoBonitoClasse {
            font-size: 22px;
            text-align: right;
            color: rgb(143, 143, 143);
        }

        #textoBonitoId {
            color: rgb(255, 4, 4);
        }

        .boasvindas {
            font-family: Arial, Helvetica, sans-serif;
            font-size: 48px;
            text-align: center;
        }

        .banner {
            width: 100px;
            height: 100px;
            background-image: url('../img/logo.png');
            background-position: left;
            background-size: cover;
        }

        .item {
            width: 550px;
            height: 300px;
            border: 1px solid grey;
            b");
                WriteLiteral(@"order-radius: 10px;
            margin: 1px;
            padding: 1px;

        }

        .info {
            width: 50%;
            float: left;
            margin-left: 10px;
            margin-top: -10px;
        }

        .visualizacao {
            width: 48%;
            height: 300px;
            float: left;
            object-fit: cover;
        }

        .detalhes {
            background-color: cyan;
            padding: 15px;
            font-size: 18px;
            border-radius: 10px;
            text-decoration: none;
            margin-left: 0px;
        }

        .carrinho {
            background-color: rgb(0, 0, 0);
            padding: 10px;
            font-size: 30px;
            border-radius: 10px;
            text-decoration: none;
            margin-left: 0px;
        }


        .imagem {
            width: 30%;
            object-fit: cover;
            height: 80%;

        }

        .container {
            display: inline-bloc");
                WriteLiteral(@"k;

        }

        .centralizar {
            display: flex;
            flex-direction: row;
            justify-content: center;
            align-items: center;
        }

        .Formulario {
            font-family: Arial, Helvetica, sans-serif;
            font-size: 20px;
            text-align: center;

        }

        .grid-container {
            display: grid;
            gap: 10px;
            grid-template-columns: auto auto auto;
            background-color: #ffffff;
            padding: 40px;
        }

        .grid-item {
            font-family: Georgia, 'Times New Roman', Times, serif;
            background-color: rgba(255, 255, 255, 0.8);
            border: 1px solid rgba(0, 0, 0, 0.8);
            padding: 1%;
            font-size: 60px;
            text-align: right;
        }
    </style>

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f898e64dead27f1c9e2c732ad60ea6dc64bf762b8933", async() => {
                WriteLiteral(@"


    <div class=""banner""></div>

    <div class=""cabecalho"">
        <div class=""logo"">


        </div>
        <p>
            <center>
                <img src=""img/logo.jpg"" alt=""promocoes e valores dos Produtos e imagem. "" </center>
        </p>

        <h1>

            <div class=""grid-container"">
                <div class=""grid-item""> AIR FORCE 1 R$2,500

                    <img class=""imagem"" src=""img/air force marron.jpg"">
                    <a class=""imagem""");
                BeginWriteAttribute("href", " href=\"", 4515, "\"", 4522, 0);
                EndWriteAttribute();
                WriteLiteral("></a>\r\n                    <a class=\"carrinho\"");
                BeginWriteAttribute("href", " href=\"", 4569, "\"", 4576, 0);
                EndWriteAttribute();
                WriteLiteral(">Comprar</a>\r\n                </div>\r\n            </div>\r\n\r\n\r\n            <div class=\"grid-item\"> AIR JAORDAN AJ R$1,999\r\n                <img class=\"imagem\" src=\"img/Air jordan AJ.jpeg\">\r\n                <a");
                BeginWriteAttribute("class", " class=\"", 4784, "\"", 4792, 0);
                EndWriteAttribute();
                BeginWriteAttribute("href", " href=\"", 4793, "\"", 4800, 0);
                EndWriteAttribute();
                WriteLiteral("></a>\r\n                <a class=\"carrinho\"");
                BeginWriteAttribute("href", " href=\"", 4843, "\"", 4850, 0);
                EndWriteAttribute();
                WriteLiteral(@">Comprar</a>
            </div>


        </h1>






        <h2 class=""Formulario"">FIQUE POR DENTRO DAS NOSSAS NOVIDADES!
            <p>
                <center>
                    <img src=""img/logo.jpg"" alt=""promocoes e valores dos Produtos e imagem. "" </center>
            </p>
            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f898e64dead27f1c9e2c732ad60ea6dc64bf762b11079", async() => {
                    WriteLiteral(@"
                <label>NOME:</label>
                <input type=""text"" placeholder=""ESCREVA SEU NOME AQUI"" required>
                <br>
                <label>E-MAIL:</label>
                <input type=""email"" placeholder=""ESCREVA SEU E-MAIL AQUI"" required>
                <br>
                <label>TELEFONE</label>
                <input type=""text"" placeholder=""ESCREVA SEU TELEFONE AQUI"" required>
                <br>
                <input type=""submit"" value=""Enviar"" ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        </h2>\r\n    </div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n</html>\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591