// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorApp9.Charts.Bar
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
#line 13 "C:\Users\bookp\source\repos\C-\BlazorApp9\_Imports.razor"
using BlazorApp9.ChartJs_Blazor

#nullable disable
    ;
#nullable restore
#line 2 "C:\Users\bookp\source\repos\C-\BlazorApp9\Charts\Bar\Stacked.razor"
 using ChartJs.Blazor.BarChart

#nullable disable
    ;
#nullable restore
#line 3 "C:\Users\bookp\source\repos\C-\BlazorApp9\Charts\Bar\Stacked.razor"
 using ChartJs.Blazor.BarChart.Axes

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Components.LayoutAttribute(typeof(SampleLayout))]
    [global::Microsoft.AspNetCore.Components.RouteAttribute(
    // language=Route,Component
#nullable restore
#line 1 "C:\Users\bookp\source\repos\C-\BlazorApp9\Charts\Bar\Stacked.razor"
      "/charts/bar/stacked"

#line default
#line hidden
#nullable disable
    )]
    #nullable restore
    public partial class Stacked : global::Microsoft.AspNetCore.Components.ComponentBase
    #nullable disable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 10 "C:\Users\bookp\source\repos\C-\BlazorApp9\Charts\Bar\Stacked.razor"
       
    private const int InitalCount = 7;
    private BarConfig _config;
    private Chart _chart;

    protected override void OnInitialized()
    {
        _config = new BarConfig
        {
            Options = new BarOptions
            {
                Responsive = true,
                Title = new OptionsTitle
                {
                    Display = true,
                    Text = "Chart.js Bar Chart - Stacked"
                },
                Tooltips = new Tooltips
                {
                    Mode = InteractionMode.Index,
                    Intersect = false
                },
                Scales = new BarScales
                {
                    XAxes = new List<CartesianAxis>
                    {
                        new BarCategoryAxis
                        {
                            Stacked = true
                        }
                    },
                    YAxes = new List<CartesianAxis>
                    {
                        new BarLinearCartesianAxis
                        {
                            Stacked = true
                        }
                    }
                }
            }
        };

        IDataset<int> dataset1 = new BarDataset<int>(RandomScalingFactor(InitalCount))
        {
            Label = "Dataset 1",
            BackgroundColor = ColorUtil.FromDrawingColor(ChartColors.Red)
        };

        IDataset<int> dataset2 = new BarDataset<int>(RandomScalingFactor(InitalCount))
        {
            Label = "Dataset 2",
            BackgroundColor = ColorUtil.FromDrawingColor(ChartColors.Blue)
        };

        IDataset<int> dataset3 = new BarDataset<int>(RandomScalingFactor(InitalCount))
        {
            Label = "Dataset 3",
            BackgroundColor = ColorUtil.FromDrawingColor(ChartColors.Green)
        };

        _config.Data.Labels.AddRange(Months.Take(InitalCount));
        _config.Data.Datasets.Add(dataset1);
        _config.Data.Datasets.Add(dataset2);
        _config.Data.Datasets.Add(dataset3);
    }

    private void RandomizeData()
    {
        foreach (IDataset<int> dataset in _config.Data.Datasets)
        {
            int count = dataset.Count;
            dataset.Clear();
            dataset.AddRange(RandomScalingFactor(count));
        }

        _chart.Update();
    }

#line default
#line hidden
#nullable disable

    }
}
#pragma warning restore 1591
