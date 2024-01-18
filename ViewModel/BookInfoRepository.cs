using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListViewMaui
{
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
}
