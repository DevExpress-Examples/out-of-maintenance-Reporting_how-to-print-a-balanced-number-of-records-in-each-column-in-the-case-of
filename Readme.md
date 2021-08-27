<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128602294/19.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2029)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/WindowsApplication1/Form1.cs) (VB: [Form1.vb](./VB/WindowsApplication1/Form1.vb))
* [Program.cs](./CS/WindowsApplication1/Program.cs) (VB: [Program.vb](./VB/WindowsApplication1/Program.vb))
* [XtraReport1.cs](./CS/WindowsApplication1/XtraReport1.cs) (VB: [XtraReport1.vb](./VB/WindowsApplication1/XtraReport1.vb))
<!-- default file list end -->
# Multi-column report: How to display a balanced number of records like in AccrossThenDown mode but keep them sorted like in DownThenAccross mode


<p></br>This example illustrates how to mimic the sorting order of records in <a href="https://docs.devexpress.com/XtraReports/4786/Create-Popular-Reports/Create-a-Multi-Column-Report">DownThenAccross</a> mode, but arrange columns like in <a href="https://docs.devexpress.com/XtraReports/4786/Create-Popular-Reports/Create-a-Multi-Column-Report">AccrossThenDown</a> mode. 
To implement such a report layout, we are using a master report whose items act as group headers in AcrossThenDown mode 
and a subreport whose items look like items within groups. To sort detail report items like in DownThenAcross mode, 
we do the following:</br>
- create a custom calculated field that returns a current row index;</br>
- use this field to sort the subreport in ascending mode.</p>
<br/>





