#pragma checksum "C:\Users\bookp\source\repos\C-\inputoutput\Pages\Ideas.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "c35070216b70278973dd0dcba32cc9338443821f3d167e3d89cc8bfc8d45918d"
// <auto-generated/>
#pragma warning disable 1591
namespace inputoutput.Pages
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\bookp\source\repos\C-\inputoutput\_Imports.razor"
using System.Net.Http

#nullable disable
    ;
#nullable restore
#line 2 "C:\Users\bookp\source\repos\C-\inputoutput\_Imports.razor"
using Microsoft.AspNetCore.Authorization

#nullable disable
    ;
#nullable restore
#line 3 "C:\Users\bookp\source\repos\C-\inputoutput\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization

#nullable disable
    ;
#nullable restore
#line 4 "C:\Users\bookp\source\repos\C-\inputoutput\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms

#nullable disable
    ;
#nullable restore
#line 5 "C:\Users\bookp\source\repos\C-\inputoutput\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing

#nullable disable
    ;
#nullable restore
#line 6 "C:\Users\bookp\source\repos\C-\inputoutput\_Imports.razor"
using Microsoft.AspNetCore.Components.Web

#nullable disable
    ;
#nullable restore
#line 7 "C:\Users\bookp\source\repos\C-\inputoutput\_Imports.razor"
using Microsoft.JSInterop

#nullable disable
    ;
#nullable restore
#line 8 "C:\Users\bookp\source\repos\C-\inputoutput\_Imports.razor"
using inputoutput

#nullable disable
    ;
#nullable restore
#line 9 "C:\Users\bookp\source\repos\C-\inputoutput\_Imports.razor"
using inputoutput.Shared

#nullable disable
    ;
#nullable restore
#line 11 "C:\Users\bookp\source\repos\C-\inputoutput\_Imports.razor"
using inputoutput.Models

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Components.RouteAttribute(
    // language=Route,Component
#nullable restore
#line 1 "C:\Users\bookp\source\repos\C-\inputoutput\Pages\Ideas.razor"
      "/Ideas"

#line default
#line hidden
#nullable disable
    )]
    #nullable restore
    public partial class Ideas : global::Microsoft.AspNetCore.Components.ComponentBase
    #nullable disable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Ideas</h3>\r\n");
