#pragma checksum "G:\Kursy\C#\Kursy-ASP.NET-Communicator\ChatMe\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c4bc148c5a35664e529c768f257591505779640a"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4bc148c5a35664e529c768f257591505779640a", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"388b5af9057635ec6ea0fb34a8322d8d12051d35", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("navbar-brand"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/signalr/dist/browser/signalr.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/chat.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(";</script>\r\n\r\n<header>\r\n    <nav class=\"navbar navbar-expand-sm navbar-toggleable-sm navbar-light box-shadow mb-3\">\r\n        <div class=\"nav-container\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c4bc148c5a35664e529c768f257591505779640a5970", async() => {
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


            <div class=""input-group userSearchInputGroup"">
                <input id=""NavUserSearchInput"" type=""text"" class=""form-control"" placeholder=""Wyszukaj osobę..."" aria-label=""Wyszukaj osobę..."" aria-describedby=""basic-addon2"" oninput=""doSearch()"">
                <div class=""input-group-append searchInputAppend"">
                    <button id=""showSearch"" class=""btn"" onclick=""showSearch()"" type=""button""><i class=""fa-solid fa-magnifying-glass""></i></button>
                </div>
            </div>

            <div class=""nav-user"">
                <div class=""avatar unreadedAvatar nav-user-avatar"">
                    <span>");
#nullable restore
#line 26 "G:\Kursy\C#\Kursy-ASP.NET-Communicator\ChatMe\Views\Home\Index.cshtml"
                     Write(user.shortcut);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                </div>\r\n                <div class=\"nav-user-info\">\r\n                    <h6 id=\"Welcome\">Dobry wieczór</h6>\r\n");
#nullable restore
#line 30 "G:\Kursy\C#\Kursy-ASP.NET-Communicator\ChatMe\Views\Home\Index.cshtml"
                     if (user.displayName.Length > 2)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <h5 id=\"myDisplayName\">");
#nullable restore
#line 32 "G:\Kursy\C#\Kursy-ASP.NET-Communicator\ChatMe\Views\Home\Index.cshtml"
                                          Write(user.displayName);

#line default
#line hidden
#nullable disable
            WriteLiteral("!</h5>\r\n");
#nullable restore
#line 33 "G:\Kursy\C#\Kursy-ASP.NET-Communicator\ChatMe\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <h6 id=\"MyUsername\">");
#nullable restore
#line 34 "G:\Kursy\C#\Kursy-ASP.NET-Communicator\ChatMe\Views\Home\Index.cshtml"
                                   Write(user.username);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h6>
                </div>
                <div class=""dropdown-content"">
                    <p>Hello World!</p>
                </div>
            </div>



        </div>
    </nav>
</header>
<div id=""searchView"">
    <div id=""searchViewContent"">
        <div id=""closeSearchBar"">
            <button id=""closeSearch"" class=""btn btn-outline-secondary"" onclick=""closeSearch()"" type=""button""><i class=""fa-regular fa-circle-xmark""></i></button>
        </div>

        <div class=""input-group mb-3 searchInputGroup"">
            <input id=""userSearchInput"" type=""text"" class=""form-control"" placeholder=""Wyszukaj osobę..."" aria-label=""Wyszukaj osobę..."" aria-describedby=""basic-addon2"">
            <div class=""input-group-append searchInputAppend"">
                <i class=""fa-solid fa-magnifying-glass""></i>
            </div>
        </div>

        <div class=""searchListDropdown"">
            <ul id=""searchList""></ul>
        </div>
    </div>
</div>
<div id=""appWindow"">
    <div clas");
            WriteLiteral("s=\"row appRow\">\r\n        <div id=\"conversationWindow\" class=\"col-3\">\r\n            <ul id=\"chatsList\">\r\n                <!-- TODO: Zmienić, że jak dzisiaj to godzina, jak nie to data -->\r\n");
#nullable restore
#line 69 "G:\Kursy\C#\Kursy-ASP.NET-Communicator\ChatMe\Views\Home\Index.cshtml"
                 foreach (FrontChatItem item in Model.listOfConversations)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <a");
            BeginWriteAttribute("href", " href=\"", 2879, "\"", 2942, 2);
            WriteAttributeValue("", 2886, "?conversation=", 2886, 14, true);
