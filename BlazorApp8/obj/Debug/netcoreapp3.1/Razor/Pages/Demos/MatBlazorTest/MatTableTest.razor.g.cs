#pragma checksum "C:\Users\bookp\source\repos\C-\BlazorApp8\Pages\Demos\MatBlazorTest\MatTableTest.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5afec3313d61f141793729d197e066e34f30543cae6e12430fe8a9dcbd3f660d"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp8.Pages.Demos.MatBlazorTest
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\bookp\source\repos\C-\BlazorApp8\_Imports.razor"
using System.Net.Http

#nullable disable
    ;
#nullable restore
#line 2 "C:\Users\bookp\source\repos\C-\BlazorApp8\_Imports.razor"
using Microsoft.AspNetCore.Authorization

#nullable disable
    ;
#nullable restore
#line 3 "C:\Users\bookp\source\repos\C-\BlazorApp8\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization

#nullable disable
    ;
#nullable restore
#line 4 "C:\Users\bookp\source\repos\C-\BlazorApp8\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms

#nullable disable
    ;
#nullable restore
#line 5 "C:\Users\bookp\source\repos\C-\BlazorApp8\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing

#nullable disable
    ;
#nullable restore
#line 6 "C:\Users\bookp\source\repos\C-\BlazorApp8\_Imports.razor"
using Microsoft.AspNetCore.Components.Web

#nullable disable
    ;
#nullable restore
#line 7 "C:\Users\bookp\source\repos\C-\BlazorApp8\_Imports.razor"
using Microsoft.JSInterop

#nullable disable
    ;
#nullable restore
#line 8 "C:\Users\bookp\source\repos\C-\BlazorApp8\_Imports.razor"
using BlazorApp8

#nullable disable
    ;
#nullable restore
#line 9 "C:\Users\bookp\source\repos\C-\BlazorApp8\_Imports.razor"
using BlazorApp8.Shared

#nullable disable
    ;
#nullable restore
#line 10 "C:\Users\bookp\source\repos\C-\BlazorApp8\_Imports.razor"
using MatBlazor

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Components.RouteAttribute(
    // language=Route,Component
#nullable restore
#line 1 "C:\Users\bookp\source\repos\C-\BlazorApp8\Pages\Demos\MatBlazorTest\MatTableTest.razor"
      "/MatTableTest"

#line default
#line hidden
#nullable disable
    )]
    #nullable restore
    public partial class MatTableTest : global::Microsoft.AspNetCore.Components.ComponentBase
    #nullable disable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>MatTableTest</h3>\r\n");
            global::__Blazor.BlazorApp8.Pages.Demos.MatBlazorTest.MatTableTest.TypeInference.CreateMatTable_0(__builder, 1, 2, 
#nullable restore
#line 4 "C:\Users\bookp\source\repos\C-\BlazorApp8\Pages\Demos\MatBlazorTest\MatTableTest.razor"
                  cars

#line default
#line hidden
#nullable disable
            , 3, "mat-elevation-z5", 4, (__builder2) => {
                __builder2.AddMarkupContent(5, "\r\n        ");
                __builder2.AddMarkupContent(6, "<th>Name</th>\r\n        ");
                __builder2.AddMarkupContent(7, "<th>Price</th>\r\n        ");
                __builder2.AddMarkupContent(8, "<th>Horsepower</th>\r\n    ");
            }
            , 9, (context) => (__builder2) => {
                __builder2.AddMarkupContent(10, "\r\n        ");
                __builder2.OpenElement(11, "td");
                __builder2.AddContent(12, 
#nullable restore
#line 11 "C:\Users\bookp\source\repos\C-\BlazorApp8\Pages\Demos\MatBlazorTest\MatTableTest.razor"
             context.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(13, "\r\n        ");
                __builder2.OpenElement(14, "td");
                __builder2.AddContent(15, 
#nullable restore
#line 12 "C:\Users\bookp\source\repos\C-\BlazorApp8\Pages\Demos\MatBlazorTest\MatTableTest.razor"
             string.Format("${0:f2}", @context.Price)

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(16, "\r\n        ");
                __builder2.OpenElement(17, "td");
                __builder2.AddContent(18, 
#nullable restore
#line 13 "C:\Users\bookp\source\repos\C-\BlazorApp8\Pages\Demos\MatBlazorTest\MatTableTest.razor"
             context.Horsepower

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(19, "\r\n    ");
            }
            );
        }
        #pragma warning restore 1998
#nullable restore
#line 18 "C:\Users\bookp\source\repos\C-\BlazorApp8\Pages\Demos\MatBlazorTest\MatTableTest.razor"
 

    public class Car
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Horsepower { get; set; }

        public Car(string name, double price, int horsepower)
        {
            Name = name;
            Price = price;
            Horsepower = horsepower;
        }
    }

    Car[] cars = new[]
    {
                new Car("Volkswagen Golf", 10000, 220),
                new Car("Volkswagen Passat", 11000, 240),
                new Car("Volkswagen Polo", 12000, 110),
                new Car("Ford Focus", 13000, 200),
                new Car("Ford Fiesta", 14000, 160),
                new Car("Ford Fusion", 15000, 260),
                new Car("Ford Mondeo", 16000, 120),
            };

        

#line default
#line hidden
#nullable disable

    }
}
namespace __Blazor.BlazorApp8.Pages.Demos.MatBlazorTest.MatTableTest
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMatTable_0<TableItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TableItem> __arg0, int __seq1, global::System.Object __arg1, int __seq2, global::Microsoft.AspNetCore.Components.RenderFragment __arg2, int __seq3, global::Microsoft.AspNetCore.Components.RenderFragment<TableItem> __arg3)
        {
        __builder.OpenComponent<global::MatBlazor.MatTable<TableItem>>(seq);
        __builder.AddAttribute(__seq0, "Items", (object)__arg0);
        __builder.AddAttribute(__seq1, "class", (object)__arg1);
        __builder.AddAttribute(__seq2, "MatTableHeader", (object)__arg2);
        __builder.AddAttribute(__seq3, "MatTableRow", (object)__arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591