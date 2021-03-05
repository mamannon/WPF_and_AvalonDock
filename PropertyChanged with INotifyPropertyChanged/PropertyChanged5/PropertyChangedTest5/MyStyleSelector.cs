using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace PropertyChangedTest
{
    /// <summary>
    /// This class makes template style sorting possible. We don't use 'new' anywhere to create
    /// this, but we have included this to UserControlWindow.xaml. Template style makes things
    /// like pane title, icon or custom close event possible. You need to implement all these 
    /// custom things as propeties of your custom viewmodel, which is in this case MyViewModel.
    /// </summary>
    class MyStyleSelector : StyleSelector
    {

        public Style MyStyle { get; set; }

        public override System.Windows.Style SelectStyle(object item, System.Windows.DependencyObject container)
        {
            if (item is MyViewModel)
                return MyStyle;

            return base.SelectStyle(item, container);
        }

    }
}
