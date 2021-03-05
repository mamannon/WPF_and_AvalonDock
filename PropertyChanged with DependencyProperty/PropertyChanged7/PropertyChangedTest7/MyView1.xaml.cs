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
    /// This class is the workhorse. 
    /// </summary>
    public class CountModel : DependencyObject
    {

        /// <summary>
        /// This field is the core part of the program. Notice that it is static and must be
        /// static, so there is only one instance of CounterProperty in a whole application!
        /// </summary>
        public static readonly DependencyProperty CounterProperty =
            DependencyProperty.Register("Counter",
                typeof(int), // The datatype of this property.
                typeof(CountModel), // The class where this property is.
                new UIPropertyMetadata(-1  // Initial value of the property.
            ));

        /// These are the getter and setter of the CounterProperty.
        public int Counter
        {
            get { return (int)GetValue(CounterProperty); }
            set { SetValue(CounterProperty, value); }
        }

    }

    /// <summary>
    /// Interaction logic for MyView1.xaml
    /// </summary>
    public partial class MyView1 : UserControl
    {
        public MyView1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CountModel temp = TryFindResource("CounterDependency") as CountModel;

            // This is the row where counter is increased by one.
            temp.Counter++;
        }

    }
}
