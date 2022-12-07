#pragma checksum "G:\Kursy\C#\Kursy-ASP.NET-Communicator\ChatMe\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c1a4237648bdfd6e839b173a7a4e12b85892f52e"
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
#line 1 "G:\Kursy\C#\Kursy-ASP.NET-Communicator\ChatMe\Views\_ViewImports.cshtml"
using ChatMe;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\Kursy\C#\Kursy-ASP.NET-Communicator\ChatMe\Views\_ViewImports.cshtml"
using ChatMe.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1a4237648bdfd6e839b173a7a4e12b85892f52e", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"388b5af9057635ec6ea0fb34a8322d8d12051d35", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("navbar-brand"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link text-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Privacy", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Messages", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/signalr/dist/browser/signalr.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/chat.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "G:\Kursy\C#\Kursy-ASP.NET-Communicator\ChatMe\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";
    CurrentUserData user = Model.currentUserData as CurrentUserData;
    List<CurrentUserData> usersInConversation = Model.usersInConversation as List<CurrentUserData>;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<script>let myID = ");
#nullable restore
#line 9 "G:\Kursy\C#\Kursy-ASP.NET-Communicator\ChatMe\Views\Home\Index.cshtml"
              Write(user.myID);

#line default
#line hidden
#nullable disable
            WriteLiteral(";</script>\r\n\r\n<header>\r\n    <nav class=\"navbar navbar-expand-sm navbar-toggleable-sm navbar-light bg-white border-bottom box-shadow mb-3\">\r\n        <div class=\"container\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c1a4237648bdfd6e839b173a7a4e12b85892f52e6956", async() => {
                WriteLiteral("ChatMe");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target="".navbar-collapse"" aria-controls=""navbarSupportedContent""
                    aria-expanded=""false"" aria-label=""Toggle navigation"">
                <span class=""navbar-toggler-icon""></span>
            </button>
            <div class=""navbar-collapse collapse d-sm-inline-flex flex-sm-row-reverse"">
                <ul class=""navbar-nav flex-grow-1"">
                    <li class=""nav-item"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c1a4237648bdfd6e839b173a7a4e12b85892f52e9138", async() => {
                WriteLiteral("Home");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </li>\r\n                    <li class=\"nav-item\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c1a4237648bdfd6e839b173a7a4e12b85892f52e10880", async() => {
                WriteLiteral("Privacy");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </li>\r\n                    <li class=\"nav-item\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c1a4237648bdfd6e839b173a7a4e12b85892f52e12626", async() => {
                WriteLiteral("Messages");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </li>\r\n                    <li class=\"nav-item\">\r\n                        <h4>Witaj ");
#nullable restore
#line 31 "G:\Kursy\C#\Kursy-ASP.NET-Communicator\ChatMe\Views\Home\Index.cshtml"
                             Write(user.displayName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"!</h4>
                    </li>
                    <li class=""nav-item"">
                        <input type=""text"" id=""userSearchInput"" />
                        <div class=""searchListDropdown"">
                            <ul id=""searchList""></ul>
                        </div>
                    </li>

                </ul>
            </div>
        </div>
    </nav>
</header>
<div id=""appWindow"">
    <div class=""row appRow"">
        <div id=""conversationWindow"" class=""col-3"">
            <ul id=""chatsList"">
                <!-- TODO: Zmienić, że jak dzisiaj to godzina, jak nie to data -->
");
#nullable restore
#line 50 "G:\Kursy\C#\Kursy-ASP.NET-Communicator\ChatMe\Views\Home\Index.cshtml"
                 foreach (FrontChatItem item in Model.listOfConversations)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <a");
            BeginWriteAttribute("href", " href=\"", 2398, "\"", 2461, 2);
            WriteAttributeValue("", 2405, "?conversation=", 2405, 14, true);
#nullable restore
#line 52 "G:\Kursy\C#\Kursy-ASP.NET-Communicator\ChatMe\Views\Home\Index.cshtml"
WriteAttributeValue("", 2419, Html.DisplayFor(modelItem => item.chatID), 2419, 42, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <li class=\"conversationItem\">\r\n");
#nullable restore
#line 54 "G:\Kursy\C#\Kursy-ASP.NET-Communicator\ChatMe\Views\Home\Index.cshtml"
                         if (item.readed)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"avatar\">\r\n                                <span>");
#nullable restore
#line 57 "G:\Kursy\C#\Kursy-ASP.NET-Communicator\ChatMe\Views\Home\Index.cshtml"
                                 Write(Html.DisplayFor(modelItem => item.shortcut));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            </div>\r\n");
#nullable restore
#line 59 "G:\Kursy\C#\Kursy-ASP.NET-Communicator\ChatMe\Views\Home\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"avatar unreadedAvatar\">\r\n                                <span>");
#nullable restore
#line 63 "G:\Kursy\C#\Kursy-ASP.NET-Communicator\ChatMe\Views\Home\Index.cshtml"
                                 Write(Html.DisplayFor(modelItem => item.shortcut));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            </div>\r\n");
#nullable restore
#line 65 "G:\Kursy\C#\Kursy-ASP.NET-Communicator\ChatMe\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"conversationData\">\r\n                            <div class=\"conversationName\">");
#nullable restore
#line 67 "G:\Kursy\C#\Kursy-ASP.NET-Communicator\ChatMe\Views\Home\Index.cshtml"
                                                     Write(Html.DisplayFor(modelItem => item.chatName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 68 "G:\Kursy\C#\Kursy-ASP.NET-Communicator\ChatMe\Views\Home\Index.cshtml"
                             if (item.readed)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"conversationLastMessage\">");
#nullable restore
#line 70 "G:\Kursy\C#\Kursy-ASP.NET-Communicator\ChatMe\Views\Home\Index.cshtml"
                                                                Write(Html.DisplayFor(modelItem => item.lastMessage));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 71 "G:\Kursy\C#\Kursy-ASP.NET-Communicator\ChatMe\Views\Home\Index.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"conversationLastMessage messageUnreaded\">");
#nullable restore
#line 74 "G:\Kursy\C#\Kursy-ASP.NET-Communicator\ChatMe\Views\Home\Index.cshtml"
                                                                                Write(Html.DisplayFor(modelItem => item.lastMessage));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 75 "G:\Kursy\C#\Kursy-ASP.NET-Communicator\ChatMe\Views\Home\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"conversationTime\">\r\n                                ");
#nullable restore
#line 77 "G:\Kursy\C#\Kursy-ASP.NET-Communicator\ChatMe\Views\Home\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.lastMessageTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n\r\n                    </li>\r\n                    </a>\r\n");
#nullable restore
#line 83 "G:\Kursy\C#\Kursy-ASP.NET-Communicator\ChatMe\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </ul>\r\n        </div>\r\n        <div id=\"rightPane\" class=\"col-9\">\r\n            <div id=\"chatWindow\">\r\n                <ul id=\"messagesList\">\r\n");
#nullable restore
#line 89 "G:\Kursy\C#\Kursy-ASP.NET-Communicator\ChatMe\Views\Home\Index.cshtml"
                     foreach (FrontMessage item in Model.listOfMessages)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li>\r\n");
#nullable restore
#line 92 "G:\Kursy\C#\Kursy-ASP.NET-Communicator\ChatMe\Views\Home\Index.cshtml"
                             if (item.isMyMessage)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"message-bubble my-message\">\r\n                                <div class=\"message-bubble-author\">\r\n                                    ");
#nullable restore
#line 96 "G:\Kursy\C#\Kursy-ASP.NET-Communicator\ChatMe\Views\Home\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.creatorName));

#line default
#line hidden
#nullable disable
            WriteLiteral(" (");
#nullable restore
#line 96 "G:\Kursy\C#\Kursy-ASP.NET-Communicator\ChatMe\Views\Home\Index.cshtml"
                                                                                Write(Html.DisplayFor(modelItem => item.username));

#line default
#line hidden
#nullable disable
            WriteLiteral(")\r\n                                </div>\r\n                                <div class=\"message-bubble-content\">\r\n                                    ");
#nullable restore
#line 99 "G:\Kursy\C#\Kursy-ASP.NET-Communicator\ChatMe\Views\Home\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.messageContent));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n                                <div class=\"message-bubble-createdTime\">\r\n                                    ");
#nullable restore
#line 102 "G:\Kursy\C#\Kursy-ASP.NET-Communicator\ChatMe\Views\Home\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.createdTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 105 "G:\Kursy\C#\Kursy-ASP.NET-Communicator\ChatMe\Views\Home\Index.cshtml"
                                     foreach (Readed readed in item.readedBy)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"message-bubble-readed\">\r\n                                    ");
#nullable restore
#line 108 "G:\Kursy\C#\Kursy-ASP.NET-Communicator\ChatMe\Views\Home\Index.cshtml"
                               Write(Html.DisplayFor(item => usersInConversation.FirstOrDefault(usr => usr.myID == readed.userID).shortcut));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    <span class=\"message-bubble-readed-details\">\r\n                                        ");
