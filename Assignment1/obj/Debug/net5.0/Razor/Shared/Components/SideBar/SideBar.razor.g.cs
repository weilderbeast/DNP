#pragma checksum "C:\Users\cirst\RiderProjects\Assignment1\Assignment1\Shared\Components\SideBar\SideBar.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5e199c970b373a2eae0e212abb6c4d8be0d001bb"
// <auto-generated/>
#pragma warning disable 1591
namespace Assignment1.Shared.Components.SideBar
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\cirst\RiderProjects\Assignment1\Assignment1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\cirst\RiderProjects\Assignment1\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\cirst\RiderProjects\Assignment1\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\cirst\RiderProjects\Assignment1\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\cirst\RiderProjects\Assignment1\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\cirst\RiderProjects\Assignment1\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\cirst\RiderProjects\Assignment1\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\cirst\RiderProjects\Assignment1\Assignment1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\cirst\RiderProjects\Assignment1\Assignment1\_Imports.razor"
using Assignment1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\cirst\RiderProjects\Assignment1\Assignment1\_Imports.razor"
using Assignment1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\cirst\RiderProjects\Assignment1\Assignment1\_Imports.razor"
using Assignment1.Shared.Components.NavMenu;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\cirst\RiderProjects\Assignment1\Assignment1\_Imports.razor"
using Assignment1.Shared.Components.SideBar;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\cirst\RiderProjects\Assignment1\Assignment1\_Imports.razor"
using Assignment1.Data.Persistence;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\cirst\RiderProjects\Assignment1\Assignment1\_Imports.razor"
using Assignment1.Data.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\cirst\RiderProjects\Assignment1\Assignment1\_Imports.razor"
using Assignment1.Data.NotificationService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\cirst\RiderProjects\Assignment1\Assignment1\_Imports.razor"
using Assignment1.Data.NotificationService.NotificationModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\cirst\RiderProjects\Assignment1\Assignment1\_Imports.razor"
using Assignment1.Shared.Components.NotificationsNew;

#line default
#line hidden
#nullable disable
    public partial class SideBar : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(2, @"<div class=""sidebar"" b-dwvbmy665p><ul class=""sidebar-nav"" b-dwvbmy665p><li class=""sidebar-item"" b-dwvbmy665p><a href=""https://www.facebook.com/cirstoiu.bogdan"" b-dwvbmy665p><img src=""/icons/facebook.svg"" width=""20"" height=""20"" b-dwvbmy665p></a></li>
                <li class=""sidebar-item"" b-dwvbmy665p><a href=""https://www.instagram.com/_bogdanel/"" b-dwvbmy665p><img src=""/icons/instagram.svg"" width=""20"" height=""20"" b-dwvbmy665p></a></li>
                <li class=""sidebar-item"" b-dwvbmy665p><a href=""mailto:297109@via.dk"" b-dwvbmy665p><img src=""/icons/mail.svg"" width=""20"" height=""20"" b-dwvbmy665p></a></li></ul></div>");
            }
            ));
            __builder.AddAttribute(3, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(4, "<div b-dwvbmy665p></div>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
