#pragma checksum "C:\Users\bookp\source\repos\BlazorApp4\Pages\Demos\Bonus\Bonus.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "cb2797bf27f8492a66537f5bb4b83d43aa2eab49bcb7fad6bd2c1a0b98816aa6"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp4.Pages.Demos.Bonus
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\bookp\source\repos\BlazorApp4\_Imports.razor"
using System.Net.Http

#nullable disable
    ;
#nullable restore
#line 2 "C:\Users\bookp\source\repos\BlazorApp4\_Imports.razor"
using Microsoft.AspNetCore.Authorization

#nullable disable
    ;
#nullable restore
#line 3 "C:\Users\bookp\source\repos\BlazorApp4\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization

#nullable disable
    ;
#nullable restore
#line 4 "C:\Users\bookp\source\repos\BlazorApp4\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms

#nullable disable
    ;
#nullable restore
#line 5 "C:\Users\bookp\source\repos\BlazorApp4\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing

#nullable disable
    ;
#nullable restore
#line 6 "C:\Users\bookp\source\repos\BlazorApp4\_Imports.razor"
using Microsoft.AspNetCore.Components.Web

#nullable disable
    ;
#nullable restore
#line 7 "C:\Users\bookp\source\repos\BlazorApp4\_Imports.razor"
using Microsoft.JSInterop

#nullable disable
    ;
#nullable restore
#line 8 "C:\Users\bookp\source\repos\BlazorApp4\_Imports.razor"
using BlazorApp4

#nullable disable
    ;
#nullable restore
#line 9 "C:\Users\bookp\source\repos\BlazorApp4\_Imports.razor"
using BlazorApp4.Shared

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Components.RouteAttribute(
    // language=Route,Component
#nullable restore
#line 1 "C:\Users\bookp\source\repos\BlazorApp4\Pages\Demos\Bonus\Bonus.razor"
      "/Bonus"

#line default
#line hidden
#nullable disable
    )]
    #nullable restore
    public partial class Bonus : global::Microsoft.AspNetCore.Components.ComponentBase
    #nullable disable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>용돈 나누기</h3>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "budget");
            __builder.AddMarkupContent(3, "\r\n");
#nullable restore
#line 7 "C:\Users\bookp\source\repos\BlazorApp4\Pages\Demos\Bonus\Bonus.razor"
  foreach (var item in budgetItems)
    {

#line default
#line hidden
#nullable disable

            __builder.AddContent(4, "        ");
            __builder.OpenElement(5, "span");
            __builder.AddContent(6, 
#nullable restore
#line 9 "C:\Users\bookp\source\repos\BlazorApp4\Pages\Demos\Bonus\Bonus.razor"
               item.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.OpenElement(8, "span");
            __builder.AddContent(9, 
#nullable restore
#line 10 "C:\Users\bookp\source\repos\BlazorApp4\Pages\Demos\Bonus\Bonus.razor"
               item.Amount.ToString("c0")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n        ");
            __builder.OpenElement(11, "input");
            __builder.AddAttribute(12, "type", "range");
            __builder.AddAttribute(13, "max", 
#nullable restore
#line 11 "C:\Users\bookp\source\repos\BlazorApp4\Pages\Demos\Bonus\Bonus.razor"
                                   item.Amount+Remaining

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(14, "step", "1000");
            __builder.AddAttribute(15, "style", "width:" + (
#nullable restore
#line 14 "C:\Users\bookp\source\repos\BlazorApp4\Pages\Demos\Bonus\Bonus.razor"
                           100*(item.Amount+Remaining)/totalBudget

#line default
#line hidden
#nullable disable
            ) + "%");
            __builder.AddAttribute(16, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 12 "C:\Users\bookp\source\repos\BlazorApp4\Pages\Demos\Bonus\Bonus.razor"
                    item.Amount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "oninput", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => item.Amount = __value, item.Amount));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n");
#nullable restore
#line 16 "C:\Users\bookp\source\repos\BlazorApp4\Pages\Demos\Bonus\Bonus.razor"
    }

#line default
#line hidden
#nullable disable

            __builder.AddContent(19, "    ");
            __builder.AddMarkupContent(20, "<span>유림 : </span>\r\n    ");
            __builder.OpenElement(21, "span");
            __builder.AddContent(22, 
#nullable restore
#line 18 "C:\Users\bookp\source\repos\BlazorApp4\Pages\Demos\Bonus\Bonus.razor"
           Remaining.ToString("c0")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n");
            __builder.OpenElement(25, "button");
            __builder.AddAttribute(26, "class", "btn btn-primary");
            __builder.AddAttribute(27, "disabled", 
#nullable restore
#line 20 "C:\Users\bookp\source\repos\BlazorApp4\Pages\Demos\Bonus\Bonus.razor"
                                            Remaining>0

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(28, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 20 "C:\Users\bookp\source\repos\BlazorApp4\Pages\Demos\Bonus\Bonus.razor"
                                                                    btnSave_Click

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(29, "완료");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 21 "C:\Users\bookp\source\repos\BlazorApp4\Pages\Demos\Bonus\Bonus.razor"
       
    //총 예산
    decimal totalBudget = 1_000_000;

    //남은 양
    public decimal Remaining => totalBudget - budgetItems.Sum(b => b.Amount);

    //예산 항목
    List<BudgetItem> budgetItems = new List<BudgetItem>
    {
        new BudgetItem{ Name = "엄마"},
        new BudgetItem{ Name = "아빠"},
        new BudgetItem{ Name = "진범"},                 
        new BudgetItem{ Name = "윤영"}
    };
    //완료메시지 출력
    void btnSave_Click()
    {
        JS.InvokeAsync<object>("alert", "용돈 나누기 완료");
    }

#line default
#line hidden
#nullable disable

        [global::Microsoft.AspNetCore.Components.InjectAttribute] private 
#nullable restore
#line 2 "C:\Users\bookp\source\repos\BlazorApp4\Pages\Demos\Bonus\Bonus.razor"
        IJSRuntime

#line default
#line hidden
#nullable disable
         
#nullable restore
#line 2 "C:\Users\bookp\source\repos\BlazorApp4\Pages\Demos\Bonus\Bonus.razor"
                   JS

#line default
#line hidden
#nullable disable
         { get; set; }
         = default!;
    }
}
#pragma warning restore 1591
