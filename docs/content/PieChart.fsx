(*** hide ***)
#r "../../bin/Newtonsoft.Json.dll"
#r "../../bin/FSharp.Plotly.dll"

(** 
# F# Charting: Pie and Doughnut Charts

*Summary:* This example shows how to create pie and doughnut charts in F#.

A pie or a doughnut chart can be created using the `Chart.Pie` and `Chart.Doughnut` functions.
When creating pie or doughnut charts, it is usually desirable to provide both labels and 
values.
*)

open FSharp.Plotly


let values = [19; 26; 55;]
let labels = ["Residential"; "Non-Residential"; "Utility"]


(*** define-output:pie1 ***)
Chart.Pie(values,labels)
|> Chart.Show
(*** include-it:pie1 ***)
