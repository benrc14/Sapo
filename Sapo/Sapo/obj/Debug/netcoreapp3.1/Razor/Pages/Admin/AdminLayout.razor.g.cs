#pragma checksum "/Users/bcraythorne/Documents/GitHub/Sapo/Sapo/Sapo/Pages/Admin/AdminLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f7619c270aaaa5d3b88cd984a658313fb4e0fd10"
// <auto-generated/>
#pragma warning disable 1591
namespace Sapo.Pages.Admin
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "/Users/bcraythorne/Documents/GitHub/Sapo/Sapo/Sapo/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/bcraythorne/Documents/GitHub/Sapo/Sapo/Sapo/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/bcraythorne/Documents/GitHub/Sapo/Sapo/Sapo/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/bcraythorne/Documents/GitHub/Sapo/Sapo/Sapo/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/bcraythorne/Documents/GitHub/Sapo/Sapo/Sapo/Pages/Admin/_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/bcraythorne/Documents/GitHub/Sapo/Sapo/Sapo/Pages/Admin/_Imports.razor"
using Sapo.Models;

#line default
#line hidden
#nullable disable
    public partial class AdminLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"bg-info text-white p-2\">\n    <span class=\"navbar-brand m-lg-2\">Sapo Admin</span>\n\n</div>\n\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "container-fluid");
            __builder.AddMarkupContent(3, "\n\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "row p-2");
            __builder.AddMarkupContent(6, "\n\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "col-3 d-grid");
            __builder.AddMarkupContent(9, "\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(10);
            __builder.AddAttribute(11, "class", "btn btn-block btn-outline");
            __builder.AddAttribute(12, "href", "/admin/purchases");
            __builder.AddAttribute(13, "ActiveClass", "btn-primary text-white");
            __builder.AddAttribute(14, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 14 "/Users/bcraythorne/Documents/GitHub/Sapo/Sapo/Sapo/Pages/Admin/AdminLayout.razor"
                                                                 NavLinkMatch.Prefix

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(16, "Purchases");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(17, "\n\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(18);
            __builder.AddAttribute(19, "class", "btn btn-block btn-outline");
            __builder.AddAttribute(20, "href", "/admin/books");
            __builder.AddAttribute(21, "ActiveClass", "btn-primary text-white");
            __builder.AddAttribute(22, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 17 "/Users/bcraythorne/Documents/GitHub/Sapo/Sapo/Sapo/Pages/Admin/AdminLayout.razor"
                                                                 NavLinkMatch.Prefix

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(23, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(24, "Books");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(25, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\n\n\n        ");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "col");
            __builder.AddMarkupContent(29, "\n            ");
            __builder.AddContent(30, 
#nullable restore
#line 22 "/Users/bcraythorne/Documents/GitHub/Sapo/Sapo/Sapo/Pages/Admin/AdminLayout.razor"
             Body

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(31, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\n\n\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\n\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
