using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyChangedTest
{
    class UserControlWindowViewModel
    {

        public DockingManagerViewModel DockingManagerViewModel { get; set; }

        public UserControlWindowViewModel()
        {
            DockingManagerViewModel = new DockingManagerViewModel();
        }

    }
}
