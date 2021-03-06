#pragma checksum "/Users/bcraythorne/Documents/GitHub/Sapo/Sapo/Sapo/Pages/Admin/Purchases.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8ff913672f3eb748d4afe1c1b26ab6845414ff8b"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/purchases")]
    public partial class Purchases : OwningComponentBase<IPurchaseRepository>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Sapo.Pages.Admin.PurchaseTable>(0);
            __builder.AddAttribute(1, "TableTitle", "Uncollected Purchases");
            __builder.AddAttribute(2, "Purchases", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<Sapo.Models.Purchase>>(
#nullable restore
#line 5 "/Users/bcraythorne/Documents/GitHub/Sapo/Sapo/Sapo/Pages/Admin/Purchases.razor"
                                                             UncollectedPurchases

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "ButtonLabel", "Collected");
            __builder.AddAttribute(4, "PurchaseSelected", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, 
#nullable restore
#line 6 "/Users/bcraythorne/Documents/GitHub/Sapo/Sapo/Sapo/Pages/Admin/Purchases.razor"
                                                         CollectPurchase

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(5, "\n");
            __builder.OpenComponent<Sapo.Pages.Admin.PurchaseTable>(6);
            __builder.AddAttribute(7, "TableTitle", "Collected Purchases");
            __builder.AddAttribute(8, "Purchases", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<Sapo.Models.Purchase>>(
#nullable restore
#line 7 "/Users/bcraythorne/Documents/GitHub/Sapo/Sapo/Sapo/Pages/Admin/Purchases.razor"
                                                           CollectedPurchases

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "ButtonLabel", "Reset");
            __builder.AddAttribute(10, "PurchaseSelected", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, 
#nullable restore
#line 8 "/Users/bcraythorne/Documents/GitHub/Sapo/Sapo/Sapo/Pages/Admin/Purchases.razor"
                                                     ResetPurchase

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(11, "\n\n");
            __builder.OpenElement(12, "button");
            __builder.AddAttribute(13, "class", "btn btn-info");
            __builder.AddAttribute(14, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "/Users/bcraythorne/Documents/GitHub/Sapo/Sapo/Sapo/Pages/Admin/Purchases.razor"
                                         x => UpdateData()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(15, "Refresh Data");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 12 "/Users/bcraythorne/Documents/GitHub/Sapo/Sapo/Sapo/Pages/Admin/Purchases.razor"
       

    public IPurchaseRepository repo => Service;

    public IEnumerable<Purchase> AllPurchases { get; set; }
    public IEnumerable<Purchase> UncollectedPurchases { get; set; }
    public IEnumerable<Purchase> CollectedPurchases { get; set; }

    protected async override Task OnInitializedAsync()
    {
        await UpdateData();
    }

    public async Task UpdateData()
    {
        AllPurchases = await repo.Purchases.ToListAsync();
        UncollectedPurchases = AllPurchases.Where(x => !x.PurchaseReceived);
        CollectedPurchases = AllPurchases.Where(x => x.PurchaseReceived);

    }


    public void CollectPurchase(int id) => UpdatePurchase(id, true);
    public void ResetPurchase(int id) => UpdatePurchase(id, false);
    public void UpdatePurchase (int id, bool purchased)
    {
        Purchase p = repo.Purchases.FirstOrDefault(x => x.PurchaseID == id);
        p.PurchaseReceived = purchased;
        repo.SavePurchase(p);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
