using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFhello
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ListBoxItem james = new ListBoxItem();
            james.Content = "James";
            peopleListBox.Items.Add(james);
            ListBoxItem david = new ListBoxItem();
            david.Content = "David";
            peopleListBox.Items.Add(david);
            peopleListBox.SelectedItem = james;
          
        }

        private void btnHello_Click(object sender, RoutedEventArgs e)
        {
            

            if (txtName.Text.Length > 2)
            {
                MessageBox.Show("Здрасти, " + txtName.Text + "!!!\nТова е твоята първа програма на Visual Studio 2022!!!");
                /* сметки, които не схванах и
                foreach (var item in MainGrid.Children)
                {
                    if (item is TextBox)
                    {
                        s = s + ((TextBox)item).Text;
                        s = s + '\n';
                    } 
                } */

            }
            else
                MessageBox.Show("Името трябва да бъде по-дълго от 2 символа!");
        }
        
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Желаете ли да затворите приложението?", "Затваряне", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (result == MessageBoxResult.No)
                e.Cancel = true;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           // MessageBox.Show("This is Windows Presentation Foundation!");
            //textBlock1.Text = DateTime.Now.ToString();
            MyMessage anotherWindow = new MyMessage();
            anotherWindow.Show();
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btnGreeting_Click(object sender, RoutedEventArgs e)
        {
            string greetingMsg;
            greetingMsg = (peopleListBox.SelectedItem as ListBoxItem).Content.ToString();

            MessageBox.Show("Hi " + greetingMsg);
        }
    }
}