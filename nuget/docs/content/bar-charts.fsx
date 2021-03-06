(*** hide ***)
#r "../../bin/Newtonsoft.Json.dll"
#r "../../bin/FSharp.Plotly.dll"

(** 
# FSharp.Plotly: Bar and Column Charts

*Summary:* This example shows how to create bar and a column charts in F#.

A bar chart or bar graph is a chart that presents grouped data with rectangular bars with 
lengths proportional to the values that they represent. The bars can be plotted vertically
or horizontally. A vertical bar chart is called a column bar chart.
*)

open FSharp.Plotly 
  
let values = [20; 14; 23;]
let keys   = ["Product A"; "Product B"; "Product C";]
let labels = ["27% market share"; "24% market share"; "19% market share";]

(*** define-output:bar1 ***)
Chart.Column(keys,values,Labels=labels,Opacity=0.3,Marker=Options.Marker(Color="rgba(222,45,38,0.8)"))
(*** include-it:bar1 ***)

(*** define-output:bar2 ***)
Chart.Bar(keys,values)
(*** include-it:bar2 ***)


(** 

## Stacked bar chart or column charts
The following example shows how to create a stacked bar chart by combining bar charts created by  `Chart.StackedBar` 
*)


(*** define-output:bar3 ***)
[
    Chart.StackedBar(keys,values,Name="old");
    Chart.StackedBar(keys,[8; 21; 13;],Name="new")
]
|> Chart.Combine
(*** include-it:bar3 ***)
