<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128650049/22.2.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1637)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
# WPF Data Grid - How to Display Group Summaries

This example shows how to calculate group summaries and display them within group rows. A group summary is a value of the aggregate function calculated over all data rows within a group. The [GridControl](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.GridControl)'s [GroupSummary](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.GridControl.GroupSummary) collection stores group summary items.

This example uses the [GridControl.CustomSummaryExists](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.GridControl.CustomSummaryExists) event / [GridControl.CustomSummaryExistsCommand](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.GridControl.CustomSummaryExistsCommand) property to calculate group summaries only for the top group level.

![](https://docs.devexpress.com/WPF/images/GridControl_CustomSummaryExistsCommand.png)

<!-- default file list -->

## Files to Look At

### Code Behind Technique

- [MainWindow.xaml](./CS/DisplayGroupSummaries_CodeBehind/MainWindow.xaml) ([MainWindow.xaml](./VB/DisplayGroupSummaries_CodeBehind/MainWindow.xaml))
- [MainWindow.xaml.cs](./CS/DisplayGroupSummaries_CodeBehind/MainWindow.xaml.cs#L62-L64) ([MainWindow.xaml.vb](./VB/DisplayGroupSummaries_CodeBehind/MainWindow.xaml.vb#L64-L66))

### MVVM Technique

- [MainWindow.xaml](./CS/DisplayGroupSummaries_MVVM/MainWindow.xaml) ([MainWindow.xaml](./VB/DisplayGroupSummaries_MVVM/MainWindow.xaml))
- [MainViewModel.cs](./CS/DisplayGroupSummaries_MVVM/MainViewModel.cs#L54-L57) ([MainViewModel.vb](./VB/DisplayGroupSummaries_MVVM/MainViewModel.vb#L56-L59))

<!-- default file list end -->

## Documentation

- [Data Summaries](https://docs.devexpress.com/WPF/7354/controls-and-libraries/data-grid/data-summaries)
- [Group Summary](https://docs.devexpress.com/WPF/6127/controls-and-libraries/data-grid/data-summaries/group-summary)
- [GridControl.CustomSummaryExists](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.GridControl.CustomSummaryExists)
- [GridControl.CustomSummaryExistsCommand](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.GridControl.CustomSummaryExistsCommand)

## More Examples

- [How to Display Total Summaries](https://github.com/DevExpress-Examples/how-to-display-total-summaries-e1636)
- [How to Use Custom Summaries](https://github.com/DevExpress-Examples/how-to-summarize-empty-cells-e948)
- [How to calculate custom Node Summaries in TreeListView](https://github.com/DevExpress-Examples/how-to-calculate-custom-node-summaries-in-treelistview-t506349)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-data-grid-display-group-summaries&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-data-grid-display-group-summaries&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