#nullable restore
#line 6 "C:\Users\bookp\source\repos\C-\inputoutput\Pages\Ideas.razor"
 if (ideas == null)
{

#line default
#line hidden
#nullable disable

            __builder.AddContent(1, "    ");
            __builder.AddMarkupContent(2, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 9 "C:\Users\bookp\source\repos\C-\inputoutput\Pages\Ideas.razor"
}
else
{

#line default
#line hidden
#nullable disable

            __builder.AddContent(3, "    ");
            __builder.OpenElement(4, "table");
            __builder.AddAttribute(5, "class", "table");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.AddMarkupContent(7, "<thead>\r\n            <tr>\r\n                <th>ID</th>\r\n                <th>NOTE</th>\r\n            </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(8, "tbody");
            __builder.AddMarkupContent(9, "\r\n");
#nullable restore
#line 20 "C:\Users\bookp\source\repos\C-\inputoutput\Pages\Ideas.razor"
             foreach (var idea in ideas)
            {

#line default
#line hidden
#nullable disable

            __builder.AddContent(10, "                ");
            __builder.OpenElement(11, "tr");
            __builder.AddMarkupContent(12, "\r\n                    ");
            __builder.OpenElement(13, "td");
            __builder.AddContent(14, 
#nullable restore
#line 23 "C:\Users\bookp\source\repos\C-\inputoutput\Pages\Ideas.razor"
                         idea.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                    ");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 24 "C:\Users\bookp\source\repos\C-\inputoutput\Pages\Ideas.razor"
                         idea.Note

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n");
#nullable restore
#line 26 "C:\Users\bookp\source\repos\C-\inputoutput\Pages\Ideas.razor"
            }

#line default
#line hidden
#nullable disable

            __builder.AddContent(20, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n");
#nullable restore
#line 29 "C:\Users\bookp\source\repos\C-\inputoutput\Pages\Ideas.razor"
}

#line default
#line hidden
#nullable disable

            __builder.OpenElement(23, "input");
            __builder.AddAttribute(24, "type", "button");
            __builder.AddAttribute(25, "value", "글쓰기");
            __builder.AddAttribute(26, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 30 "C:\Users\bookp\source\repos\C-\inputoutput\Pages\Ideas.razor"
                                           btnCreate_Click

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(27, "class", "btn btn-primary");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n\r\n");
#nullable restore
#line 32 "C:\Users\bookp\source\repos\C-\inputoutput\Pages\Ideas.razor"
 if (isShow)
{

#line default
#line hidden
#nullable disable

            __builder.AddContent(29, "    ");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "class", "modal fade show");
            __builder.AddAttribute(32, "tabindex", "-1");
            __builder.AddAttribute(33, "role", "dialog");
            __builder.AddAttribute(34, "style", "display:block;");
            __builder.AddAttribute(35, "id", "myModal");
            __builder.AddMarkupContent(36, "\r\n        ");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "modal-dialog");
            __builder.AddAttribute(39, "role", "document");
            __builder.AddMarkupContent(40, "\r\n            ");
            __builder.OpenElement(41, "div");
            __builder.AddAttribute(42, "class", "modal-content");
            __builder.AddMarkupContent(43, "\r\n                ");
            __builder.OpenElement(44, "div");
            __builder.AddAttribute(45, "class", "modal-header");
            __builder.AddMarkupContent(46, "\r\n                    ");
            __builder.AddMarkupContent(47, "<h5 class=\"modal-title\">Modal title</h5>\r\n                    ");
            __builder.OpenElement(48, "button");
            __builder.AddAttribute(49, "type", "button");
            __builder.AddAttribute(50, "class", "close");
            __builder.AddAttribute(51, "data-dismiss", "modal");
            __builder.AddAttribute(52, "aria-label", "Close");
            __builder.AddAttribute(53, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 39 "C:\Users\bookp\source\repos\C-\inputoutput\Pages\Ideas.razor"
                                                                                                          btnClosed_Click

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(54, "\r\n                        ");
            __builder.AddMarkupContent(55, "<span aria-hidden=\"true\">&times;</span>\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n                ");
            __builder.OpenElement(58, "div");
            __builder.AddAttribute(59, "class", "modal-body");
            __builder.AddMarkupContent(60, "\r\n                    ");
            __builder.OpenElement(61, "form");
            __builder.AddMarkupContent(62, "\r\n                        ");
            __builder.OpenElement(63, "div");
            __builder.AddAttribute(64, "class", "form-group");
            __builder.AddMarkupContent(65, "\r\n                            ");
            __builder.AddMarkupContent(66, "<label for=\"exampleInputEmail1\">아이디어</label>\r\n                            ");
            __builder.OpenElement(67, "input");
            __builder.AddAttribute(68, "type", "text");
            __builder.AddAttribute(69, "class", "form-control");
            __builder.AddAttribute(70, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 47 "C:\Users\bookp\source\repos\C-\inputoutput\Pages\Ideas.razor"
                                                                           idea.Note

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(71, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => idea.Note = __value, idea.Note));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n                        ");
            __builder.OpenElement(74, "button");
            __builder.AddAttribute(75, "type", "button");
            __builder.AddAttribute(76, "class", "btn btn-primary");
            __builder.AddAttribute(77, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 49 "C:\Users\bookp\source\repos\C-\inputoutput\Pages\Ideas.razor"
                                                                                btnSave_Click

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(78, "Submit");
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n                        ");
            __builder.OpenElement(80, "button");
            __builder.AddAttribute(81, "type", "button");
            __builder.AddAttribute(82, "class", "btn btn-primary");
            __builder.AddAttribute(83, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 50 "C:\Users\bookp\source\repos\C-\inputoutput\Pages\Ideas.razor"
                                                                                btnClosed_Click

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(84, "Closed");
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(87, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(88, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(90, "\r\n");
#nullable restore
#line 56 "C:\Users\bookp\source\repos\C-\inputoutput\Pages\Ideas.razor"
}

#line default
#line hidden
#nullable disable

        }
        #pragma warning restore 1998
#nullable restore
#line 58 "C:\Users\bookp\source\repos\C-\inputoutput\Pages\Ideas.razor"
       
    Idea idea = new Idea();
    private bool isShow=false;
    private List<Idea> ideas;

    protected override async Task OnInitializedAsync()
    {
        //await Task.Delay(3000); //로딩중 뜨도록함
        ideas = await repository.GetIdeas();
    }
    private void btnCreate_Click()
    {
        isShow = true;
    }


    private void btnClosed_Click()
    {
        isShow = false;
        idea = new Idea();
    }

    private async Task btnSave_Click()
    {
        await repository.AddIdea(idea);
        isShow = false;
        ideas = await repository.GetIdeas();
        idea = new Idea();
    }

#line default
#line hidden
#nullable disable

        [global::Microsoft.AspNetCore.Components.InjectAttribute] private 
#nullable restore
#line 3 "C:\Users\bookp\source\repos\C-\inputoutput\Pages\Ideas.razor"
        IIdeaRepository

#line default
#line hidden
#nullable disable
         
#nullable restore
#line 3 "C:\Users\bookp\source\repos\C-\inputoutput\Pages\Ideas.razor"
                        repository

#line default
#line hidden
#nullable disable
         { get; set; }
         = default!;
    }
}
#pragma warning restore 1591
