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
    /// This is a viewmodel class where we need to implement styles.
    /// We have one style, title.
    /// </summary>
    class MyViewModel
    {
        private static string _title = "MyTitle";
        public string Title
        {
            get 
            {
                _title = _title + "My";
                return _title; 
            }
        }
    }
}
