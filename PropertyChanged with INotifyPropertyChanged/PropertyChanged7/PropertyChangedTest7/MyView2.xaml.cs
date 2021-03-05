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
using System.ComponentModel;

namespace PropertyChangedTest
{
    /// <summary>
    /// Interaction logic for MyView2.xaml
    /// </summary>
    public partial class MyView2 : UserControl
    {

        private CountModel countModel = new CountModel();

        public MyView2()
        {
            InitializeComponent();
            counterLabel.DataContext = countModel;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            countModel.Counter--;
        }

    }
}
