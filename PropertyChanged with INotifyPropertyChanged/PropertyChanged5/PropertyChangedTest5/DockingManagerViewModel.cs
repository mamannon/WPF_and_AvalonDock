using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyChangedTest
{

    class DockingManagerViewModel
    {
        public ObservableCollection<MyViewModel> Documents1 { get; private set; }
        public DockingManagerViewModel()
        {
            this.Documents1 = new ObservableCollection<MyViewModel>();
            MyViewModel mvm = new MyViewModel();
 //           mvm.PropertyChanged += DockManagerViewModel_PropertyChanged;
            this.Documents1.Add(mvm);
        }
        /*
        private void DockingManagerViewModel_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            DockingManagerViewModel document = sender as DockingManagerViewModel;

            //Add code here...
        }
        */
    }
}
