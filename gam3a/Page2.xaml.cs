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

namespace gam3a
{
    /// <summary>
    /// Interaction logic for Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        public Page2()
        {
            InitializeComponent();
        }

        private void save_btn(object sender, RoutedEventArgs e)
        {

        }

        private void open_btn(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Students st = new Students();
            st.peo_namem = name_tb.Text;
            st.peo_age = age_tb.Text;
            st.peo_address= address_tb.Text;
            st.Dep_name = department_tb.Text;
            db.Students .Add(st);
            db.Savechanges();

            MessageBox.Show("successfully aded");



        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Page1 pg = new Page1();
            NavigationService.Navigate(pg);
        }
    }
}
