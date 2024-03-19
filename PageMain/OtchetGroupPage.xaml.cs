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
using ZadohinControl11.Class;
using ZadohinControl11.Model;

namespace ZadohinControl11.PageMain
{
    /// <summary>
    /// Логика взаимодействия для OtchetGroupPage.xaml
    /// </summary>
    public partial class OtchetGroupPage : Page
    {
        public OtchetGroupPage()
        {
            InitializeComponent();

            TypeClassCmb.ItemsSource = App.context.TypeClass.ToList();
            TypeClassCmb.DisplayMemberPath = "Name";
            TypeClassCmb.SelectedValuePath = "id";

            DataGridInfo.ItemsSource = App.context.ClassSchool.ToList();
        }

        private void SpisocBtn_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.FrameBody.Navigate(new PageMain.MaculaturaClassPage((sender as Button).DataContext as ClassSchool));
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            int selectedDS = Convert.ToInt32(TypeClassCmb.SelectedValue);

            DataGridInfo.ItemsSource = App.context.ClassSchool.Where(x => x.TypeClass.id == selectedDS).ToList();
        }
    }
}
