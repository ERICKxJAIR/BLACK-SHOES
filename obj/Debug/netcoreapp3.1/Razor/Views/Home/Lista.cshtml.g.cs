#pragma checksum "C:\Users\Erick\Desktop\black_shoes\Views\Home\Lista.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8cc0d36fa7b344d9c9c4af594e8cc0b3a0cb5ead"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Lista), @"mvc.1.0.view", @"/Views/Home/Lista.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8cc0d36fa7b344d9c9c4af594e8cc0b3a0cb5ead", @"/Views/Home/Lista.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24e2bef6744ade15282c572212cc37198985839e", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Lista : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Formulario>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Atendimento", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\Erick\Desktop\black_shoes\Views\Home\Lista.cshtml"
  
    ViewData["Title"] = "Suas Mensagens";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 5 "C:\Users\Erick\Desktop\black_shoes\Views\Home\Lista.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<table>\r\n    <thead>\r\n        <tr>\r\n            <th> Nome </th>&nbsp\r\n            <th> Endere??o </th>&nbsp\r\n            <th> E-mail </th>&nbsp\r\n            <th> Assunto </th>&nbsp\r\n        </tr>\r\n    </thead>\r\n<tbody>\r\n");
#nullable restore
#line 17 "C:\Users\Erick\Desktop\black_shoes\Views\Home\Lista.cshtml"
      foreach (Formulario Formulario in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n        <td>");
#nullable restore
#line 20 "C:\Users\Erick\Desktop\black_shoes\Views\Home\Lista.cshtml"
       Write(Formulario.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n        <td>");
#nullable restore
#line 22 "C:\Users\Erick\Desktop\black_shoes\Views\Home\Lista.cshtml"
       Write(Formulario.Endereco);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        \r\n        <td>");
#nullable restore
#line 24 "C:\Users\Erick\Desktop\black_shoes\Views\Home\Lista.cshtml"
       Write(Formulario.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n        <td>");
#nullable restore
#line 26 "C:\Users\Erick\Desktop\black_shoes\Views\Home\Lista.cshtml"
       Write(Formulario.Assunto);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n");
#nullable restore
#line 28 "C:\Users\Erick\Desktop\black_shoes\Views\Home\Lista.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("</tbody>\r\n</table>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8cc0d36fa7b344d9c9c4af594e8cc0b3a0cb5ead5386", async() => {
                WriteLiteral("Adicionar outra Reclama????o ou D??vidas??");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Formulario>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