#nullable restore
#line 71 "G:\Kursy\C#\Kursy-ASP.NET-Communicator\ChatMe\Views\Home\Index.cshtml"
WriteAttributeValue("", 2900, Html.DisplayFor(modelItem => item.chatID), 2900, 42, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <li class=\"conversationItem\">\r\n");
#nullable restore
#line 73 "G:\Kursy\C#\Kursy-ASP.NET-Communicator\ChatMe\Views\Home\Index.cshtml"
                         if (item.readed)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"avatar\">\r\n                                <span>");
#nullable restore
#line 76 "G:\Kursy\C#\Kursy-ASP.NET-Communicator\ChatMe\Views\Home\Index.cshtml"
                                 Write(Html.DisplayFor(modelItem => item.shortcut));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            </div>\r\n");
#nullable restore
#line 78 "G:\Kursy\C#\Kursy-ASP.NET-Communicator\ChatMe\Views\Home\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"avatar unreadedAvatar\">\r\n                                <span>");
#nullable restore
#line 82 "G:\Kursy\C#\Kursy-ASP.NET-Communicator\ChatMe\Views\Home\Index.cshtml"
                                 Write(Html.DisplayFor(modelItem => item.shortcut));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            </div>\r\n");
#nullable restore
#line 84 "G:\Kursy\C#\Kursy-ASP.NET-Communicator\ChatMe\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"conversationData\">\r\n                            <div class=\"conversationName\">");
#nullable restore
#line 86 "G:\Kursy\C#\Kursy-ASP.NET-Communicator\ChatMe\Views\Home\Index.cshtml"
                                                     Write(Html.DisplayFor(modelItem => item.chatName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 87 "G:\Kursy\C#\Kursy-ASP.NET-Communicator\ChatMe\Views\Home\Index.cshtml"
                             if (item.readed)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"conversationLastMessage\">");
#nullable restore
#line 89 "G:\Kursy\C#\Kursy-ASP.NET-Communicator\ChatMe\Views\Home\Index.cshtml"
                                                                Write(Html.DisplayFor(modelItem => item.lastMessage));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 90 "G:\Kursy\C#\Kursy-ASP.NET-Communicator\ChatMe\Views\Home\Index.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"conversationLastMessage messageUnreaded\">");
#nullable restore
#line 93 "G:\Kursy\C#\Kursy-ASP.NET-Communicator\ChatMe\Views\Home\Index.cshtml"
                                                                                Write(Html.DisplayFor(modelItem => item.lastMessage));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 94 "G:\Kursy\C#\Kursy-ASP.NET-Communicator\ChatMe\Views\Home\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"conversationTime\">\r\n                                ");
#nullable restore
#line 96 "G:\Kursy\C#\Kursy-ASP.NET-Communicator\ChatMe\Views\Home\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.lastMessageTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n\r\n                    </li>\r\n                    </a>\r\n");
#nullable restore
#line 102 "G:\Kursy\C#\Kursy-ASP.NET-Communicator\ChatMe\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </ul>\r\n        </div>\r\n        <div id=\"rightPane\" class=\"col-9\">\r\n            <div id=\"chatWindow\">\r\n                <ul id=\"messagesList\">\r\n");
#nullable restore
#line 108 "G:\Kursy\C#\Kursy-ASP.NET-Communicator\ChatMe\Views\Home\Index.cshtml"
                     foreach (FrontMessage item in Model.listOfMessages)
                    {

                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 111 "G:\Kursy\C#\Kursy-ASP.NET-Communicator\ChatMe\Views\Home\Index.cshtml"
                         if (item.isMyMessage)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <li class=""myLi"">
                                <div class=""message-bubble my-message"">
                                    <span class=""message-bubble-details"">
                                        <div class=""message-bubble-avatar"">
                                            ");
#nullable restore
#line 117 "G:\Kursy\C#\Kursy-ASP.NET-Communicator\ChatMe\Views\Home\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.shortcut));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </div>\r\n                                        <div class=\"message-bubble-author\">\r\n                                            ");
#nullable restore
#line 120 "G:\Kursy\C#\Kursy-ASP.NET-Communicator\ChatMe\Views\Home\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.creatorName));

#line default
#line hidden
#nullable disable
            WriteLiteral(" (");
#nullable restore
#line 120 "G:\Kursy\C#\Kursy-ASP.NET-Communicator\ChatMe\Views\Home\Index.cshtml"
                                                                                        Write(Html.DisplayFor(modelItem => item.username));

#line default
#line hidden
#nullable disable
            WriteLiteral(")\r\n                                        </div>\r\n                                        <div class=\"message-bubble-createdTime\">\r\n                                            ");
#nullable restore
#line 123 "G:\Kursy\C#\Kursy-ASP.NET-Communicator\ChatMe\Views\Home\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.createdTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </div>\r\n                                    </span>\r\n                                    <div class=\"message-bubble-content\">\r\n                                        ");
#nullable restore
#line 127 "G:\Kursy\C#\Kursy-ASP.NET-Communicator\ChatMe\Views\Home\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.messageContent));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </div>\r\n\r\n                                </div>\r\n");
#nullable restore
#line 131 "G:\Kursy\C#\Kursy-ASP.NET-Communicator\ChatMe\Views\Home\Index.cshtml"
                                 foreach (Readed readed in item.readedBy)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div class=\"message-bubble-readed myItem\">\r\n                                        ");
