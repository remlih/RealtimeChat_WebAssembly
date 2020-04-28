#pragma checksum "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\SignalR\RealtimeChat_WebAssembly\WSDTChat\Pages\Chat.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "77381c9f5038c131e1f5e83f1464ffcada986c4f"
// <auto-generated/>
#pragma warning disable 1591
namespace WSDTChat.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\SignalR\RealtimeChat_WebAssembly\WSDTChat\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\SignalR\RealtimeChat_WebAssembly\WSDTChat\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\SignalR\RealtimeChat_WebAssembly\WSDTChat\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\SignalR\RealtimeChat_WebAssembly\WSDTChat\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\SignalR\RealtimeChat_WebAssembly\WSDTChat\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\SignalR\RealtimeChat_WebAssembly\WSDTChat\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\SignalR\RealtimeChat_WebAssembly\WSDTChat\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\SignalR\RealtimeChat_WebAssembly\WSDTChat\_Imports.razor"
using WSDTChat;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\SignalR\RealtimeChat_WebAssembly\WSDTChat\_Imports.razor"
using WSDTChat.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\SignalR\RealtimeChat_WebAssembly\WSDTChat\Pages\Chat.razor"
using WSDTChat.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\SignalR\RealtimeChat_WebAssembly\WSDTChat\Pages\Chat.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\SignalR\RealtimeChat_WebAssembly\WSDTChat\Pages\Chat.razor"
using Microsoft.AspNetCore.SignalR.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\SignalR\RealtimeChat_WebAssembly\WSDTChat\Pages\Chat.razor"
using WSDTChat.Hubs.HubEvent;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\SignalR\RealtimeChat_WebAssembly\WSDTChat\Pages\Chat.razor"
using WSDTChat.Domain;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/chat")]
    public partial class Chat : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card");
            __builder.AddAttribute(2, "style", "margin:15px;");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "card-header");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.AddMarkupContent(7, "<h5>Live-Chat</h5>\r\n        ");
            __builder.OpenElement(8, "h6");
            __builder.AddAttribute(9, "class", "card-subtitle mb-2 text-muted");
            __builder.AddMarkupContent(10, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(11);
            __builder.AddAttribute(12, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddContent(13, "You are logged in");
            }
            ));
            __builder.AddAttribute(14, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddContent(15, "Log in to access all features");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(16, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n\r\n    ");
            __builder.OpenElement(19, "ul");
            __builder.AddAttribute(20, "id", "messagesList");
            __builder.AddAttribute(21, "class", "list-group list-group-flush");
            __builder.AddMarkupContent(22, "\r\n");
#nullable restore
#line 25 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\SignalR\RealtimeChat_WebAssembly\WSDTChat\Pages\Chat.razor"
         foreach (var UserMessage in ChatService.AllMessages)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(23, "            ");
            __builder.OpenElement(24, "li");
            __builder.AddAttribute(25, "class", "list-group-item");
            __builder.AddMarkupContent(26, "\r\n                ");
            __builder.OpenElement(27, "strong");
            __builder.AddContent(28, 
#nullable restore
#line 28 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\SignalR\RealtimeChat_WebAssembly\WSDTChat\Pages\Chat.razor"
                         UserMessage.User.EMail

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n");
#nullable restore
#line 29 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\SignalR\RealtimeChat_WebAssembly\WSDTChat\Pages\Chat.razor"
                 if (UserMessage.User.IsGuest)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(30, "                    ");
            __builder.AddMarkupContent(31, "<span class=\"badge badge-pill badge-dark\">Guest</span>\r\n");
#nullable restore
#line 32 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\SignalR\RealtimeChat_WebAssembly\WSDTChat\Pages\Chat.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(32, "                ");
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "style", "font-size:small;");
            __builder.AddMarkupContent(35, "\r\n");
#nullable restore
#line 34 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\SignalR\RealtimeChat_WebAssembly\WSDTChat\Pages\Chat.razor"
                     foreach (var Submsg in UserMessage.Messages)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(36, "                        ");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "animated lightSpeedIn");
            __builder.AddContent(39, 
#nullable restore
#line 36 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\SignalR\RealtimeChat_WebAssembly\WSDTChat\Pages\Chat.razor"
                                                            Submsg

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n");
#nullable restore
#line 37 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\SignalR\RealtimeChat_WebAssembly\WSDTChat\Pages\Chat.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(41, "                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n");
#nullable restore
#line 40 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\SignalR\RealtimeChat_WebAssembly\WSDTChat\Pages\Chat.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(44, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n    ");
            __builder.OpenElement(46, "div");
            __builder.AddAttribute(47, "class", "card-body");
            __builder.AddMarkupContent(48, "\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(49);
            __builder.AddAttribute(50, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 43 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\SignalR\RealtimeChat_WebAssembly\WSDTChat\Pages\Chat.razor"
                          ChatService.ChatForm

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(51, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 43 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\SignalR\RealtimeChat_WebAssembly\WSDTChat\Pages\Chat.razor"
                                                                                     ChatService.Send

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(52, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((formContext) => (__builder2) => {
                __builder2.AddMarkupContent(53, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(54);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(55, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(56);
                __builder2.AddAttribute(57, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder3) => {
                    __builder3.AddMarkupContent(58, "\r\n                    ");
                    __builder3.OpenElement(59, "div");
                    __builder3.AddAttribute(60, "class", "input-group" + " mb-3" + " " + (
#nullable restore
#line 47 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\SignalR\RealtimeChat_WebAssembly\WSDTChat\Pages\Chat.razor"
                                                   ChatService.HasSentMsg ? "animated fadeOut":""

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddMarkupContent(61, "\r\n                        ");
                    __builder3.AddMarkupContent(62, "<div class=\"input-group-prepend\">\r\n                            <span class=\"input-group-text\" id=\"addon-mail\">&#x00040;</span>\r\n                        </div>\r\n                        ");
                    __builder3.OpenElement(63, "input");
                    __builder3.AddAttribute(64, "type", "text");
                    __builder3.AddAttribute(65, "class", "form-control");
                    __builder3.AddAttribute(66, "placeholder", "E-Mail");
                    __builder3.AddAttribute(67, "aria-label", "E-Mail");
                    __builder3.AddAttribute(68, "aria-describedby", "addon-inputmail");
                    __builder3.AddAttribute(69, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 51 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\SignalR\RealtimeChat_WebAssembly\WSDTChat\Pages\Chat.razor"
                                                                                                                                                         ChatService.ChatForm.CurrentUser.EMail

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(70, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => ChatService.ChatForm.CurrentUser.EMail = __value, ChatService.ChatForm.CurrentUser.EMail));
                    __builder3.SetUpdatesAttributeName("value");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(71, "\r\n                    ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(72, "\r\n                    ");
                    __Blazor.WSDTChat.Pages.Chat.TypeInference.CreateValidationMessage_0(__builder3, 73, 74, 
#nullable restore
#line 53 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\SignalR\RealtimeChat_WebAssembly\WSDTChat\Pages\Chat.razor"
                                              () => ChatService.ChatForm.CurrentUser.EMail

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddMarkupContent(75, "\r\n                ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(76, "\r\n\r\n            ");
                __builder2.OpenElement(77, "div");
                __builder2.AddAttribute(78, "class", "input-group mb-3");
                __builder2.AddMarkupContent(79, "\r\n                ");
                __builder2.AddMarkupContent(80, "<div class=\"input-group-prepend\">\r\n                    <span class=\"input-group-text\" id=\"addon-msg\">&#x2709;</span>\r\n                </div>\r\n                ");
                __builder2.OpenElement(81, "input");
                __builder2.AddAttribute(82, "type", "text");
                __builder2.AddAttribute(83, "class", "form-control");
                __builder2.AddAttribute(84, "placeholder", "Message");
                __builder2.AddAttribute(85, "aria-label", "Message");
                __builder2.AddAttribute(86, "aria-describedby", "addon-inputmsg");
                __builder2.AddAttribute(87, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 61 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\SignalR\RealtimeChat_WebAssembly\WSDTChat\Pages\Chat.razor"
                                                                                                                                                  ChatService.ChatForm.MessageInput

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(88, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => ChatService.ChatForm.MessageInput = __value, ChatService.ChatForm.MessageInput));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(89, "\r\n                ");
                __builder2.OpenElement(90, "div");
                __builder2.AddAttribute(91, "class", "input-group-append");
                __builder2.AddMarkupContent(92, "\r\n                    ");
                __builder2.OpenElement(93, "button");
                __builder2.AddAttribute(94, "type", "submit");
                __builder2.AddAttribute(95, "class", "btn btn-outline-info text-center");
                __builder2.AddAttribute(96, "disabled", 
#nullable restore
#line 63 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\SignalR\RealtimeChat_WebAssembly\WSDTChat\Pages\Chat.razor"
                                                                                               !ChatService.IsConnected()

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(97, "Send");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(98, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(99, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(100, "\r\n            ");
                __Blazor.WSDTChat.Pages.Chat.TypeInference.CreateValidationMessage_1(__builder2, 101, 102, 
#nullable restore
#line 66 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\SignalR\RealtimeChat_WebAssembly\WSDTChat\Pages\Chat.razor"
                                      () => ChatService.ChatForm.MessageInput

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(103, "\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(104, "\r\n\r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(105, "\r\n    ");
            __builder.AddMarkupContent(106, "<div class=\"card-footer text-muted\">\r\n        <small>More on <a href=\"https://github.com/wsdt\" title=\"Github - WSDT\">Github/WSDT</a>.</small>\r\n    </div>\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 76 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\SignalR\RealtimeChat_WebAssembly\WSDTChat\Pages\Chat.razor"
       
    [CascadingParameter] Task<AuthenticationState> AuthenticationStateTask { get; set; }

    protected override async Task OnInitializedAsync()
    {
        ChatService.HubConnection = new HubConnectionBuilder()
            .WithUrl(NavigationManager.ToAbsoluteUri(ICommonRoutes.CHAT_HUB))
            .Build();


        ChatService.HubConnection.On<string, string>(IPublic.RECEIVE_MSG, (user, message) =>
        {
            var chatUser = JsonSerializer.Deserialize<ChatUser>(user);
            var lastMessage = ChatService.AllMessages.LastOrDefault();
            if (lastMessage != null && lastMessage.User.Equals(chatUser))
            {
            // If last message has been written by the same user, add it to the last chatMsg-obj
            lastMessage.Messages.Add(message);
            }
            else
            {
            // other user typed msg
            ChatService.AllMessages.Add(
                        new ChatMsg(chatUser, new List<string> { message })
                    );
            }

            StateHasChanged();
        });

        await ChatService.HubConnection.StartAsync();
        await SetUsernameIfLoggedIn();
    }

    public async Task SetUsernameIfLoggedIn()
    {
        var authState = await AuthenticationStateTask;
        var user = authState.User;
        if (user.Identity.IsAuthenticated)
        {
            ChatService.ChatForm.CurrentUser.EMail = user.Identity.Name;
        }
        ChatService.ChatForm.CurrentUser.IsGuest = !user.Identity.IsAuthenticated;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private WSDTChat.Services.IChatService ChatService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
namespace __Blazor.WSDTChat.Pages.Chat
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591