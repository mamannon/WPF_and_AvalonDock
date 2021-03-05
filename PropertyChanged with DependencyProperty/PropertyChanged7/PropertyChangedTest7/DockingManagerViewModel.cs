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
        public ObservableCollection<MyViewModel> Documents2 { get; private set; }

        public DockingManagerViewModel()
        {
            this.Documents1 = new ObservableCollection<MyViewModel>();
            this.Documents2 = new ObservableCollection<MyViewModel>();

            //Create first tab for first pane using class MyViewModel1
            MyViewModel mvm = new MyViewModel1();
            this.Documents1.Add(mvm);

            //Create second tab for first pane using class MyViewModel1
            mvm = new MyViewModel1();
            this.Documents1.Add(mvm);

            //Create first tab for second pane using class MyViewModel2
            mvm = new MyViewModel2();
            this.Documents2.Add(mvm);

            //Create second tab for second pane using class MyViewModel2
            mvm = new MyViewModel2();
            this.Documents2.Add(mvm);
        }
    }
}
