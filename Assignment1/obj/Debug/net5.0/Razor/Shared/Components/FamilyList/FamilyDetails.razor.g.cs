#pragma checksum "C:\Users\cirst\RiderProjects\Assignment1\Assignment1\Shared\Components\FamilyList\FamilyDetails.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "adefab707bc6fa2e029d26d1f5d3e4aec4687e1d"
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
using Assignment1.Shared.Components.FamilyList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\cirst\RiderProjects\Assignment1\Assignment1\_Imports.razor"
using Assignment1.Shared.Components.Notifications;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\cirst\RiderProjects\Assignment1\Assignment1\_Imports.razor"
using Assignment1.Data.Notifications;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\cirst\RiderProjects\Assignment1\Assignment1\_Imports.razor"
using Assignment1.Data.Notifications.NotificationModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\cirst\RiderProjects\Assignment1\Assignment1\Shared\Components\FamilyList\FamilyDetails.razor"
using Data.Models;

#line default
#line hidden
#nullable disable
    public partial class FamilyDetails : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 4 "C:\Users\cirst\RiderProjects\Assignment1\Assignment1\Shared\Components\FamilyList\FamilyDetails.razor"
 if (Open)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "family-details");
            __builder.AddAttribute(2, "b-h04aw7lyl6");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "family-adults");
            __builder.AddAttribute(5, "b-h04aw7lyl6");
            __builder.AddMarkupContent(6, "<span b-h04aw7lyl6><b b-h04aw7lyl6>Adults</b></span><br b-h04aw7lyl6>");
