#pragma checksum "C:\Users\micha\Documents\EADCA3_VS\EADCA3\BlazorApplication\BlazorApplication\Pages\Quotes.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "402456978d7332f11397cd75c5532e6f3426f368"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApplication.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\micha\Documents\EADCA3_VS\EADCA3\BlazorApplication\BlazorApplication\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\micha\Documents\EADCA3_VS\EADCA3\BlazorApplication\BlazorApplication\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\micha\Documents\EADCA3_VS\EADCA3\BlazorApplication\BlazorApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\micha\Documents\EADCA3_VS\EADCA3\BlazorApplication\BlazorApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\micha\Documents\EADCA3_VS\EADCA3\BlazorApplication\BlazorApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\micha\Documents\EADCA3_VS\EADCA3\BlazorApplication\BlazorApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\micha\Documents\EADCA3_VS\EADCA3\BlazorApplication\BlazorApplication\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\micha\Documents\EADCA3_VS\EADCA3\BlazorApplication\BlazorApplication\_Imports.razor"
using BlazorApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\micha\Documents\EADCA3_VS\EADCA3\BlazorApplication\BlazorApplication\_Imports.razor"
using BlazorApplication.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\micha\Documents\EADCA3_VS\EADCA3\BlazorApplication\BlazorApplication\_Imports.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/quotes")]
    public partial class Quotes : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h1");
            __builder.AddAttribute(1, "class", "display-4");
            __builder.AddContent(2, 
#nullable restore
#line 8 "C:\Users\micha\Documents\EADCA3_VS\EADCA3\BlazorApplication\BlazorApplication\Pages\Quotes.razor"
                       Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\r\n");
            __builder.AddMarkupContent(4, "<style>\r\n    #myButton {\r\n        margin-bottom: 2.5em;\r\n    }\r\n\r\n    #navInputBox {\r\n        width: 28%;\r\n    }\r\n\r\n    .sort-th {\r\n        cursor: pointer;\r\n    }\r\n\r\n    .fa {\r\n        float: right;\r\n    }\r\n</style>\r\n\r\n");
            __builder.OpenElement(5, "button");
            __builder.AddAttribute(6, "type", "button");
            __builder.AddAttribute(7, "class", "btn btn-sm btn-primary");
            __builder.AddAttribute(8, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 28 "C:\Users\micha\Documents\EADCA3_VS\EADCA3\BlazorApplication\BlazorApplication\Pages\Quotes.razor"
                                                               Alert

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "id", "myButton");
            __builder.AddContent(10, "Random Quote");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n\r\n");
            __builder.OpenElement(12, "nav");
            __builder.AddAttribute(13, "class", "navbar navbar-light bg-light");
            __builder.AddAttribute(14, "id", "navInputBox");
            __builder.OpenElement(15, "form");
            __builder.AddAttribute(16, "class", "container-fluid");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "input-group");
            __builder.AddMarkupContent(19, @"<span class=""input-group-text"" id=""basic-addon1""><svg xmlns=""http://www.w3.org/2000/svg"" width=""16"" height=""16"" fill=""currentColor"" class=""bi bi-person-fill"" viewBox=""0 0 16 16""><path fill-rule=""evenodd"" d=""M3 14s-1 0-1-1 1-4 6-4 6 3 6 4-1 1-1 1H3zm5-6a3 3 0 1 0 0-6 3 3 0 0 0 0 6z""></path></svg></span>
            ");
            __builder.OpenElement(20, "input");
            __builder.AddAttribute(21, "type", "text");
            __builder.AddAttribute(22, "class", "form-control");
            __builder.AddAttribute(23, "placeholder", "Character Name");
            __builder.AddAttribute(24, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 38 "C:\Users\micha\Documents\EADCA3_VS\EADCA3\BlazorApplication\BlazorApplication\Pages\Quotes.razor"
                                                                                                                                 (e) => { friend.CharacterInputValue = (string)e.Value; isCharacterOrQouteSearch = true; }

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(25, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 38 "C:\Users\micha\Documents\EADCA3_VS\EADCA3\BlazorApplication\BlazorApplication\Pages\Quotes.razor"
                                                                                         friend.CharacterInputValue

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(26, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => friend.CharacterInputValue = __value, friend.CharacterInputValue));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n            ");
            __builder.OpenElement(28, "input");
            __builder.AddAttribute(29, "type", "text");
            __builder.AddAttribute(30, "class", "form-control");
            __builder.AddAttribute(31, "placeholder", "Quote Keyword");
            __builder.AddAttribute(32, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 39 "C:\Users\micha\Documents\EADCA3_VS\EADCA3\BlazorApplication\BlazorApplication\Pages\Quotes.razor"
                                                                                                                              (e) => { friend.KeywordInputValue = (string)e.Value; isCharacterOrQouteSearch = false; }

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(33, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 39 "C:\Users\micha\Documents\EADCA3_VS\EADCA3\BlazorApplication\BlazorApplication\Pages\Quotes.razor"
                                                                                        friend.KeywordInputValue

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(34, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => friend.KeywordInputValue = __value, friend.KeywordInputValue));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 45 "C:\Users\micha\Documents\EADCA3_VS\EADCA3\BlazorApplication\BlazorApplication\Pages\Quotes.razor"
 if (friend.listOfQuotes == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(35, "<div class=\"spinner-border text-primary\" role=\"status\"><span class=\"visually-hidden\"></span></div>");
#nullable restore
#line 50 "C:\Users\micha\Documents\EADCA3_VS\EADCA3\BlazorApplication\BlazorApplication\Pages\Quotes.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(36, "table");
            __builder.AddAttribute(37, "class", "table");
            __builder.OpenElement(38, "thead");
            __builder.OpenElement(39, "tr");
            __builder.OpenElement(40, "th");
            __builder.AddAttribute(41, "class", "sort-th");
            __builder.AddAttribute(42, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 56 "C:\Users\micha\Documents\EADCA3_VS\EADCA3\BlazorApplication\BlazorApplication\Pages\Quotes.razor"
                                                () => friend.SortTable("Character")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(43, "Character \r\n                ");
            __builder.AddMarkupContent(44, @"<svg xmlns=""http://www.w3.org/2000/svg"" width=""16"" height=""16"" fill=""currentColor"" class=""bi bi-arrow-down-up"" viewBox=""0 0 16 16""><path fill-rule=""evenodd"" d=""M11.5 15a.5.5 0 0 0 .5-.5V2.707l3.146 3.147a.5.5 0 0 0 .708-.708l-4-4a.5.5 0 0 0-.708 0l-4 4a.5.5 0 1 0 .708.708L11 2.707V14.5a.5.5 0 0 0 .5.5zm-7-14a.5.5 0 0 1 .5.5v11.793l3.146-3.147a.5.5 0 0 1 .708.708l-4 4a.5.5 0 0 1-.708 0l-4-4a.5.5 0 0 1 .708-.708L4 13.293V1.5a.5.5 0 0 1 .5-.5z""></path></svg>");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n                ");
            __builder.AddMarkupContent(46, "<th>Quote</th>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n\r\n        ");
            __builder.OpenElement(48, "tbody");
#nullable restore
#line 67 "C:\Users\micha\Documents\EADCA3_VS\EADCA3\BlazorApplication\BlazorApplication\Pages\Quotes.razor"
             if (isCharacterOrQouteSearch)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 69 "C:\Users\micha\Documents\EADCA3_VS\EADCA3\BlazorApplication\BlazorApplication\Pages\Quotes.razor"
                 foreach (var item in friend.listOfQuotes.Where(x => friend.FilterByCharacter(x)))
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(49, "tr");
            __builder.OpenElement(50, "td");
            __builder.AddContent(51, 
#nullable restore
#line 72 "C:\Users\micha\Documents\EADCA3_VS\EADCA3\BlazorApplication\BlazorApplication\Pages\Quotes.razor"
                             item.character

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n                        ");
            __builder.OpenElement(53, "td");
            __builder.AddContent(54, 
#nullable restore
#line 73 "C:\Users\micha\Documents\EADCA3_VS\EADCA3\BlazorApplication\BlazorApplication\Pages\Quotes.razor"
                             item.quote

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 75 "C:\Users\micha\Documents\EADCA3_VS\EADCA3\BlazorApplication\BlazorApplication\Pages\Quotes.razor"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 75 "C:\Users\micha\Documents\EADCA3_VS\EADCA3\BlazorApplication\BlazorApplication\Pages\Quotes.razor"
                 
            }
            else
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 79 "C:\Users\micha\Documents\EADCA3_VS\EADCA3\BlazorApplication\BlazorApplication\Pages\Quotes.razor"
                 foreach (var item in friend.listOfQuotes.Where(x => friend.FilterByQuote(x)))
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(55, "tr");
            __builder.OpenElement(56, "td");
            __builder.AddContent(57, 
#nullable restore
#line 82 "C:\Users\micha\Documents\EADCA3_VS\EADCA3\BlazorApplication\BlazorApplication\Pages\Quotes.razor"
                             item.character

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n                        ");
            __builder.OpenElement(59, "td");
            __builder.AddContent(60, 
#nullable restore
#line 83 "C:\Users\micha\Documents\EADCA3_VS\EADCA3\BlazorApplication\BlazorApplication\Pages\Quotes.razor"
                             item.quote

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 85 "C:\Users\micha\Documents\EADCA3_VS\EADCA3\BlazorApplication\BlazorApplication\Pages\Quotes.razor"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 85 "C:\Users\micha\Documents\EADCA3_VS\EADCA3\BlazorApplication\BlazorApplication\Pages\Quotes.razor"
                 
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 89 "C:\Users\micha\Documents\EADCA3_VS\EADCA3\BlazorApplication\BlazorApplication\Pages\Quotes.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 92 "C:\Users\micha\Documents\EADCA3_VS\EADCA3\BlazorApplication\BlazorApplication\Pages\Quotes.razor"
       
    private bool isCharacterOrQouteSearch;
    private string Title = "Friends Quotes"; // Title data
    private QueryFriends friend = new QueryFriends();

    private FriendsResponseData randomQuote;
    public string Message
    {
        get
        {
            return $"{randomQuote.quote} ({randomQuote.character})";
        }
    }

    protected override async Task OnInitializedAsync()
    {
        friend.listOfQuotes = await client.GetFromJsonAsync<List<FriendsResponseData>>("https://friends-quotes-api.herokuapp.com/quotes");
        randomQuote = await client.GetFromJsonAsync<FriendsResponseData>("https://friends-quotes-api.herokuapp.com/quotes/random");
    }

    private async Task Alert()
    {
        await JS.InvokeAsync<string>("Alert", Message);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JS { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient client { get; set; }
    }
}
#pragma warning restore 1591
