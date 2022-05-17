using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Collections.ObjectModel;


namespace ExpenseIt
{
    
    public partial class ExpenseItHome :  Window, INotifyPropertyChanged
    {

        private DateTime lastChecked;
        public event PropertyChangedEventHandler PropertyChanged;
        public DateTime LastChecked
        {
            get { return lastChecked; }
            set
            {
                lastChecked = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("LastChecked"));
            }
        }

        public ObservableCollection<string> PersonsChecked
        { get; set; }
        public ExpenseItHome()
        {
            InitializeComponent();
            PersonsChecked = new ObservableCollection<string>();
            ListBoxItem person1 = new ListBoxItem();
            person1.Content = "Yoana";
            peopleListBox.Items.Add(person1);
            ListBoxItem person2 = new ListBoxItem();
            person2.Content = "Didi";
            peopleListBox.Items.Add(person2);
            peopleListBox.SelectedItem = person1;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ExpenseReport window = new ExpenseReport();
            window.Height = this.Height;
            window.Width = this.Width;
            window.Show();
            this.Close();

        }
        private void peopleListBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

            PersonsChecked.Add((peopleListBox.SelectedItem as
            System.Xml.XmlElement).Attributes["Name"].Value);
            LastChecked = DateTime.Now;
        }
        
    }
}
