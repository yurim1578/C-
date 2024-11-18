// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorApp9.Pages.Demos.Charts
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\bookp\source\repos\C-\BlazorApp9\_Imports.razor"
using System.Net.Http

#nullable disable
    ;
#nullable restore
#line 2 "C:\Users\bookp\source\repos\C-\BlazorApp9\_Imports.razor"
using Microsoft.AspNetCore.Authorization

#nullable disable
    ;
#nullable restore
#line 3 "C:\Users\bookp\source\repos\C-\BlazorApp9\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization

#nullable disable
    ;
#nullable restore
#line 4 "C:\Users\bookp\source\repos\C-\BlazorApp9\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms

#nullable disable
    ;
#nullable restore
#line 5 "C:\Users\bookp\source\repos\C-\BlazorApp9\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing

#nullable disable
    ;
#nullable restore
#line 6 "C:\Users\bookp\source\repos\C-\BlazorApp9\_Imports.razor"
using Microsoft.AspNetCore.Components.Web

#nullable disable
    ;
#nullable restore
#line 7 "C:\Users\bookp\source\repos\C-\BlazorApp9\_Imports.razor"
using Microsoft.JSInterop

#nullable disable
    ;
#nullable restore
#line 8 "C:\Users\bookp\source\repos\C-\BlazorApp9\_Imports.razor"
using BlazorApp9

#nullable disable
    ;
#nullable restore
#line 10 "C:\Users\bookp\source\repos\C-\BlazorApp9\_Imports.razor"
using BlazorApp9.Shared

#nullable disable
    ;
#nullable restore
#line 11 "C:\Users\bookp\source\repos\C-\BlazorApp9\_Imports.razor"
using ChartJs.Blazor;

#nullable disable
#nullable restore
#line 2 "C:\Users\bookp\source\repos\C-\BlazorApp9\Pages\Demos\Charts\ChartJsDemo.razor"
 using ChartJs.Blazor.Common

#nullable disable
    ;
#nullable restore
#line 3 "C:\Users\bookp\source\repos\C-\BlazorApp9\Pages\Demos\Charts\ChartJsDemo.razor"
 using ChartJs.Blazor.PieChart

#nullable disable
    ;
#nullable restore
#line 4 "C:\Users\bookp\source\repos\C-\BlazorApp9\Pages\Demos\Charts\ChartJsDemo.razor"
 using ChartJs.Blazor.Util

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Components.RouteAttribute(
    // language=Route,Component
#nullable restore
#line 1 "C:\Users\bookp\source\repos\C-\BlazorApp9\Pages\Demos\Charts\ChartJsDemo.razor"
      "/ChartJsDemo"

#line default
#line hidden
#nullable disable
    )]
    #nullable restore
    public partial class ChartJsDemo : global::Microsoft.AspNetCore.Components.ComponentBase
    #nullable disable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 16 "C:\Users\bookp\source\repos\C-\BlazorApp9\Pages\Demos\Charts\ChartJsDemo.razor"
       
    private PieConfig _config;

    protected override void OnInitialized()
    {
        _config = new PieConfig
            {
                Options = new PieOptions
                {
                    Responsive = true,
                    Title = new OptionsTitle
                    {
                        Display = true,
                        Text = "ChartJs.Blazor Pie Chart"
                    }
                }
            };

        foreach (string color in new[] { "Red", "Yellow", "Green", "Blue" })
        {
            _config.Data.Labels.Add(color);
        }

        PieDataset<int> dataset = new PieDataset<int>(new[] { 6, 5, 3, 7 })
            {
                BackgroundColor = new[]
                {
            ColorUtil.ColorHexString(255, 99, 132), // Slice 1 aka "Red"
            ColorUtil.ColorHexString(255, 205, 86), // Slice 2 aka "Yellow"
            ColorUtil.ColorHexString(75, 192, 192), // Slice 3 aka "Green"
            ColorUtil.ColorHexString(54, 162, 235), // Slice 4 aka "Blue"
        }
            };

        _config.Data.Datasets.Add(dataset);
    }

#line default
#line hidden
#nullable disable

    }
}
#pragma warning restore 1591
