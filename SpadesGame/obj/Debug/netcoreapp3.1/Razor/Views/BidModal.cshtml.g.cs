#pragma checksum "C:\Users\babel\Documents\IBT College\Module_5\Spades\VS\SpadesGame\SpadesGame\Views\BidModal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e3f23107fcbaf5d658fbdfac39234b452da60c0d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BidModal), @"mvc.1.0.view", @"/Views/BidModal.cshtml")]
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
#line 1 "C:\Users\babel\Documents\IBT College\Module_5\Spades\VS\SpadesGame\SpadesGame\Views\_ViewImports.cshtml"
using SpadesGame;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\babel\Documents\IBT College\Module_5\Spades\VS\SpadesGame\SpadesGame\Views\_ViewImports.cshtml"
using SpadesGame.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e3f23107fcbaf5d658fbdfac39234b452da60c0d", @"/Views/BidModal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68fc691df11fac31a0addc7606b79c8e678c733b", @"/Views/_ViewImports.cshtml")]
    public class Views_BidModal : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\babel\Documents\IBT College\Module_5\Spades\VS\SpadesGame\SpadesGame\Views\BidModal.cshtml"
  
    ViewData["Title"] = "BidModal";
    int i = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""modal fade"" id=""bidModal"" data-backdrop=""static"" data-keyboard=""false"" tabindex=""-1"" role=""dialog"" aria-labelledby=""bidModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog modal-dialog-centered"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""bidModalLabel"">Place your bid</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">                
");
#nullable restore
#line 17 "C:\Users\babel\Documents\IBT College\Module_5\Spades\VS\SpadesGame\SpadesGame\Views\BidModal.cshtml"
                     for (i = 1; i <= 13; i++)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                       <div class=\"form-check form-check-inline\">\r\n                            <input class=\"form-check-input\" type=\"radio\" name=\"inlineRadioOptions\"");
            BeginWriteAttribute("id", " id=\"", 931, "\"", 951, 2);
            WriteAttributeValue("", 936, "inlineRadio", 936, 11, true);
#nullable restore
#line 20 "C:\Users\babel\Documents\IBT College\Module_5\Spades\VS\SpadesGame\SpadesGame\Views\BidModal.cshtml"
WriteAttributeValue("", 947, i, 947, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 952, "\"", 964, 1);
#nullable restore
#line 20 "C:\Users\babel\Documents\IBT College\Module_5\Spades\VS\SpadesGame\SpadesGame\Views\BidModal.cshtml"
WriteAttributeValue("", 960, i, 960, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <label class=\"form-check-label\"");
            BeginWriteAttribute("for", " for=\"", 1027, "\"", 1048, 2);
            WriteAttributeValue("", 1033, "inlineRadio", 1033, 11, true);
#nullable restore
#line 21 "C:\Users\babel\Documents\IBT College\Module_5\Spades\VS\SpadesGame\SpadesGame\Views\BidModal.cshtml"
WriteAttributeValue("", 1044, i, 1044, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 21 "C:\Users\babel\Documents\IBT College\Module_5\Spades\VS\SpadesGame\SpadesGame\Views\BidModal.cshtml"
                                                                             Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                       </div>\r\n");
#nullable restore
#line 23 "C:\Users\babel\Documents\IBT College\Module_5\Spades\VS\SpadesGame\SpadesGame\Views\BidModal.cshtml"
                    }   

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n            <div class=\"modal-footer\">                \r\n                <button type=\"button\" class=\"btn btn-primary\">Place bid</button>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
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
