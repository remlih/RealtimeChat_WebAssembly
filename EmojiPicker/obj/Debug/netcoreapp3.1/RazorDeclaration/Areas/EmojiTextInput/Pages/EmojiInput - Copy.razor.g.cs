#pragma checksum "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\SignalR\RealtimeChat_WebAssembly\EmojiPicker\Areas\EmojiTextInput\Pages\EmojiInput - Copy.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "010c97329dfcc79c0994a840d00adf0795ee451c"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace EmojiPicker.Areas.EmojiTextInput.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\SignalR\RealtimeChat_WebAssembly\EmojiPicker\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
    public partial class EmojiInput___Copy : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 72 "C:\Users\WSDT\Desktop\C#_.NET\KevinRiedl\SignalR\RealtimeChat_WebAssembly\EmojiPicker\Areas\EmojiTextInput\Pages\EmojiInput - Copy.razor"
       
    public string Message { get; set; }

    [Parameter]
    public string Placeholder { get; set; }

    [Parameter]
    public string AddonPrepend { get; set; }

    [Parameter]
    public bool ShowSubmit { get; set; } = true;

    [Parameter]
    public bool IsSubmitDisabled { get; set; } = false;

    protected void AddEmoji(string emoji) => Message += emoji;


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591