#nullable restore
#line 110 "G:\Kursy\C#\Kursy-ASP.NET-Communicator\ChatMe\Views\Home\Index.cshtml"
                                   Write(Html.DisplayFor(item => usersInConversation.FirstOrDefault(usr => usr.myID == readed.userID).displayName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        (");
#nullable restore
#line 111 "G:\Kursy\C#\Kursy-ASP.NET-Communicator\ChatMe\Views\Home\Index.cshtml"
                                    Write(Html.DisplayFor(item => usersInConversation.FirstOrDefault(usr => usr.myID == readed.userID).username));

#line default
#line hidden
#nullable disable
            WriteLiteral(")<br>\r\n                                        ");
#nullable restore
#line 112 "G:\Kursy\C#\Kursy-ASP.NET-Communicator\ChatMe\Views\Home\Index.cshtml"
                                   Write(Html.DisplayFor(item => readed.readTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </span>\r\n                                </div>\r\n");
#nullable restore
#line 115 "G:\Kursy\C#\Kursy-ASP.NET-Communicator\ChatMe\Views\Home\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 115 "G:\Kursy\C#\Kursy-ASP.NET-Communicator\ChatMe\Views\Home\Index.cshtml"
                                     



                                
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"message-bubble\">\r\n                            <div class=\"message-bubble-author\">\r\n                                ");
#nullable restore
#line 125 "G:\Kursy\C#\Kursy-ASP.NET-Communicator\ChatMe\Views\Home\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.creatorName));

#line default
#line hidden
#nullable disable
            WriteLiteral(" (");
#nullable restore
#line 125 "G:\Kursy\C#\Kursy-ASP.NET-Communicator\ChatMe\Views\Home\Index.cshtml"
                                                                            Write(Html.DisplayFor(modelItem => item.username));

#line default
#line hidden
#nullable disable
            WriteLiteral("):\r\n                            </div>\r\n                            <div class=\"message-bubble-content\">\r\n                                ");
#nullable restore
#line 128 "G:\Kursy\C#\Kursy-ASP.NET-Communicator\ChatMe\Views\Home\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.messageContent));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                            <div class=\"message-bubble-createdTime\">\r\n                                ");
#nullable restore
#line 131 "G:\Kursy\C#\Kursy-ASP.NET-Communicator\ChatMe\Views\Home\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.createdTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 134 "G:\Kursy\C#\Kursy-ASP.NET-Communicator\ChatMe\Views\Home\Index.cshtml"
                                     foreach (Readed readed in item.readedBy)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"message-bubble-readed\">\r\n                                    ");
#nullable restore
#line 137 "G:\Kursy\C#\Kursy-ASP.NET-Communicator\ChatMe\Views\Home\Index.cshtml"
                               Write(Html.DisplayFor(item => usersInConversation.FirstOrDefault(usr => usr.myID == readed.userID).shortcut));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    <span class=\"message-bubble-readed-details\">\r\n                                        ");
#nullable restore
#line 139 "G:\Kursy\C#\Kursy-ASP.NET-Communicator\ChatMe\Views\Home\Index.cshtml"
                                   Write(Html.DisplayFor(item => usersInConversation.FirstOrDefault(usr => usr.myID == readed.userID).displayName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        (");
#nullable restore
#line 140 "G:\Kursy\C#\Kursy-ASP.NET-Communicator\ChatMe\Views\Home\Index.cshtml"
                                    Write(Html.DisplayFor(item => usersInConversation.FirstOrDefault(usr => usr.myID == readed.userID).username));

#line default
#line hidden
#nullable disable
            WriteLiteral(")<br>\r\n                                        ");
#nullable restore
#line 141 "G:\Kursy\C#\Kursy-ASP.NET-Communicator\ChatMe\Views\Home\Index.cshtml"
                                   Write(Html.DisplayFor(item => readed.readTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    <span/>\r\n                                </div>\r\n");
#nullable restore
#line 144 "G:\Kursy\C#\Kursy-ASP.NET-Communicator\ChatMe\Views\Home\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 144 "G:\Kursy\C#\Kursy-ASP.NET-Communicator\ChatMe\Views\Home\Index.cshtml"
                                     
                                
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                        </li>\r\n");
#nullable restore
#line 150 "G:\Kursy\C#\Kursy-ASP.NET-Communicator\ChatMe\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </ul>

            </div>
            <div id=""messageInputBar"" class=""messageInputBar"">
                <div class=""input-group mb-3"">
                    <input id=""messageInput"" type=""text"" class=""form-control"" placeholder=""Napisz wiadomość..."" aria-label=""Napisz wiadomość..."" aria-describedby=""basic-addon2"">
                    <div class=""input-group-append"">
                        <button id=""sendButton"" class=""btn btn-outline-secondary"" type=""button"">Send Message</button>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>



");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c1a4237648bdfd6e839b173a7a4e12b85892f52e30312", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c1a4237648bdfd6e839b173a7a4e12b85892f52e31352", async() => {
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
            WriteLiteral("\r\n");
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
