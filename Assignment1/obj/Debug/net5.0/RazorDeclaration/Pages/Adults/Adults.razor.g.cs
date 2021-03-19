// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Assignment1.Pages.Adults
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
#line 6 "C:\Users\cirst\RiderProjects\Assignment1\Assignment1\Pages\Adults\Adults.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Adults")]
    public partial class Adults : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 89 "C:\Users\cirst\RiderProjects\Assignment1\Assignment1\Pages\Adults\Adults.razor"
      
    private string fname;
    private string lname;
    private string age;
    private string hairColor;
    private string eyeColor;
    private string weight;
    private string height;
    private string sex;
    private string job;
    private string salary;

    public void Submit()
    {
        var Adult = new Adult();
        Adult.FirstName = fname;
        Adult.LastName = lname;
        Adult.HairColor = hairColor;
        Adult.EyeColor = eyeColor;
        Adult.Age = Int32.Parse(age);
        Adult.Weight = float.Parse(weight);
        Adult.Height = Int32.Parse(height);
        Adult.Sex = sex;
        var Job = new Job();
        Job.JobTitle = job;
        Job.Salary = Int32.Parse(salary);
        Adult.JobTitle = Job;

        System.Console.WriteLine(Adult.ToString());

        var id = FileContext.Adults.Last<Adult>().Id;

        Adult.Id = id + 1;
        FileContext.Adults.Add(Adult);

        Clear();
    }

    private void Clear()
    {
        fname = "";
        lname = "";
        age = "";
        sex = "";
        hairColor = "";
        eyeColor = "";
        height = "";
        weight = "";
        job = "";
        salary = "";
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private FileContext FileContext { get; set; }
    }
}
#pragma warning restore 1591
