#pragma checksum "C:\Users\babel\Documents\IBT College\Module_5\Spades\VS\SpadesGame\SpadesGame\Views\scoreBoard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ef1a410a2f851855547e5d937110836041b6ee28"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_scoreBoard), @"mvc.1.0.view", @"/Views/scoreBoard.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef1a410a2f851855547e5d937110836041b6ee28", @"/Views/scoreBoard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68fc691df11fac31a0addc7606b79c8e678c733b", @"/Views/_ViewImports.cshtml")]
    public class Views_scoreBoard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\babel\Documents\IBT College\Module_5\Spades\VS\SpadesGame\SpadesGame\Views\scoreBoard.cshtml"
  
    ViewData["Title"] = "scoreBoard";      

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"card prod-p-card card-red \">\r\n    <div class=\"card-body\">\r\n        <div class=\"row align-items-center m-b-30\">\r\n            <div class=\"col\">               \r\n                <h6 class=\"m-b-5 text-white\">");
#nullable restore
#line 9 "C:\Users\babel\Documents\IBT College\Module_5\Spades\VS\SpadesGame\SpadesGame\Views\scoreBoard.cshtml"
                                        Write(Settings.bot1Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                <h3 class=\"m-b-0 f-w-700 text-white\">");
#nullable restore
#line 10 "C:\Users\babel\Documents\IBT College\Module_5\Spades\VS\SpadesGame\SpadesGame\Views\scoreBoard.cshtml"
                                                Write(Settings.bot1Score);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
            </div>
            <div class=""col-auto"">
                <i class=""fas fa-user text-c-red f-18""></i>
            </div>
        </div>
    </div>
</div>
<div class=""card prod-p-card card-blue"">
    <div class=""card-body"">
        <div class=""row align-items-center m-b-30"">
            <div class=""col"">
                <h6 class=""m-b-5 text-white"">");
#nullable restore
#line 22 "C:\Users\babel\Documents\IBT College\Module_5\Spades\VS\SpadesGame\SpadesGame\Views\scoreBoard.cshtml"
                                        Write(Settings.bot2Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                <h3 class=\"m-b-0 f-w-700 text-white\">");
#nullable restore
#line 23 "C:\Users\babel\Documents\IBT College\Module_5\Spades\VS\SpadesGame\SpadesGame\Views\scoreBoard.cshtml"
                                                Write(Settings.bot2Score);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
            </div>
            <div class=""col-auto"">
                <i class=""fas fa-user text-c-blue f-18""></i>
            </div>
        </div>
    </div>
</div>
<div class=""card prod-p-card card-green"">
    <div class=""card-body"">
        <div class=""row align-items-center m-b-30"">
            <div class=""col"">
                <h6 class=""m-b-5 text-white"">");
#nullable restore
#line 35 "C:\Users\babel\Documents\IBT College\Module_5\Spades\VS\SpadesGame\SpadesGame\Views\scoreBoard.cshtml"
                                        Write(Settings.bot3Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                <h3 class=\"m-b-0 f-w-700 text-white\">");
#nullable restore
#line 36 "C:\Users\babel\Documents\IBT College\Module_5\Spades\VS\SpadesGame\SpadesGame\Views\scoreBoard.cshtml"
                                                Write(Settings.bot3Score);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
            </div>
            <div class=""col-auto"">
                <i class=""fas fa-user text-c-green f-18""></i>
            </div>
        </div>
    </div>
</div>
<div class=""card prod-p-card card-yellow"">
    <div class=""card-body"">
        <div class=""row align-items-center m-b-30"">
            <div class=""col"">
                <h6 class=""m-b-5 text-white"">");
#nullable restore
#line 48 "C:\Users\babel\Documents\IBT College\Module_5\Spades\VS\SpadesGame\SpadesGame\Views\scoreBoard.cshtml"
                                        Write(Settings.hPlayerName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                <h3 class=\"m-b-0 f-w-700 text-white\">");
#nullable restore
#line 49 "C:\Users\babel\Documents\IBT College\Module_5\Spades\VS\SpadesGame\SpadesGame\Views\scoreBoard.cshtml"
                                                Write(Settings.hPlayerScore);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n            </div>\r\n            <div class=\"col-auto\">\r\n                <i class=\"fas fa-user text-c-yellow f-18\"></i>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
