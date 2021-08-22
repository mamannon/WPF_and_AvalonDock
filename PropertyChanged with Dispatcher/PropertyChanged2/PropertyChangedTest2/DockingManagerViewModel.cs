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
        public ObservableCollection<object> Documents1 { get; private set; }

        public DockingManagerViewModel()
        {

            this.Documents1 = new ObservableCollection<object>();
            MyViewModel mvm = new MyViewModel();
            this.Documents1.Add(mvm);
        }
    }
}
