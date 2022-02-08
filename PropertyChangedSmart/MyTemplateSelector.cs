using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;
//using Xceed.Wpf.AvalonDock.Layout;

namespace PropertyChangedSmart1
{


    /// <summary>
    /// This class makes template sorting possible. We don't use 'new' anywhere to create
    /// this, but we have included this to UserControlWindow.xaml.
    /// </summary>
    class MyTemplateSelector : DataTemplateSelector
    {

        public DataTemplate MyTemplate1 { get; set; }
        public DataTemplate MyTemplate2 { get; set; }

        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {

            if (item is MyViewModel1)
                return MyTemplate1;

            if (item is MyViewModel2)
                return MyTemplate2;

            return base.SelectTemplate(item, container);
        }

    }
}