#nullable restore
#line 134 "G:\Kursy\C#\Kursy-ASP.NET-Communicator\ChatMe\Views\Home\Index.cshtml"
                                   Write(Html.DisplayFor(item => usersInConversation.FirstOrDefault(usr => usr.myID == readed.userID).shortcut));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        <span class=\"mymessage-bubble-readed-details\">\r\n\r\n                                            <div class=\"message-bubble-avatar\">\r\n                                                ");
#nullable restore
#line 138 "G:\Kursy\C#\Kursy-ASP.NET-Communicator\ChatMe\Views\Home\Index.cshtml"
                                           Write(Html.DisplayFor(item => usersInConversation.FirstOrDefault(usr => usr.myID == readed.userID).shortcut));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </div>\r\n                                            <div class=\"message-bubble-author\">\r\n                                                ");
#nullable restore
#line 141 "G:\Kursy\C#\Kursy-ASP.NET-Communicator\ChatMe\Views\Home\Index.cshtml"
                                           Write(Html.DisplayFor(item => usersInConversation.FirstOrDefault(usr => usr.myID == readed.userID).displayName));

#line default
#line hidden
#nullable disable
            WriteLiteral(" (");
#nullable restore
#line 141 "G:\Kursy\C#\Kursy-ASP.NET-Communicator\ChatMe\Views\Home\Index.cshtml"
                                                                                                                                                       Write(Html.DisplayFor(item => usersInConversation.FirstOrDefault(usr => usr.myID == readed.userID).username));

#line default
#line hidden
#nullable disable
            WriteLiteral(")\r\n                                            </div>\r\n                                            <div class=\"message-bubble-readedTime\">\r\n                                                readed<br />\r\n                                                ");
