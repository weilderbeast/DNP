#pragma checksum "C:\Users\cirst\RiderProjects\Assignment1\Assignment1\Shared\Components\FamilyList\FamilyListing.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d9023484322a4e34fe48da935714689f35b9496"
// <auto-generated/>
#pragma warning disable 1591
namespace Assignment1.Shared.Components.FamilyList
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
#nullable restore
#line 1 "C:\Users\cirst\RiderProjects\Assignment1\Assignment1\Shared\Components\FamilyList\FamilyListing.razor"
using Data.Models;

#line default
#line hidden
#nullable disable
    public partial class FamilyListing : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", 
#nullable restore
#line 4 "C:\Users\cirst\RiderProjects\Assignment1\Assignment1\Shared\Components\FamilyList\FamilyListing.razor"
             cssClass

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(2, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 4 "C:\Users\cirst\RiderProjects\Assignment1\Assignment1\Shared\Components\FamilyList\FamilyListing.razor"
                                 openDetails

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "b-02s66094zx");
            __builder.OpenElement(4, "span");
            __builder.AddAttribute(5, "b-02s66094zx");
#nullable restore
#line 7 "C:\Users\cirst\RiderProjects\Assignment1\Assignment1\Shared\Components\FamilyList\FamilyListing.razor"
         if(!isOpen){

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(6, "<img src=\"/icons/down-arrow.svg\" height=\"12\" width=\"12\" b-02s66094zx>");
#nullable restore
#line 9 "C:\Users\cirst\RiderProjects\Assignment1\Assignment1\Shared\Components\FamilyList\FamilyListing.razor"
        } else {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(7, "<img src=\"/icons/down-arrow.svg\" height=\"12\" width=\"12\" style=\"transform: rotate(180deg) scaleX(-1);\" b-02s66094zx>");
#nullable restore
#line 11 "C:\Users\cirst\RiderProjects\Assignment1\Assignment1\Shared\Components\FamilyList\FamilyListing.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "family-name");
            __builder.AddAttribute(11, "b-02s66094zx");
            __builder.AddContent(12, 
#nullable restore
#line 15 "C:\Users\cirst\RiderProjects\Assignment1\Assignment1\Shared\Components\FamilyList\FamilyListing.razor"
         Family.Adults[0].LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n    ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "family-address");
            __builder.AddAttribute(16, "b-02s66094zx");
            __builder.AddContent(17, 
#nullable restore
#line 18 "C:\Users\cirst\RiderProjects\Assignment1\Assignment1\Shared\Components\FamilyList\FamilyListing.razor"
         Family.StreetName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n    ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "family-count");
            __builder.AddAttribute(21, "b-02s66094zx");
            __builder.AddContent(22, 
#nullable restore
#line 21 "C:\Users\cirst\RiderProjects\Assignment1\Assignment1\Shared\Components\FamilyList\FamilyListing.razor"
         Family.Children.Count

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(23, " kids,\r\n        ");
            __builder.AddContent(24, 
#nullable restore
#line 22 "C:\Users\cirst\RiderProjects\Assignment1\Assignment1\Shared\Components\FamilyList\FamilyListing.razor"
         Family.Pets.Count

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(25, " pets\r\n    ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n");
            __builder.OpenComponent<Assignment1.Shared.Components.FamilyList.FamilyDetails>(27);
            __builder.AddAttribute(28, "Open", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 25 "C:\Users\cirst\RiderProjects\Assignment1\Assignment1\Shared\Components\FamilyList\FamilyListing.razor"
                     isOpen

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(29, "Family", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Assignment1.Data.Models.Family>(
#nullable restore
#line 25 "C:\Users\cirst\RiderProjects\Assignment1\Assignment1\Shared\Components\FamilyList\FamilyListing.razor"
                                    Family

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "C:\Users\cirst\RiderProjects\Assignment1\Assignment1\Shared\Components\FamilyList\FamilyListing.razor"
      
    [Parameter]
    public Family Family { get; set; }
    private bool isOpen = false;
    private string cssClass = "family-item .";

    public void openDetails()
    {
        isOpen = !isOpen;
        if (isOpen)
        {
            cssClass = cssClass.Replace(".", "open");
        }
        else
        {
            cssClass = cssClass.Replace("open", ".");
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
