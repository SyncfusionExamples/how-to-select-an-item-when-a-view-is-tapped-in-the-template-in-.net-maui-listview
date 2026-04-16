# how-to-select-an-item-when-a-view-is-tapped-in-the-template-in-.net-maui-listview

This example demonstrates how to select an item when a view is tapped in the template in .NET MAUI ListView (SfListView).

## Sample

```xaml
<syncfusion:SfListView
        x:Name="listView"
        AutoFitMode="Height"
        BackgroundColor="#d3d3d3"
        ItemSpacing="3"
        ItemsSource="{Binding BookInfoCollection}"
        SelectedItem="{Binding SelectedItem}"
        SelectionChanging="listView_SelectionChanging">
        <syncfusion:SfListView.ItemTemplate>
            <DataTemplate>
                <Frame BackgroundColor="Transparent" HasShadow="True">
                    <Grid Padding="5">
                        <Grid.ColumnDefinitions>
                            <ColumnDefinition Width="*" />
                            <ColumnDefinition Width="*" />
                            <ColumnDefinition Width="*" />
                        </Grid.ColumnDefinitions>
                        <Button
                            Command="{Binding BindingContext.ItemTap, Source={x:Reference listView}}"
                            CommandParameter="{Binding .}"
                            FontAttributes="Bold"
                            FontSize="19"
                            Text="{Binding BookName}" />
                        <Button
                            Grid.Column="1"
                            Command="{Binding BindingContext.ItemTap, Source={x:Reference listView}}"
                            CommandParameter="{Binding .}"
                            FontAttributes="Bold"
                            FontSize="19"
                            Text="{Binding BookID}" />
                        <Button
                            Grid.Column="2"
                            Command="{Binding BindingContext.ItemTap, Source={x:Reference listView}}"
                            CommandParameter="{Binding .}"
                            FontAttributes="Bold"
                            FontSize="19"
                            Text="{Binding SerialNumber}" />
                    </Grid>
                </Frame>
            </DataTemplate>
        </syncfusion:SfListView.ItemTemplate>
</syncfusion:SfListView>
```

```C#
private void listView_SelectionChanging(object sender, Syncfusion.Maui.ListView.ItemSelectionChangingEventArgs e)
{
    e.Cancel = true;
}

```

## Requirements to run the demo

* [Visual Studio 2017](https://visualstudio.microsoft.com/downloads/) or [Visual Studio for Mac](https://visualstudio.microsoft.com/vs/mac/)
* Xamarin add-ons for Visual Studio (available via the Visual Studio installer).

## Troubleshooting

### Path too long exception

If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.
