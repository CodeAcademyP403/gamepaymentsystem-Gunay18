#pragma checksum "D:\Code Academy\ASP.NET\GamePaymentSystem\GamePaymentSystem\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ba5ff0ac7e5bd6c2fba87b0a54db1f1887a3ad4c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "D:\Code Academy\ASP.NET\GamePaymentSystem\GamePaymentSystem\Views\_ViewImports.cshtml"
using GamePaymentSystem.Models;

#line default
#line hidden
#line 2 "D:\Code Academy\ASP.NET\GamePaymentSystem\GamePaymentSystem\Views\_ViewImports.cshtml"
using GamePaymentSystem.Models.ViewModels;

#line default
#line hidden
#line 3 "D:\Code Academy\ASP.NET\GamePaymentSystem\GamePaymentSystem\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba5ff0ac7e5bd6c2fba87b0a54db1f1887a3ad4c", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94df11d7137c987e12c924eacef8618d86f0ec75", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Game>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("shortcut icon"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/images.crazygames.com/faviconedbd.png?auto=format,compress&amp;ch=DPR&amp;q=90&amp;cs=strip&amp;w=16"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("image/png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Payment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Transaction", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images.crazygames.com/facebooklikebuttonce9d0.png?auto=format,compress&amp;ch=DPR&amp;q=90&amp;cs=strip&amp;w=74"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "D:\Code Academy\ASP.NET\GamePaymentSystem\GamePaymentSystem\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(43, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(64, 101, true);
            WriteLiteral("\r\n\r\n<!DOCTYPE html>\r\n<html>\r\n\r\n<meta http-equiv=\"content-type\" content=\"text/html;charset=UTF-8\" />\r\n");
            EndContext();
            BeginContext(165, 1712, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "57a1a85955b040af83d3c37873666257", async() => {
                BeginContext(171, 108, true);
                WriteLiteral("\r\n\r\n    <script>addEventListener(\'error\', window.__e=function f(e){f.q=f.q||[];f.q.push(e)});</script>\r\n    ");
                EndContext();
                BeginContext(279, 155, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "50c1f63c2be6495c9041b310fa8a110d", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(434, 1436, true);
                WriteLiteral(@"
    <meta http-equiv=""Accept-CH"" content=""DPR"">
    <title>Crazy Games - Free Online Games on CrazyGames.com</title>
    <meta name=""description"" content=""Play free online games at CrazyGames, the best place to play high-quality browser games. We add new games every day. Have fun!"">
    <link rel=""preconnect"" href=""https://images.crazygames.com/"">
    <link href=""assets/css/new7212.css?v=1.55"" rel=""stylesheet"">

    <link rel='preconnect' href='http://files.crazygames.com/'>
    <link rel=""shortcut icon"" type=""image/png"" href=""data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAABAAAAAQCAYAAAAf8/9hAAAAJElEQVR4AWNgbD31Hx8GAkZ8eHgYMGoAQQV+Zf/x4WFhwKgBABzfg58BLs8eAAAAAElFTkSuQmCC"">
    <link rel=""canonical"" href=""index.html"" />
    <link rel=""alternate"" media=""only screen and (max-width: 640px)"" href=""https://m.crazygames.com/"" />

    <style>
        .async-hide {
            opacity: 0 !important
        }
        #login{
            background-color: white;
        }
    </style>
   
    <link");
                WriteLiteral(@" rel=""alternate"" hreflang=""en"" href=""index.html"" />
    <link rel=""alternate"" hreflang=""es"" href=""https://www.1001juegos.com/"" />
    <link rel=""alternate"" hreflang=""it"" href=""https://www.gioca.re/"" />
    <link rel=""alternate"" hreflang=""nl"" href=""https://www.speelspelletjes.nl/"" />
    <link rel=""alternate"" hreflang=""id"" href=""https://www.onlinegame.co.id/"" />
    <link rel=""next"" href=""2.html"" />
  
");
                EndContext();
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
            EndContext();
            BeginContext(1877, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1879, 8675, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fd60a28e84ba40ff941d6e6cf21ff2e1", async() => {
                BeginContext(1885, 367, true);
                WriteLiteral(@"
    <div id=""top"">
     
        <div id=""topMid"">
            <a href=""index.html"">
                <h2 id=""headerTop"">
                    <span class=""green"">C</span><span class=""yellow"">r</span><span class=""orange"">a</span><span class=""red"">z</span><span class=""purple"">y</span>Games
                </h2>
            </a>
            <div  id=""login""> ");
                EndContext();
                BeginContext(2252, 69, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9b5023d2253247f1a81a02bad3921c5e", async() => {
                    BeginContext(2299, 18, true);
                    WriteLiteral("<span>Login</span>");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2321, 742, true);
                WriteLiteral(@"
            </div>
        </div>
    </div>
    <div id=""rest"">
        <style type=""text/css"">
            #menu ul {
                width: 1128px;
            }
        </style>
        <div id=""menu"">
            <ul>
                <li>
                    <a href=""index.html"" class=""regularB"" id=""active"">
                        Home
                    </a>
                </li>
            </ul>
        </div>

        <div id=""main"" style=""text-align:center;"">
       
            <div class=""mainPart"" style=""padding:4px 5px 5px 5px;"">
                <div id=""games-container"">
                    <div id=""games-main-column"">
                     
                        <ul class=""games-ul"">

");
                EndContext();
#line 82 "D:\Code Academy\ASP.NET\GamePaymentSystem\GamePaymentSystem\Views\Home\Index.cshtml"
                             foreach (Game game in Model)
                            {

#line default
#line hidden
                BeginContext(3153, 149, true);
                WriteLiteral("                                <li>\r\n                                    <div class=\"tile\" data-game-slug=\"bullet-force-multiplayer\" data-image-src=");
                EndContext();
                BeginContext(3303, 14, false);
#line 85 "D:\Code Academy\ASP.NET\GamePaymentSystem\GamePaymentSystem\Views\Home\Index.cshtml"
                                                                                                          Write(game.PhotoPath);

#line default
#line hidden
                EndContext();
                BeginContext(3317, 43, true);
                WriteLiteral(">\r\n                                        ");
                EndContext();
                BeginContext(3360, 988, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "61814c0e202c430a86a12aae36834e3a", async() => {
                    BeginContext(3444, 129, true);
                    WriteLiteral("\r\n                                            <div class=\"image-container\">\r\n                                                <img");
                    EndContext();
                    BeginWriteAttribute("src", " src=", 3573, "", 3593, 1);
#line 88 "D:\Code Academy\ASP.NET\GamePaymentSystem\GamePaymentSystem\Views\Home\Index.cshtml"
WriteAttributeValue("", 3578, game.PhotoPath, 3578, 15, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginWriteAttribute("alt", " alt=", 3593, "", 3608, 1);
#line 88 "D:\Code Academy\ASP.NET\GamePaymentSystem\GamePaymentSystem\Views\Home\Index.cshtml"
WriteAttributeValue("", 3598, game.Name, 3598, 10, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(3608, 244, true);
                    WriteLiteral(" width=\"180\" height=\"111\" />\r\n                                                <div class=\"tileTitle\">\r\n                                                    <div class=\"tileTitleOverflow\">\r\n                                                        ");
                    EndContext();
                    BeginContext(3853, 9, false);
#line 91 "D:\Code Academy\ASP.NET\GamePaymentSystem\GamePaymentSystem\Views\Home\Index.cshtml"
                                                   Write(game.Name);

#line default
#line hidden
                    EndContext();
                    BeginContext(3862, 178, true);
                    WriteLiteral("\r\n                                                    </div>\r\n                                                    <span>\r\n                                                        ");
                    EndContext();
                    BeginContext(4041, 13, false);
#line 94 "D:\Code Academy\ASP.NET\GamePaymentSystem\GamePaymentSystem\Views\Home\Index.cshtml"
                                                   Write(game.MinPrice);

#line default
#line hidden
                    EndContext();
                    BeginContext(4054, 290, true);
                    WriteLiteral(@"
                                                    </span>
                                                    <div class=""clear""></div>
                                                </div>
                                            </div>
                                        ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 86 "D:\Code Academy\ASP.NET\GamePaymentSystem\GamePaymentSystem\Views\Home\Index.cshtml"
                                                                                                       WriteLiteral(game.Id);

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
                BeginContext(4348, 85, true);
                WriteLiteral("\r\n                                    </div>\r\n                                </li>\r\n");
                EndContext();
#line 102 "D:\Code Academy\ASP.NET\GamePaymentSystem\GamePaymentSystem\Views\Home\Index.cshtml"
                            }

#line default
#line hidden
                BeginContext(4464, 34, true);
                WriteLiteral("                            <li>\r\n");
                EndContext();
                BeginContext(5664, 2796, true);
                WriteLiteral(@"            </li>






                        </ul>
                    </div>
                </div>
                <div style=""line-height:24px;"">
                    <p class=""pagination""><strong>1</strong><a href=""2.html"">2</a><a href=""3.html"">3</a><a href=""4.html"">4</a><a href=""5.html"">5</a><a href=""6.html"">6</a><a href=""2.html"">&rsaquo;</a></p><div class=""clear""></div>
                    <div style=""line-height:24px;"">
                        <p><h2>Welcome to Crazy Games</h2><p>Our goal here at Crazy Games is to provide you with the best free online games on the Internet. We play a lot of games to manually select only the highest-quality games and try to add new games every day. We categorize our games into 11 categories, the most popular of which are driving, shooting, clicker, and .io. We started off as a driving games website, and have collected <a href=""c/driving.html"">about 1000 driving games</a> over the years. These games include games about <a href=""t/car.html"">cars</a>, <a hre");
                WriteLiteral(@"f=""t/bike.html"">bikes</a>, <a href=""t/monster-truck.html"">monster trucks</a>, and any other vehicles that you can think of. Later our <a href=""c/shooting.html"">shooting games</a> have taken off. This is primarily thanks to first person shooters such as <a href=""game/bullet-force-multiplayer.html"">Bullet Force</a>, <a href=""game/combat-reloaded.html"">Combat Reloaded</a>, and <a href=""game/pixel-warfare-5.html"">Pixel Warfare</a>. Besides these evergreen categories, we also focus on new genres such as <a href=""c/io.html"">.io games</a> and <a href=""c/clicker.html"">clicker games</a>. Both of these genres have become hugely popular, thanks to games like <a href=""game/zombsroyaleio.html"">ZombsRoyale.io</a>, <a href=""game/survivio.html"">Surviv.io</a>, <a href=""game/slitherio.html"">Slither.io</a>, Cookie Clicker, Doge Miner (1 and 2), and Enchanted Heroes. Great games often appear in series, and we do our best to collect all the games in particular series. Some great examples are <a href=""s/wheely.html"">Wheely</a>, <a");
                WriteLiteral(@" href=""s/moto-x3m.html"">Moto X3M</a>, Papa Louie, and the Combat games. But there are a lot more great games of which there are multiple editions! Our all time most played games are <a href=""game/run-3.html"">Run 3</a>, <a href=""game/slope.html"">Slope</a>, and <a href=""game/madalin-stunt-cars-2.html"">Madalin Stunt Cars 2</a>, make sure to check them out!</p><p>We do our best to make the site as fast and reliable as possible. If something is not working, or if there is anything you want to tell us, <a href=""contact.html"">reach out</a> and let us know! <br /></p>
                    </div>
                    <a href=""https://www.facebook.com/crazygamesofficial/"" target=""_blank"" rel=""nofollow noopener noreferrer"">
                        ");
                EndContext();
                BeginContext(8460, 126, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "256886aed61d4af7ae2cb064ad6329e2", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(8586, 1961, true);
                WriteLiteral(@"
                    </a><br />
                </div>
            </div>
            <div id=""f"">
                <a href=""index.html"">Home</a> |
                <a href=""about.html"">About</a> |
                <a href=""https://developer.crazygames.com/"" target=""_blank"">Developers</a> |
                <a rel=""nofollow"" href=""addtoyoursite.html"">Games for your Site</a> | <a href=""jobs.html"">Jobs</a> | <a href=""scholarship.html"">Scholarship</a> | <a rel=""nofollow"" href=""terms-and-conditions.html"">Terms of Service</a> |
                <a rel=""nofollow"" href=""privacy-policy.html"">Privacy</a> |
                <a rel=""nofollow"" href=""contact.html"">Contact</a>
                <p>
                    &copy; Copyright 2013 - 2018 CrazyGames.com - <a href=""https://plus.google.com/+Crazygames_com"" target=""_blank"" rel=""publisher"">Find us on Google Plus</a><br />
                    <span style=""font-size:10px;"">
                        CrazyGames.com is an initiative of Maxflow BVBA, Lei 33/402, 3000 Le");
                WriteLiteral(@"uven, Belgium.(VAT: BE 0550.758.377)
                    </span>
                </p><br />
            </div>
        </div>
    </div>
    <script data-cfasync=""true"" type=""text/javascript"">
            var jsGlobals = {
                search_url : '//www.crazygames.com/search_json'
            };
    </script>
    <script data-cfasync=""true"" src=""assets/js/common6138.js?v=0.102"" defer></script>
    <script>
    function init() {
        var imgDefer = document.getElementsByTagName('img');
        for (var i=0; i<imgDefer.length; i++) {
            if(imgDefer[i].getAttribute('data-src')) {
                imgDefer[i].setAttribute('src',imgDefer[i].getAttribute('data-src'));
            } } }
    window.addEventListener('load', init);
    </script>
    <script>
    segmentTrack(""ViewedGamesOverview"", {
      pageSlug: """",
      pageType: ""home"",
      pageNum: ""1"",
    });
    </script>
    
");
                EndContext();
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
            EndContext();
            BeginContext(10554, 15, true);
            WriteLiteral("\r\n\r\n</html>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Game>> Html { get; private set; }
    }
}
#pragma warning restore 1591
