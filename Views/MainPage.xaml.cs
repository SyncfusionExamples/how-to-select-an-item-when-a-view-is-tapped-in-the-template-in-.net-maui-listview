using Syncfusion.Maui.ListView;

namespace ListViewMaui
{
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
}
