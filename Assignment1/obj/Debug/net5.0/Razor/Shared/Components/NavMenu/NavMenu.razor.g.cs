#pragma checksum "C:\Users\cirst\RiderProjects\Assignment1\Assignment1\Shared\Components\NavMenu\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c23162e226710b10808dce09584cc128aed07c41"
// <auto-generated/>
#pragma warning disable 1591
namespace Assignment1.Shared.Components.NavMenu
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
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<div class=""nav"" b-p3bnnmd0b4><ul class=""nav-ul"" b-p3bnnmd0b4><li class=""nav-item"" b-p3bnnmd0b4><div class=""item-content"" b-p3bnnmd0b4>
                Home
            </div></li>
        <li class=""nav-item"" b-p3bnnmd0b4><div class=""item-content"" b-p3bnnmd0b4><a href=""Adults"" b-p3bnnmd0b4>
                    Adults
                </a></div></li>
        <li class=""nav-item"" b-p3bnnmd0b4><div class=""item-content"" b-p3bnnmd0b4>
                Children
            </div></li>
        <li class=""nav-item"" b-p3bnnmd0b4><div class=""item-content"" b-p3bnnmd0b4>
                Pets
            </div></li></ul></div>");
        }
        #pragma warning restore 1998
#nullable restore
#line 31 "C:\Users\cirst\RiderProjects\Assignment1\Assignment1\Shared\Components\NavMenu\NavMenu.razor"
      
    private void GoTo()
    {
        NavigationManager.NavigateTo("/Adults");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
