// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Bookstore.Pages.Admin
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
#nullable restore
#line 1 "/Users/joshbrown/Desktop/IS Core/IS 413/Bookstore/Bookstore/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/joshbrown/Desktop/IS Core/IS 413/Bookstore/Bookstore/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/joshbrown/Desktop/IS Core/IS 413/Bookstore/Bookstore/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/joshbrown/Desktop/IS Core/IS 413/Bookstore/Bookstore/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/joshbrown/Desktop/IS Core/IS 413/Bookstore/Bookstore/Pages/Admin/_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/joshbrown/Desktop/IS Core/IS 413/Bookstore/Bookstore/Pages/Admin/_Imports.razor"
using Bookstore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/joshbrown/Desktop/IS Core/IS 413/Bookstore/Bookstore/Pages/Admin/_Imports.razor"
using System.Globalization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/joshbrown/Desktop/IS Core/IS 413/Bookstore/Bookstore/Pages/Admin/_Imports.razor"
using System.Threading;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/joshbrown/Desktop/IS Core/IS 413/Bookstore/Bookstore/Pages/Admin/_Imports.razor"
using System.Threading.Tasks;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/orders")]
    public partial class Orders : OwningComponentBase<ICheckoutRepository>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "/Users/joshbrown/Desktop/IS Core/IS 413/Bookstore/Bookstore/Pages/Admin/Orders.razor"
       

    public ICheckoutRepository repo => Service;

    public IEnumerable<Checkout> AllOrders { get; set; }
    public IEnumerable<Checkout> ShippedOrders { get; set; }
    public IEnumerable<Checkout> UnshippedOrders { get; set; }

    protected async override Task OnInitializedAsync()
    {
        await UpdateData();
    }

    public async Task UpdateData()
    {
        AllOrders = await repo.Checkouts.ToListAsync();
        UnshippedOrders = AllOrders.Where(x => !x.IsShipped);
        ShippedOrders = AllOrders.Where(x => x.IsShipped);
    }

    public void ShipOrder(int id) => UpdateOrder(id, true);
    public void ResetOrder(int id) => UpdateOrder(id, false);

    private void UpdateOrder(int id, bool ordered)
    {
        Checkout o = repo.Checkouts.FirstOrDefault(x => x.CheckoutID == id);
        o.IsShipped = ordered;
        repo.SaveCheckout(o);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
