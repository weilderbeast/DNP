#pragma checksum "C:\Users\cirst\RiderProjects\Assignment1\Assignment1\Shared\Components\Notifications\Notification.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a148ed5e79533e38368b4a7eeac7dd87be93da9d"
// <auto-generated/>
#pragma warning disable 1591
namespace Assignment1.Shared.Components.Notifications
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
#line 1 "C:\Users\cirst\RiderProjects\Assignment1\Assignment1\Shared\Components\Notifications\Notification.razor"
using Assignment1.Data.Notifications;

#line default
#line hidden
#nullable disable
    public partial class Notification : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "notification");
            __builder.AddAttribute(2, "b-6igrmcc52c");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "title");
            __builder.AddAttribute(5, "style", "color:" + (
#nullable restore
#line 4 "C:\Users\cirst\RiderProjects\Assignment1\Assignment1\Shared\Components\Notifications\Notification.razor"
                                     _color

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "b-6igrmcc52c");
            __builder.AddContent(7, 
#nullable restore
#line 5 "C:\Users\cirst\RiderProjects\Assignment1\Assignment1\Shared\Components\Notifications\Notification.razor"
         Title

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(8, "\r\n        ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "exit");
            __builder.AddAttribute(11, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 6 "C:\Users\cirst\RiderProjects\Assignment1\Assignment1\Shared\Components\Notifications\Notification.razor"
                                    Remove

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "b-6igrmcc52c");
            __builder.AddMarkupContent(13, "<img src=\"../icons/exit.svg\" width=\"12\" height=\"12\" b-6igrmcc52c>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n    ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "content");
            __builder.AddAttribute(17, "b-6igrmcc52c");
            __builder.AddContent(18, 
#nullable restore
#line 11 "C:\Users\cirst\RiderProjects\Assignment1\Assignment1\Shared\Components\Notifications\Notification.razor"
         Content

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 15 "C:\Users\cirst\RiderProjects\Assignment1\Assignment1\Shared\Components\Notifications\Notification.razor"
      
    [Parameter]
    public string Title { get; set; }
    [Parameter]
    public string Content { get; set; }
    [Parameter]
    public NotificationType Severity { get; set; }

    private string _color = "lightblue";

    public Notification()
    {
        switch (Severity)
        {
            case NotificationType.Error:
                _color = "";
                _color = "#FD4D4D";
                break;
            case NotificationType.Info:
                _color = "";
                _color = "#add8e6";
                break;
            case NotificationType.Success:
                _color = "";
                _color = "#32CD32";
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }
    }

    private void Remove(){
        NotificationManager.Remove(this);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NotificationManager NotificationManager { get; set; }
    }
}
#pragma warning restore 1591