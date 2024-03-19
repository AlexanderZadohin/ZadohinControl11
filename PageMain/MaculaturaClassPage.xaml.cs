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
using ZadohinControl11.Model;

namespace ZadohinControl11.PageMain
{
    /// <summary>
    /// Логика взаимодействия для MaculaturaClassPage.xaml
    /// </summary>
    public partial class MaculaturaClassPage : Page
    {
        public MaculaturaClassPage(ClassSchool accountigMaculatura)
        {
            InitializeComponent();
            GridJournal.ItemsSource = App.context.AccountigMaculatura.Where(x => x.ClassSchool.id == accountigMaculatura.id).ToList();
        }
    }
}
