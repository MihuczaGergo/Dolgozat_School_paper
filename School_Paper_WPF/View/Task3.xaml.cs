using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using ConsoleApp.Data;
using ConsoleApp.Models;

namespace School_Paper_WPF.View
{
    /// <summary>
    /// Interaction logic for Task3.xaml
    /// </summary>
    public partial class Task3 : UserControl
    {
        public ObservableCollection<People> Emberek;
        public Context _context;
        public Task3()
        {
            InitializeComponent();
            Emberek = new ObservableCollection<People>();
            _context = new Context();
            ReflesPeople();
            ListBox_Emberek.ItemsSource = Emberek;
            StackPanel_Input.DataContext = Emberek;
        }
        private void ReflesPeople()
        {
            Emberek.Clear();
            if (_context.People.Any())
            {
                foreach(var item in _context.People)
                {
                    Emberek.Add((People)item);
                }
            }
            else
            {
                Emberek.Add(new People());
            }
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            People ember = ListBox_Emberek.SelectedItem as People;
            if(ember.Name != null)
            {
                _context.People.Update(ember);
                _context.SaveChanges();
                ReflesPeople();
                ListBox_Emberek.SelectedItem = ember;
            }
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            People ember = ListBox_Emberek.SelectedItem as People;
            if (ember != null && ember.Id != 0)
            {
                int index = ListBox_Emberek.SelectedIndex;
                _context.People.Remove(ember);
                _context.SaveChanges();
                ReflesPeople();
                ListBox_Emberek.SelectedIndex = index<ListBox_Emberek.Items.Count?index:ListBox_Emberek.Items.Count-1;
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}