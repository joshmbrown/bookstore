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
    public partial class OrderTable : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 57 "/Users/joshbrown/Desktop/IS Core/IS 413/Bookstore/Bookstore/Pages/Admin/OrderTable.razor"
       

    [Parameter]
    public string TableTitle { get; set; } = "Orders";

    [Parameter]
    public IEnumerable<Checkout> Orders { get; set; }

    [Parameter]
    public string ButtonLabel { get; set; } = "Shipped";

    [Parameter]
    public EventCallback<int> OrdersSelected { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