#nullable restore
#line 145 "G:\Kursy\C#\Kursy-ASP.NET-Communicator\ChatMe\Views\Home\Index.cshtml"
                                           Write(Html.DisplayFor(item => readed.readTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </div>\r\n                                        </span>\r\n                                    </div>\r\n");
#nullable restore
#line 149 "G:\Kursy\C#\Kursy-ASP.NET-Communicator\ChatMe\Views\Home\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n                            </li>\r\n");
#nullable restore
#line 154 "G:\Kursy\C#\Kursy-ASP.NET-Communicator\ChatMe\Views\Home\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <li class=""someoneLi"">
                                <div class=""message-bubble"">
                                    <span class=""message-bubble-details"">
                                        <div class=""message-bubble-avatar"">
                                            ");
#nullable restore
#line 161 "G:\Kursy\C#\Kursy-ASP.NET-Communicator\ChatMe\Views\Home\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.shortcut));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </div>\r\n                                        <div class=\"message-bubble-author\">\r\n                                            ");
#nullable restore
#line 164 "G:\Kursy\C#\Kursy-ASP.NET-Communicator\ChatMe\Views\Home\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.creatorName));

#line default
#line hidden
#nullable disable
            WriteLiteral(" (");
#nullable restore
#line 164 "G:\Kursy\C#\Kursy-ASP.NET-Communicator\ChatMe\Views\Home\Index.cshtml"
                                                                                        Write(Html.DisplayFor(modelItem => item.username));

#line default
#line hidden
#nullable disable
            WriteLiteral(")\r\n                                        </div>\r\n                                        <div class=\"message-bubble-createdTime\">\r\n                                            ");
#nullable restore
#line 167 "G:\Kursy\C#\Kursy-ASP.NET-Communicator\ChatMe\Views\Home\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.createdTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </div>\r\n                                    </span>\r\n\r\n                                    <div class=\"message-bubble-content\">\r\n                                        ");
#nullable restore
#line 172 "G:\Kursy\C#\Kursy-ASP.NET-Communicator\ChatMe\Views\Home\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.messageContent));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </div>\r\n\r\n                                </div>\r\n");
#nullable restore
#line 176 "G:\Kursy\C#\Kursy-ASP.NET-Communicator\ChatMe\Views\Home\Index.cshtml"
                                 foreach (Readed readed in item.readedBy)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div class=\"message-bubble-readed someoneItem\">\r\n                                        ");
#nullable restore
#line 179 "G:\Kursy\C#\Kursy-ASP.NET-Communicator\ChatMe\Views\Home\Index.cshtml"
                                   Write(Html.DisplayFor(item => usersInConversation.FirstOrDefault(usr => usr.myID == readed.userID).shortcut));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        <span class=\"message-bubble-readed-details\">\r\n                                            <div class=\"message-bubble-avatar\">\r\n                                                ");
#nullable restore
#line 182 "G:\Kursy\C#\Kursy-ASP.NET-Communicator\ChatMe\Views\Home\Index.cshtml"
                                           Write(Html.DisplayFor(item => usersInConversation.FirstOrDefault(usr => usr.myID == readed.userID).shortcut));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </div>\r\n                                            <div class=\"message-bubble-author\">\r\n                                                ");
#nullable restore
#line 185 "G:\Kursy\C#\Kursy-ASP.NET-Communicator\ChatMe\Views\Home\Index.cshtml"
                                           Write(Html.DisplayFor(item => usersInConversation.FirstOrDefault(usr => usr.myID == readed.userID).displayName));

#line default
#line hidden
#nullable disable
            WriteLiteral(" (");
#nullable restore
#line 185 "G:\Kursy\C#\Kursy-ASP.NET-Communicator\ChatMe\Views\Home\Index.cshtml"
                                                                                                                                                       Write(Html.DisplayFor(item => usersInConversation.FirstOrDefault(usr => usr.myID == readed.userID).username));

#line default
#line hidden
#nullable disable
            WriteLiteral(")\r\n                                            </div>\r\n                                            <div class=\"message-bubble-readedTime\">\r\n                                                readed<br />\r\n                                                ");
#nullable restore
#line 189 "G:\Kursy\C#\Kursy-ASP.NET-Communicator\ChatMe\Views\Home\Index.cshtml"
                                           Write(Html.DisplayFor(item => readed.readTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </div>\r\n                                            <span />\r\n                                    </div>\r\n");
#nullable restore
#line 193 "G:\Kursy\C#\Kursy-ASP.NET-Communicator\ChatMe\Views\Home\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </li>\r\n");
#nullable restore
#line 195 "G:\Kursy\C#\Kursy-ASP.NET-Communicator\ChatMe\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 195 "G:\Kursy\C#\Kursy-ASP.NET-Communicator\ChatMe\Views\Home\Index.cshtml"
                         



                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </ul>

            </div>
            <div id=""messageInputBar"" class=""messageInputBar"">
                <div class=""input-group messageInputGroup"">
                    <input id=""messageInput"" type=""text"" class=""form-control"" placeholder=""Napisz wiadomość..."" aria-label=""Napisz wiadomość..."" aria-describedby=""basic-addon2"">
                    <div class=""input-group-append messageInputAppend"">
                        <button id=""sendButton"" class=""btn btn-outline-secondary"" type=""button""><i class=""fa-regular fa-paper-plane""></i></button>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>



");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c4bc148c5a35664e529c768f257591505779640a29564", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c4bc148c5a35664e529c768f257591505779640a30604", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
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
