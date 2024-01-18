using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListViewMaui
{
    public class BookInfo : INotifyPropertyChanged
    {
        private string bookName;
        private string bookDescription;
        private int bookId;
        private string serialNumber;

        public BookInfo()
        {
        }

        public string BookName
        {
            get { return bookName; }
            set
            {
                bookName = value;
                OnPropertyChanged("BookName");
            }
        }


        public string BookDescription
        {
            get { return bookDescription; }
            set
            {
                bookDescription = value;
                OnPropertyChanged("BookDescription");
            }
        }

        public string SerialNumber
        {
            get { return this.serialNumber; }
            set
            {
                this.serialNumber = value;
                OnPropertyChanged("SerialNumber");
            }
        }

        public int BookID
        {
            get { return this.bookId; }
            set
            {
                this.bookId = value;
                OnPropertyChanged("BookID");
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string name)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(name));
        }
    }
}
