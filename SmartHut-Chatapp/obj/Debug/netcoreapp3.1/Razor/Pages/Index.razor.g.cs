#pragma checksum "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\7, Webbapplikationer med Realtidskommunikation\Inlämning 8\SmartHut-Chatapp-Blazor\SmartHut-Chatapp\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d5ed262325f8e6d7296766904084632ae3a88ff5"
// <auto-generated/>
#pragma warning disable 1591
namespace SmartHut_Chatapp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\7, Webbapplikationer med Realtidskommunikation\Inlämning 8\SmartHut-Chatapp-Blazor\SmartHut-Chatapp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\7, Webbapplikationer med Realtidskommunikation\Inlämning 8\SmartHut-Chatapp-Blazor\SmartHut-Chatapp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\7, Webbapplikationer med Realtidskommunikation\Inlämning 8\SmartHut-Chatapp-Blazor\SmartHut-Chatapp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\7, Webbapplikationer med Realtidskommunikation\Inlämning 8\SmartHut-Chatapp-Blazor\SmartHut-Chatapp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\7, Webbapplikationer med Realtidskommunikation\Inlämning 8\SmartHut-Chatapp-Blazor\SmartHut-Chatapp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\7, Webbapplikationer med Realtidskommunikation\Inlämning 8\SmartHut-Chatapp-Blazor\SmartHut-Chatapp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\7, Webbapplikationer med Realtidskommunikation\Inlämning 8\SmartHut-Chatapp-Blazor\SmartHut-Chatapp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\7, Webbapplikationer med Realtidskommunikation\Inlämning 8\SmartHut-Chatapp-Blazor\SmartHut-Chatapp\_Imports.razor"
using SmartHut_Chatapp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\7, Webbapplikationer med Realtidskommunikation\Inlämning 8\SmartHut-Chatapp-Blazor\SmartHut-Chatapp\_Imports.razor"
using SmartHut_Chatapp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\7, Webbapplikationer med Realtidskommunikation\Inlämning 8\SmartHut-Chatapp-Blazor\SmartHut-Chatapp\Pages\Index.razor"
using Microsoft.AspNetCore.SignalR.Client;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>SmartHut Messenger</h1>\n<hr>\n\n\n");
#nullable restore
#line 9 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\7, Webbapplikationer med Realtidskommunikation\Inlämning 8\SmartHut-Chatapp-Blazor\SmartHut-Chatapp\Pages\Index.razor"
 if(!ifChatting) 
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.AddMarkupContent(2, "<p>Ange ditt namn</p>\n");
            __builder.AddContent(3, "    ");
            __builder.OpenElement(4, "input");
            __builder.AddAttribute(5, "type", "text");
            __builder.AddAttribute(6, "maxlength", "32");
            __builder.AddAttribute(7, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 13 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\7, Webbapplikationer med Realtidskommunikation\Inlämning 8\SmartHut-Chatapp-Blazor\SmartHut-Chatapp\Pages\Index.razor"
                                              userName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => userName = __value, userName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\n    ");
            __builder.OpenElement(10, "button");
            __builder.AddAttribute(11, "class", "btn btn-outline-success");
            __builder.AddAttribute(12, "type", "button");
            __builder.AddAttribute(13, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 14 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\7, Webbapplikationer med Realtidskommunikation\Inlämning 8\SmartHut-Chatapp-Blazor\SmartHut-Chatapp\Pages\Index.razor"
                                                                    Chat

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(14, "<span class=\"oi oi-chat\" aria-hidden=\"true\"></span>Anslut");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\n");
#nullable restore
#line 15 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\7, Webbapplikationer med Realtidskommunikation\Inlämning 8\SmartHut-Chatapp-Blazor\SmartHut-Chatapp\Pages\Index.razor"
     if(theMessage != null)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(16, "        ");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "invalid-feedback");
            __builder.AddContent(19, 
#nullable restore
#line 17 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\7, Webbapplikationer med Realtidskommunikation\Inlämning 8\SmartHut-Chatapp-Blazor\SmartHut-Chatapp\Pages\Index.razor"
                                       theMessage

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\n        ");
            __builder.OpenElement(21, "small");
            __builder.AddAttribute(22, "id", "emailhelp");
            __builder.AddAttribute(23, "class", "form-text text-muted");
            __builder.AddContent(24, 
#nullable restore
#line 18 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\7, Webbapplikationer med Realtidskommunikation\Inlämning 8\SmartHut-Chatapp-Blazor\SmartHut-Chatapp\Pages\Index.razor"
                                                            theMessage

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\n");
#nullable restore
#line 19 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\7, Webbapplikationer med Realtidskommunikation\Inlämning 8\SmartHut-Chatapp-Blazor\SmartHut-Chatapp\Pages\Index.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\7, Webbapplikationer med Realtidskommunikation\Inlämning 8\SmartHut-Chatapp-Blazor\SmartHut-Chatapp\Pages\Index.razor"
     
}

else 
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(26, "    ");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "alert alert-secondary mt-4");
            __builder.AddAttribute(29, "role", "alert");
            __builder.AddMarkupContent(30, "\n        <span class=\"oi oi-person mr-2\" aria-hidden=\"true\"></span>\n        ");
            __builder.OpenElement(31, "span");
            __builder.AddMarkupContent(32, "Du är ansluten som ");
            __builder.OpenElement(33, "b");
            __builder.AddContent(34, 
#nullable restore
#line 26 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\7, Webbapplikationer med Realtidskommunikation\Inlämning 8\SmartHut-Chatapp-Blazor\SmartHut-Chatapp\Pages\Index.razor"
                                     userName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\n        ");
            __builder.OpenElement(36, "button");
            __builder.AddAttribute(37, "class", "btn btn-sm btn-warning ml-md-auto");
            __builder.AddAttribute(38, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 27 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\7, Webbapplikationer med Realtidskommunikation\Inlämning 8\SmartHut-Chatapp-Blazor\SmartHut-Chatapp\Pages\Index.razor"
                                                                     DisconnectUser

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(39, "Koppla ifrån");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\n");
            __builder.AddContent(42, "    ");
            __builder.OpenElement(43, "div");
            __builder.AddAttribute(44, "id", "scrollbox");
            __builder.AddMarkupContent(45, "\n");
#nullable restore
#line 31 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\7, Webbapplikationer med Realtidskommunikation\Inlämning 8\SmartHut-Chatapp-Blazor\SmartHut-Chatapp\Pages\Index.razor"
         foreach(var item in messageList)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\7, Webbapplikationer med Realtidskommunikation\Inlämning 8\SmartHut-Chatapp-Blazor\SmartHut-Chatapp\Pages\Index.razor"
             if(item.IsNotice)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(46, "                ");
            __builder.OpenElement(47, "div");
            __builder.AddAttribute(48, "class", "alert alert-info");
            __builder.AddContent(49, 
#nullable restore
#line 35 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\7, Webbapplikationer med Realtidskommunikation\Inlämning 8\SmartHut-Chatapp-Blazor\SmartHut-Chatapp\Pages\Index.razor"
                                               item.Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\n");
#nullable restore
#line 36 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\7, Webbapplikationer med Realtidskommunikation\Inlämning 8\SmartHut-Chatapp-Blazor\SmartHut-Chatapp\Pages\Index.razor"
            }
            else 
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(51, "                ");
            __builder.OpenElement(52, "div");
            __builder.AddAttribute(53, "class", 
#nullable restore
#line 39 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\7, Webbapplikationer med Realtidskommunikation\Inlämning 8\SmartHut-Chatapp-Blazor\SmartHut-Chatapp\Pages\Index.razor"
                             item.CSS

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(54, "\n                    ");
            __builder.OpenElement(55, "div");
            __builder.AddAttribute(56, "class", "user");
            __builder.AddContent(57, 
#nullable restore
#line 40 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\7, Webbapplikationer med Realtidskommunikation\Inlämning 8\SmartHut-Chatapp-Blazor\SmartHut-Chatapp\Pages\Index.razor"
                                       item.Username

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\n                    ");
            __builder.OpenElement(59, "div");
            __builder.AddAttribute(60, "class", "msg");
            __builder.AddContent(61, 
#nullable restore
#line 41 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\7, Webbapplikationer med Realtidskommunikation\Inlämning 8\SmartHut-Chatapp-Blazor\SmartHut-Chatapp\Pages\Index.razor"
                                      item.Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\n");
#nullable restore
#line 43 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\7, Webbapplikationer med Realtidskommunikation\Inlämning 8\SmartHut-Chatapp-Blazor\SmartHut-Chatapp\Pages\Index.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\7, Webbapplikationer med Realtidskommunikation\Inlämning 8\SmartHut-Chatapp-Blazor\SmartHut-Chatapp\Pages\Index.razor"
             
        }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(64, "\n        <hr>\n        ");
            __builder.OpenElement(65, "textarea");
            __builder.AddAttribute(66, "class", "input-lg");
            __builder.AddAttribute(67, "placeholder", "Skriv ditt meddelande...");
            __builder.AddAttribute(68, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 47 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\7, Webbapplikationer med Realtidskommunikation\Inlämning 8\SmartHut-Chatapp-Blazor\SmartHut-Chatapp\Pages\Index.razor"
                                                                                  newMessage

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(69, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newMessage = __value, newMessage));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\n        ");
            __builder.OpenElement(71, "button");
            __builder.AddAttribute(72, "class", "btn btn-outline-success");
            __builder.AddAttribute(73, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 48 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\7, Webbapplikationer med Realtidskommunikation\Inlämning 8\SmartHut-Chatapp-Blazor\SmartHut-Chatapp\Pages\Index.razor"
                                                            () => userNotification(newMessage)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(74, "Skicka");
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\n");
#nullable restore
#line 50 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\7, Webbapplikationer med Realtidskommunikation\Inlämning 8\SmartHut-Chatapp-Blazor\SmartHut-Chatapp\Pages\Index.razor"

}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 54 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\7, Webbapplikationer med Realtidskommunikation\Inlämning 8\SmartHut-Chatapp-Blazor\SmartHut-Chatapp\Pages\Index.razor"
       
    private bool ifChatting = false;
    private string userName;
    private string theMessage;
    private string newMessage;

    private List<Message> messageList = new List<Message>();
    
    private string hubUrl;
    private HubConnection hubConnection;

    public async Task Chat() 
    {
        if(string.IsNullOrWhiteSpace(userName))
        {
            theMessage = "Ange ditt namn";

            return;
        };

        try 
        {
            ifChatting = true;
            await Task.Delay(1);

            messageList.Clear();

            string baseUrl = navigationManager.BaseUri;
            hubUrl = baseUrl.TrimEnd('/') + ChatHub.HubUrl;

            hubConnection = new HubConnectionBuilder().WithUrl(hubUrl).Build();

            hubConnection.On<string, string>("SendMessage", sMessage);
                await hubConnection.StartAsync();
                await userNotification($"Notis || {userName} har anslutit");
        }
        catch(Exception err)
        {
            theMessage = $"VARNING: Kunde inte ansluta till chatten: {err.Message}";
            ifChatting = false;
        }
    }

    private void sMessage(string name, string message)
    {
        bool isMine = name.Equals(userName, StringComparison.OrdinalIgnoreCase);

        messageList.Add(new Message(name, message, isMine));
        StateHasChanged();
    }

    public async Task DisconnectUser() 
    {
        if(ifChatting)
        {
            await userNotification($"Notis || {userName} har kopplats ifrån");

            await hubConnection.StopAsync();
            await hubConnection.DisposeAsync();

            hubConnection = null;
            ifChatting = false;
        }
    }

    public async Task userNotification(string message) 
    {
        if(ifChatting && !string.IsNullOrWhiteSpace(message))
        {
            await hubConnection.SendAsync("sendMessage", userName, message);

            newMessage = string.Empty;
        }
    }

    private class Message 
    {
        public Message(string username, string body, bool mine)
        {
            Username = username;
            Body = body;
            Mine = mine;
        }

        public string Username { get; set; }
        public string Body { get; set;}
        public bool Mine { get; set; }

        public bool IsNotice => Body.StartsWith("Notis");
        public string CSS => Mine ?  "sent" : "received";
    }
 

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
    }
}
#pragma warning restore 1591
