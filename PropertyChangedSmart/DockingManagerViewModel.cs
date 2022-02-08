using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyChangedSmart1
{

    public class DockingManagerViewModel 
    {
        public ObservableCollection<object> Documents1 { get; private set; }
        public ObservableCollection<object> Documents2 { get; private set; }

        public DockingManagerViewModel()
        {
            this.Documents1 = new ObservableCollection<object>();
            this.Documents2 = new ObservableCollection<object>();

            //Create first tab for first pane using class MyViewModel1
            object mvm = new MyViewModel1();
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
