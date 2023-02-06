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

namespace Draft
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //Models.user10Entities entities = new Models.user10Entities();

            //TypesCb.ItemsSource = entities.material_type.ToList();

            //MaterialList.ItemsSource = entities.materials.ToList();

        }

        private void TextBox_MouseEnter(object sender, MouseEventArgs e)
        {
            SearchTb.Text = "";
        }

        private void SearchTb_MouseLeave(object sender, MouseEventArgs e)
        {
            SearchTb.Text = "Введите для поиска";
        }

        

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Materials_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
