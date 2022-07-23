#pragma checksum "F:\NET-TECH-COURSE\PaySys\Client\Pages\Transfer.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e4687232b8d8c0bb3a2981a6c50968d6ad4b42a8"
// <auto-generated/>
#pragma warning disable 1591
namespace PaySys.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "F:\NET-TECH-COURSE\PaySys\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\NET-TECH-COURSE\PaySys\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\NET-TECH-COURSE\PaySys\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\NET-TECH-COURSE\PaySys\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\NET-TECH-COURSE\PaySys\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\NET-TECH-COURSE\PaySys\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "F:\NET-TECH-COURSE\PaySys\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "F:\NET-TECH-COURSE\PaySys\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "F:\NET-TECH-COURSE\PaySys\Client\_Imports.razor"
using PaySys.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "F:\NET-TECH-COURSE\PaySys\Client\_Imports.razor"
using PaySys.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\NET-TECH-COURSE\PaySys\Client\Pages\Transfer.razor"
using PaySys.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\NET-TECH-COURSE\PaySys\Client\Pages\Transfer.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\NET-TECH-COURSE\PaySys\Client\Pages\Transfer.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\NET-TECH-COURSE\PaySys\Client\Pages\Transfer.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/transfer/{sourceWalletId}")]
    public partial class Transfer : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style>\r\n    .wallet{\r\n        width: 250px;\r\n        border: 1px solid #555;\r\n        border-radius: 5px;\r\n        padding: 10px;\r\n    }\r\n</style>\r\n\r\n");
            __builder.AddMarkupContent(1, "<h3>Transfer</h3>\r\n\r\n");
#nullable restore
#line 20 "F:\NET-TECH-COURSE\PaySys\Client\Pages\Transfer.razor"
 if (wallet == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "    ");
            __builder.AddMarkupContent(3, "<div>Loading...</div>\r\n");
#nullable restore
#line 23 "F:\NET-TECH-COURSE\PaySys\Client\Pages\Transfer.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "    ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "card");
            __builder.AddAttribute(7, "style", "width: 18rem;");
            __builder.AddMarkupContent(8, "\r\n        ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "card-body");
            __builder.AddMarkupContent(11, "\r\n            ");
            __builder.OpenElement(12, "h5");
            __builder.AddAttribute(13, "class", "card-title");
            __builder.AddContent(14, "Wallet ");
#nullable restore
#line 28 "F:\NET-TECH-COURSE\PaySys\Client\Pages\Transfer.razor"
__builder.AddContent(15, wallet.Id);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n            ");
            __builder.OpenElement(17, "p");
            __builder.AddAttribute(18, "class", "card-text");
            __builder.AddContent(19, "Amount: ");
#nullable restore
#line 29 "F:\NET-TECH-COURSE\PaySys\Client\Pages\Transfer.razor"
__builder.AddContent(20, wallet.Amount);

#line default
#line hidden
#nullable disable
            __builder.AddContent(21, " ");
#nullable restore
#line 29 "F:\NET-TECH-COURSE\PaySys\Client\Pages\Transfer.razor"
__builder.AddContent(22, wallet.Currency);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n            ");
            __builder.OpenElement(24, "p");
            __builder.AddMarkupContent(25, "\r\n                Amount: <br> \r\n                ");
            __builder.OpenElement(26, "input");
            __builder.AddAttribute(27, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 32 "F:\NET-TECH-COURSE\PaySys\Client\Pages\Transfer.razor"
                              transferData.Amount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(28, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => transferData.Amount = __value, transferData.Amount));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n            ");
            __builder.OpenElement(31, "p");
            __builder.AddMarkupContent(32, "\r\n                Username: <br> \r\n                ");
            __builder.OpenElement(33, "input");
            __builder.AddAttribute(34, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 36 "F:\NET-TECH-COURSE\PaySys\Client\Pages\Transfer.razor"
                              transferData.Username

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(35, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => transferData.Username = __value, transferData.Username));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n            ");
            __builder.OpenElement(38, "button");
            __builder.AddAttribute(39, "class", "btn btn-primary");
            __builder.AddAttribute(40, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 38 "F:\NET-TECH-COURSE\PaySys\Client\Pages\Transfer.razor"
                                                      MakeTransfer

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(41, "Transfer");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n");
#nullable restore
#line 41 "F:\NET-TECH-COURSE\PaySys\Client\Pages\Transfer.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 44 "F:\NET-TECH-COURSE\PaySys\Client\Pages\Transfer.razor"
       
    [Parameter]
    public string SourceWalletId { get; set; }
    public Wallet wallet { get; set; }
    public TransferDto transferData { get; set; } = new TransferDto();

    protected override async Task OnInitializedAsync()
    {
        try
        {
            wallet = await HttpClient.GetFromJsonAsync<Wallet>($"/wallet/{SourceWalletId}");
        }
        catch (AccessTokenNotAvailableException exception)
        {
            exception.Redirect();
        }
    }

    private async Task MakeTransfer()
    {
        try
        {
            transferData.SourceWalletId = SourceWalletId;
            transferData.Currency = wallet.Currency;
            var response = await HttpClient.PostAsJsonAsync($"/wallet/transfer", transferData);

            if (response.IsSuccessStatusCode)
            {
                navMananger.NavigateTo($"/wallet");
            }

        }
        catch (AccessTokenNotAvailableException exception)
        {
            exception.Redirect();
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navMananger { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient HttpClient { get; set; }
    }
}
#pragma warning restore 1591
