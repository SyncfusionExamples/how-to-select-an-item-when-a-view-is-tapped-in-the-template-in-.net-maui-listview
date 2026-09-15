# How to select an item when a view is tapped in the item template in .NET MAUI ListView (SfListView)?

In [.NET MAUI ListView](https://www.syncfusion.com/maui-controls/maui-listview), you can select an item by interacting with elements in the [ItemTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_ItemTemplate). This can be achieved by binding the [SelectedItem](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_SelectedItem) property and setting the selected item through commands in the item template.

**XAML:**
```
<syncfusion:SfListView x:Name="listView" AutoFitMode="Height" ItemSpacing="3"
                         SelectedItem="{Binding SelectedItem}" BackgroundColor="#d3d3d3"
                        SelectionChanging="listView_SelectionChanging"
                         ItemsSource="{Binding BookInfoCollection}">
        <syncfusion:SfListView.ItemTemplate>
            <DataTemplate>
                <Frame HasShadow="True" BackgroundColor="Transparent" >
                    <Grid Padding="5">
                        <Grid.ColumnDefinitions>
                            <ColumnDefinition Width="*" />
                            <ColumnDefinition Width="*" />
                            <ColumnDefinition Width="*" />
                        </Grid.ColumnDefinitions>
                        <Button Text="{Binding BookName}" CommandParameter="{Binding .}" Command="{Binding BindingContext.ItemTap, Source={x:Reference listView}}" FontAttributes="Bold" FontSize="19" />
                        <Button Text="{Binding BookID}" Grid.Column="1" CommandParameter="{Binding .}" Command="{Binding BindingContext.ItemTap, Source={x:Reference listView}}" FontAttributes="Bold" FontSize="19" />
                        <Button Text="{Binding SerialNumber}" Grid.Column="2" CommandParameter="{Binding .}" Command="{Binding BindingContext.ItemTap, Source={x:Reference listView}}" FontAttributes="Bold" FontSize="19" />
                    </Grid>
                </Frame>
            </DataTemplate>
        </syncfusion:SfListView.ItemTemplate>
    </syncfusion:SfListView>
```

**C#**
```
public class BookInfoRepository : INotifyPropertyChanged
{
    private ObservableCollection<BookInfo> bookInfoCollection;
    public event PropertyChangedEventHandler PropertyChanged;
    private object selectedItem;
    private Command<object> itemTap;

    public ObservableCollection<BookInfo> BookInfoCollection
    {
        get { return bookInfoCollection; }
        set
        {
            this.bookInfoCollection = value;
            this.OnPropertyChanged("BookInfoCollection");
        }
    }

    public object SelectedItem
    {
        get { return this.selectedItem; }
        set
        {
            this.selectedItem = value;
            this.OnPropertyChanged("SelectedItem");
        }
    }

    public Command<object> ItemTap
    {
        get { return this.itemTap; }
        set
        {
            this.itemTap = value;
            this.OnPropertyChanged("ItemTap");
        }
    }

    public void OnPropertyChanged(string name)
    {
        if (this.PropertyChanged != null)
            this.PropertyChanged(this, new PropertyChangedEventArgs(name));
    }

    public BookInfoRepository()
    {
        GenerateNewBookInfo();
        ItemTap = new Command<object>(OnItemTap);
    }

    private void OnItemTap(object obj)
    {
        this.SelectedItem = obj;
    }

    private void GenerateNewBookInfo()
    {
        BookInfoCollection = new ObservableCollection<BookInfo>();
        BookInfoCollection.Add(new BookInfo() { BookName = "Book1", BookDescription = "You’ll learn several different approaches to applying machine learning", BookID = 1, SerialNumber = "9876757" });
        BookInfoCollection.Add(new BookInfo() { BookName = "Book2", BookDescription = "Object-oriented programming is the de facto programming paradigm", BookID = 2, SerialNumber = "9876457" });
        BookInfoCollection.Add(new BookInfo() { BookName = "Book3", BookDescription = "Code Contracts provide a way to convey code assumptions", BookID = 3, SerialNumber = "9876357" });
    }
}

```

Use the [SelectionChanging](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.SfListView.html#Syncfusion_Maui_ListView_SfListView_SelectionChanging) event to handle item selection logic when triggering selection through button clicks.

**C#**
```
public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void listView_SelectionChanging(object sender, Syncfusion.Maui.ListView.ItemSelectionChangingEventArgs e)
    {
        e.Cancel = true;
    }
}
```

**Output:**
 
 ![SelectItem.PNG](https://support.syncfusion.com/kb/attachment/article/14883/inline?token=eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjE2NzEyIiwib3JnaWQiOiIzIiwiaXNzIjoic3VwcG9ydC5zeW5jZnVzaW9uLmNvbSJ9.eJ7LsCKAlE3Gb_XCmaDHMx29lVpkrnhAqGGx82DPIoM)

**Conclusion**

I hope you enjoyed learning how to select an item when a view is tapped in the item template in .NET MAUI ListView.

You can refer to our [.NET MAUI ListView](https://www.syncfusion.com/maui-controls/maui-listview) feature tour page to know about its other groundbreaking feature representations and [documentation](https://help.syncfusion.com/maui/listview/getting-started), and how to quickly get started with configuration specifications. Explore our [.NET MAUI ListView example](https://github.com/syncfusion/maui-demos/tree/master/MAUI/ListView) to understand how to create and manipulate data.

You can check out our components from the [License and Downloads](https://www.syncfusion.com/sales/teamlicense) page for current customers. If you are new to Syncfusion®, try our 30-day [free trial](https://www.syncfusion.com/downloads/maui/confirm) to check out our other controls.

Please let us know in the comments section if you have any queries or require clarification. You can also contact us through our [support forums](https://www.syncfusion.com/forums), [Direct-Trac](https://support.syncfusion.com/create), or [feedback portal](https://www.syncfusion.com/feedback/maui?control=sflistview). We are always happy to assist you!