#nullable restore
#line 11 "C:\Users\cirst\RiderProjects\Assignment1\Assignment1\Shared\Components\FamilyList\FamilyDetails.razor"
             if (Family.Adults.Any())
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\cirst\RiderProjects\Assignment1\Assignment1\Shared\Components\FamilyList\FamilyDetails.razor"
                 foreach (var adult in Family.Adults)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "adult");
            __builder.AddAttribute(9, "b-h04aw7lyl6");
            __builder.OpenElement(10, "b");
            __builder.AddAttribute(11, "b-h04aw7lyl6");
            __builder.AddContent(12, 
#nullable restore
#line 16 "C:\Users\cirst\RiderProjects\Assignment1\Assignment1\Shared\Components\FamilyList\FamilyDetails.razor"
                            adult.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(13, " ");
            __builder.AddContent(14, 
#nullable restore
#line 16 "C:\Users\cirst\RiderProjects\Assignment1\Assignment1\Shared\Components\FamilyList\FamilyDetails.razor"
                                             adult.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddContent(15, " - ");
            __builder.AddContent(16, 
#nullable restore
#line 16 "C:\Users\cirst\RiderProjects\Assignment1\Assignment1\Shared\Components\FamilyList\FamilyDetails.razor"
                                                                   adult.JobTitle.JobTitle

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(17, " <br b-h04aw7lyl6>\r\n                        ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "style", "padding-left: 15px");
            __builder.AddAttribute(20, "b-h04aw7lyl6");
            __builder.AddMarkupContent(21, "<b b-h04aw7lyl6>Eye color</b> - ");
            __builder.AddContent(22, 
#nullable restore
#line 18 "C:\Users\cirst\RiderProjects\Assignment1\Assignment1\Shared\Components\FamilyList\FamilyDetails.razor"
                                                adult?.EyeColor

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(23, " <br b-h04aw7lyl6>\r\n                            ");
            __builder.AddMarkupContent(24, "<b b-h04aw7lyl6>Hair color</b> - ");
            __builder.AddContent(25, 
#nullable restore
#line 19 "C:\Users\cirst\RiderProjects\Assignment1\Assignment1\Shared\Components\FamilyList\FamilyDetails.razor"
                                                 adult?.HairColor

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(26, " <br b-h04aw7lyl6>\r\n                            ");
            __builder.AddMarkupContent(27, "<b b-h04aw7lyl6>Age</b> - ");
            __builder.AddContent(28, 
#nullable restore
#line 20 "C:\Users\cirst\RiderProjects\Assignment1\Assignment1\Shared\Components\FamilyList\FamilyDetails.razor"
                                          adult?.Age

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(29, " yo <br b-h04aw7lyl6>\r\n                            ");
            __builder.AddMarkupContent(30, "<b b-h04aw7lyl6>Weight</b> - ");
            __builder.AddContent(31, 
#nullable restore
#line 21 "C:\Users\cirst\RiderProjects\Assignment1\Assignment1\Shared\Components\FamilyList\FamilyDetails.razor"
                                             adult?.Weight

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(32, " kg<br b-h04aw7lyl6>\r\n                            ");
            __builder.AddMarkupContent(33, "<b b-h04aw7lyl6>Sex</b> - ");
            __builder.AddContent(34, 
#nullable restore
#line 22 "C:\Users\cirst\RiderProjects\Assignment1\Assignment1\Shared\Components\FamilyList\FamilyDetails.razor"
                                          adult?.Sex

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(35, " <br b-h04aw7lyl6>");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 25 "C:\Users\cirst\RiderProjects\Assignment1\Assignment1\Shared\Components\FamilyList\FamilyDetails.razor"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\cirst\RiderProjects\Assignment1\Assignment1\Shared\Components\FamilyList\FamilyDetails.razor"
                 
            }
            else
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(36, "<div b-h04aw7lyl6>\r\n                    No adults\r\n                </div>");
#nullable restore
#line 32 "C:\Users\cirst\RiderProjects\Assignment1\Assignment1\Shared\Components\FamilyList\FamilyDetails.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n        ");
            __builder.OpenElement(38, "div");
            __builder.AddAttribute(39, "class", "family-children");
            __builder.AddAttribute(40, "b-h04aw7lyl6");
            __builder.AddMarkupContent(41, "<span b-h04aw7lyl6><b b-h04aw7lyl6>Children</b></span><br b-h04aw7lyl6>");
#nullable restore
#line 39 "C:\Users\cirst\RiderProjects\Assignment1\Assignment1\Shared\Components\FamilyList\FamilyDetails.razor"
             if (Family.Children.Any())
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "C:\Users\cirst\RiderProjects\Assignment1\Assignment1\Shared\Components\FamilyList\FamilyDetails.razor"
                 foreach (var child in Family.Children)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(42, "div");
            __builder.AddAttribute(43, "class", "child");
            __builder.AddAttribute(44, "b-h04aw7lyl6");
            __builder.OpenElement(45, "b");
            __builder.AddAttribute(46, "b-h04aw7lyl6");
            __builder.AddContent(47, 
#nullable restore
#line 44 "C:\Users\cirst\RiderProjects\Assignment1\Assignment1\Shared\Components\FamilyList\FamilyDetails.razor"
                            child.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(48, " ");
            __builder.AddContent(49, 
#nullable restore
#line 44 "C:\Users\cirst\RiderProjects\Assignment1\Assignment1\Shared\Components\FamilyList\FamilyDetails.razor"
                                             child.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "<br b-h04aw7lyl6>\r\n                        ");
            __builder.OpenElement(51, "div");
            __builder.AddAttribute(52, "style", "padding-left: 15px");
            __builder.AddAttribute(53, "b-h04aw7lyl6");
            __builder.AddMarkupContent(54, "<b b-h04aw7lyl6>Eye color</b> - ");
            __builder.AddContent(55, 
#nullable restore
#line 46 "C:\Users\cirst\RiderProjects\Assignment1\Assignment1\Shared\Components\FamilyList\FamilyDetails.razor"
                                                child.EyeColor

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(56, " <br b-h04aw7lyl6>\r\n                            ");
            __builder.AddMarkupContent(57, "<b b-h04aw7lyl6>Hair color</b> - ");
            __builder.AddContent(58, 
#nullable restore
#line 47 "C:\Users\cirst\RiderProjects\Assignment1\Assignment1\Shared\Components\FamilyList\FamilyDetails.razor"
                                                 child.HairColor

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(59, " <br b-h04aw7lyl6>\r\n                            ");
            __builder.AddMarkupContent(60, "<b b-h04aw7lyl6>Age</b> - ");
            __builder.AddContent(61, 
#nullable restore
#line 48 "C:\Users\cirst\RiderProjects\Assignment1\Assignment1\Shared\Components\FamilyList\FamilyDetails.razor"
                                          child.Age

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(62, " yo<br b-h04aw7lyl6>\r\n                            ");
            __builder.AddMarkupContent(63, "<b b-h04aw7lyl6>Weight</b> - ");
            __builder.AddContent(64, 
#nullable restore
#line 49 "C:\Users\cirst\RiderProjects\Assignment1\Assignment1\Shared\Components\FamilyList\FamilyDetails.razor"
                                             child.Weight

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(65, " kg<br b-h04aw7lyl6>\r\n                            ");
            __builder.AddMarkupContent(66, "<b b-h04aw7lyl6>Sex</b> - ");
            __builder.AddContent(67, 
#nullable restore
#line 50 "C:\Users\cirst\RiderProjects\Assignment1\Assignment1\Shared\Components\FamilyList\FamilyDetails.razor"
                                          child.Sex

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(68, " <br b-h04aw7lyl6>\r\n                            ");
            __builder.AddMarkupContent(69, "<b b-h04aw7lyl6>Interests</b> <br b-h04aw7lyl6>\r\n                            ");
            __builder.OpenElement(70, "div");
            __builder.AddAttribute(71, "style", "padding-left: 15px;");
            __builder.AddAttribute(72, "b-h04aw7lyl6");
#nullable restore
#line 53 "C:\Users\cirst\RiderProjects\Assignment1\Assignment1\Shared\Components\FamilyList\FamilyDetails.razor"
                                 if (child.Interests.Any())
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "C:\Users\cirst\RiderProjects\Assignment1\Assignment1\Shared\Components\FamilyList\FamilyDetails.razor"
                                     foreach (var interest in child.Interests)
                                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(73, "b");
            __builder.AddAttribute(74, "b-h04aw7lyl6");
            __builder.AddContent(75, 
#nullable restore
#line 57 "C:\Users\cirst\RiderProjects\Assignment1\Assignment1\Shared\Components\FamilyList\FamilyDetails.razor"
                                            interest.Type

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n                                        ");
            __builder.OpenElement(77, "span");
            __builder.AddAttribute(78, "b-h04aw7lyl6");
            __builder.AddContent(79, " - ");
            __builder.AddContent(80, 
#nullable restore
#line 58 "C:\Users\cirst\RiderProjects\Assignment1\Assignment1\Shared\Components\FamilyList\FamilyDetails.razor"
                                                  interest.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n                                        <br b-h04aw7lyl6>");
#nullable restore
#line 60 "C:\Users\cirst\RiderProjects\Assignment1\Assignment1\Shared\Components\FamilyList\FamilyDetails.razor"
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "C:\Users\cirst\RiderProjects\Assignment1\Assignment1\Shared\Components\FamilyList\FamilyDetails.razor"
                                     
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(82, "<div b-h04aw7lyl6>\r\n                                        No Interests\r\n                                    </div>");
#nullable restore
#line 67 "C:\Users\cirst\RiderProjects\Assignment1\Assignment1\Shared\Components\FamilyList\FamilyDetails.razor"
                                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 71 "C:\Users\cirst\RiderProjects\Assignment1\Assignment1\Shared\Components\FamilyList\FamilyDetails.razor"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 71 "C:\Users\cirst\RiderProjects\Assignment1\Assignment1\Shared\Components\FamilyList\FamilyDetails.razor"
                 
            }
            else
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(83, "<div b-h04aw7lyl6>\r\n                    No children\r\n                </div>");
#nullable restore
#line 78 "C:\Users\cirst\RiderProjects\Assignment1\Assignment1\Shared\Components\FamilyList\FamilyDetails.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n        ");
            __builder.OpenElement(85, "div");
            __builder.AddAttribute(86, "class", "family-pets");
            __builder.AddAttribute(87, "b-h04aw7lyl6");
            __builder.AddMarkupContent(88, "<span b-h04aw7lyl6><b b-h04aw7lyl6>Pets</b></span><br b-h04aw7lyl6>");
#nullable restore
#line 85 "C:\Users\cirst\RiderProjects\Assignment1\Assignment1\Shared\Components\FamilyList\FamilyDetails.razor"
             if (Family.Pets.Any())
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 87 "C:\Users\cirst\RiderProjects\Assignment1\Assignment1\Shared\Components\FamilyList\FamilyDetails.razor"
                 foreach (var pet in Family.Pets)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(89, "div");
            __builder.AddAttribute(90, "class", "pet");
            __builder.AddAttribute(91, "b-h04aw7lyl6");
            __builder.OpenElement(92, "b");
            __builder.AddAttribute(93, "b-h04aw7lyl6");
            __builder.AddContent(94, 
#nullable restore
#line 90 "C:\Users\cirst\RiderProjects\Assignment1\Assignment1\Shared\Components\FamilyList\FamilyDetails.razor"
                            pet.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddContent(95, " - ");
            __builder.AddContent(96, 
#nullable restore
#line 90 "C:\Users\cirst\RiderProjects\Assignment1\Assignment1\Shared\Components\FamilyList\FamilyDetails.razor"
                                            pet.Species

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(97, ", ");
            __builder.AddContent(98, 
#nullable restore
#line 90 "C:\Users\cirst\RiderProjects\Assignment1\Assignment1\Shared\Components\FamilyList\FamilyDetails.razor"
                                                          pet.Age

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(99, " yo\r\n                    ");
            __builder.CloseElement();
#nullable restore
#line 92 "C:\Users\cirst\RiderProjects\Assignment1\Assignment1\Shared\Components\FamilyList\FamilyDetails.razor"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 92 "C:\Users\cirst\RiderProjects\Assignment1\Assignment1\Shared\Components\FamilyList\FamilyDetails.razor"
                 
            }
            else
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(100, "<div b-h04aw7lyl6>\r\n                    No pets\r\n                </div>");
#nullable restore
#line 99 "C:\Users\cirst\RiderProjects\Assignment1\Assignment1\Shared\Components\FamilyList\FamilyDetails.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 103 "C:\Users\cirst\RiderProjects\Assignment1\Assignment1\Shared\Components\FamilyList\FamilyDetails.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(101, "<div b-h04aw7lyl6></div>");
#nullable restore
#line 107 "C:\Users\cirst\RiderProjects\Assignment1\Assignment1\Shared\Components\FamilyList\FamilyDetails.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 109 "C:\Users\cirst\RiderProjects\Assignment1\Assignment1\Shared\Components\FamilyList\FamilyDetails.razor"
      

    [Parameter]
    public bool Open { get; set; }

    [Parameter]
    public Family Family { get; set; }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
