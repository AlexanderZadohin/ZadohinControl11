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
    /// Логика взаимодействия для UcetCollectMaculatura.xaml
    /// </summary>
    public partial class UcetCollectMaculatura : Page
    {
        public UcetCollectMaculatura()
        {
            InitializeComponent();

            ParalelCmb.ItemsSource = App.context.TypeClass.ToList();
            ParalelCmb.DisplayMemberPath = "Name";
            ParalelCmb.SelectedValuePath = "id";

            GroupCmb.ItemsSource = App.context.ClassSchool.ToList();
            GroupCmb.DisplayMemberPath = "Name";
            GroupCmb.SelectedValuePath = "id";
        }

        private void AddAccountingBtn_Click(object sender, RoutedEventArgs e)
        {

            string mes = "";
            if (GroupCmb.Text == "")
                mes += "Выберите группу!\n";
            if (ParalelCmb.Text == "")
                mes += "Выберите паралель!\n";
            if (DTPicker.Text == "")
                mes += "Выберите дату сдачу макулатуры\n";
            if (KgTb.Text == "")
                mes += "Введите количество сданной маккулатурой\n";
            if(mes != "")
            {
                MessageBox.Show(mes);
                return;
            }
                AccountigMaculatura addAccounting = new AccountigMaculatura 
                {
                ClassSchool = GroupCmb.SelectedItem as ClassSchool,
                KgPaper = Convert.ToDecimal(KgTb.Text),
                DateCollect = Convert.ToDateTime(DTPicker.Text)
                };
                App.context.AccountigMaculatura.Add(addAccounting);
                App.context.SaveChanges();
                MessageBox.Show("Запись добавлена");

                GroupCmb.Text = "";
                DTPicker.Text = "";
                ParalelCmb.Text = "";
                KgTb.Text = "";
        }

        private void ParalelCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int selectedParalel = Convert.ToInt32(ParalelCmb.SelectedValue);
            GroupCmb.ItemsSource = App.context.ClassSchool.Where(g => g.idType == selectedParalel).ToList();
        }
    }
}
