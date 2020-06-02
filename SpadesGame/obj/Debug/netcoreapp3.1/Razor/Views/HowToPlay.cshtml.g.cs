#pragma checksum "C:\Users\babel\Documents\IBT College\Module_5\Spades\VS\SpadesGame\SpadesGame\Views\HowToPlay.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "084146fcd7a5a5b20a8d1d12e38af255c0b6d836"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HowToPlay), @"mvc.1.0.view", @"/Views/HowToPlay.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"084146fcd7a5a5b20a8d1d12e38af255c0b6d836", @"/Views/HowToPlay.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68fc691df11fac31a0addc7606b79c8e678c733b", @"/Views/_ViewImports.cshtml")]
    public class Views_HowToPlay : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\babel\Documents\IBT College\Module_5\Spades\VS\SpadesGame\SpadesGame\Views\HowToPlay.cshtml"
  
    ViewData["Title"] = "HowToPlay";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""modal fade"" id=""howToPlay"" tabindex=""-1"" role=""dialog"" aria-labelledby=""aboutModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog modal-dialog-centered modal-dialog-scrollable"">
        <div class=""modal-content"">
            <h2 class=""text-center mt-3""><span class=""text-muted"">Rules</span></h2>
            <div class=""modal-body"">
                <h4><span class=""text-muted text-center"">Introduction</span></h4>
                <p>Spades is a trick-taking card game devised in the United States in the 1930s. 
                    It can be played as either a partnership or solo/""cutthroat"" game. The object is to take the number of tricks that were 
                    bid before play of the hand began. Its major difference as compared to other Whist variants is that, instead of trump 
                    being decided by the highest bidder or at random, the Spade suit always trumps, hence the name. </p>
                <ul>
                <h4><span class=""text-muted text-cente");
            WriteLiteral(@"r"">Cards</span></h4>
                <p>A standard pack of 52 cards is used. The cards, in each suit, 
                    rank from highest to lowest: A, K, Q, J, 10, 9, 8, 7, 6, 5, 4, 3, 2. </p>
                <h4><span class=""text-muted text-center"">The Deal</span></h4>
                <p>
                    The entire deck is then dealt face-down one card at a time in clockwise order 
                    (with four players, each player should receive 13 cards).
                    The players then pick up their cards, verify the correct count of the cards.
                </p>
                <h4><span class=""text-muted text-center"">Gameplay</span></h4>
                <p>Each hand consists of a number of tricks; a four-handed game consists of thirteen tricks using all fifty-two cards. 
                    The player on the dealer's left makes the opening lead by playing a single card of their choice. 
                    Players in clockwise fashion then play cards of their choice. They mus");
            WriteLiteral(@"t follow suit if possible; 
                    otherwise they may play any card, including a trump spade. Once a card has left the hand of a player, 
                    it stands and cannot be retrieved. </p>
                <p>The trick is won or taken by the player who played the highest card of the led suit; if trumps were played, 
                    the highest trump card wins. The player who wins the trick gathers the cards up into a face-down arrangement 
                    that allows players to count the number of tricks taken. The player who wins any given trick leads the next. 
                    Play continues until all players have exhausted their hands, which should occur on the same (last) trick. 
                    Otherwise, it is declared a misdeal. </p>
                    <li><strong>Team:</strong> Information about the Team, Fabio, Roman, Mauricio</li>
                    <li><strong>Contact:</strong> Links to GH, LI ??</li>
                    <li><strong>Version:</strong>");
            WriteLiteral(" 0.0.2</li>\r\n                </ul>\r\n                <button type=\"button\" class=\"btn btn-primary md-close mt-3\" data-dismiss=\"modal\">Close</button>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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