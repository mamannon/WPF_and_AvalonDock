using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;
//using Xceed.Wpf.AvalonDock.Layout;

namespace PropertyChangedTest
{


    /// <summary>
    /// This class makes template sorting possible. We don't use 'new' anywhere to create
    /// this, but we have included this to UserControlWindow.xaml.
    /// </summary>
    class MyTemplateSelector : DataTemplateSelector
    {

        public DataTemplate MyTemplate { get; set; }

        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {

            if (item is MyViewModel)
                return MyTemplate;

            return base.SelectTemplate(item, container);
        }

    }
}
