using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Linq.Expressions;

namespace PropertyChangedTest
{

    /// <summary>
    /// This class is the viewmodel class where ew need to implement styles.
    /// We have only one style, title.
    /// </summary>
    class MyViewModel
    {

        private string _title = "MyTitle";
        public string Title
        {
            get { return _title; }
        }
    }
}
