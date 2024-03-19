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

namespace ZadohinControl11.PageMain
{
    /// <summary>
    /// Логика взаимодействия для OtchetMachulatura.xaml
    /// </summary>
    public partial class OtchetMachulatura : Page
    {
        public OtchetMachulatura()
        {
            InitializeComponent();
        }

        private void CreateOtchetBtn_Click(object sender, RoutedEventArgs e)
        {
            string mes = "";
            if (string.IsNullOrEmpty(DTPBegin.Text))
                mes += "Выберите начальный период!\n";
            if (string.IsNullOrEmpty(DTPEnd.Text))
                mes += "Выберите окончательный период!\n";
            if (mes != "")
            {
                MessageBox.Show(mes);
                mes = "";
                return;
            }
            var a = (DateTime)DTPBegin.SelectedDate;
            var b = (DateTime)DTPEnd.SelectedDate;

            var qwery = App.context.ViewOtchet.Where(x => x.DateCollect >= a && x.DateCollect <= b).GroupBy(y => y.Name).Select(g => new { Группа = g.Key, Макулатура_кг = g.Sum(s => s.KgPaper) }).OrderByDescending(n => n.Макулатура_кг);

            //

            DG.ItemsSource = qwery.ToList();
        }
    }
}
