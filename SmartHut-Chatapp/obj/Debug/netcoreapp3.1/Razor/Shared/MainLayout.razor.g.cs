#pragma checksum "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\7, Webbapplikationer med Realtidskommunikation\Inlämning 8\SmartHut-Chatapp-Blazor\SmartHut-Chatapp\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f877a036ff8c9144fde9caad7bee0160f837c8db"
// <auto-generated/>
#pragma warning disable 1591
namespace SmartHut_Chatapp.Shared
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
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "sidebar");
            __builder.AddMarkupContent(2, "\n    ");
            __builder.OpenComponent<SmartHut_Chatapp.Shared.NavMenu>(3);
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\n    ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "content px-4");
            __builder.AddMarkupContent(8, "\n        ");
            __builder.AddContent(9, 
#nullable restore
#line 7 "C:\Users\jonas\Desktop\myCode\1. Skola\Webbutveckling .NET\Kurser\7, Webbapplikationer med Realtidskommunikation\Inlämning 8\SmartHut-Chatapp-Blazor\SmartHut-Chatapp\Shared\MainLayout.razor"
         Body

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(10, "\n    ");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
