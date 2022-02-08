using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Linq.Expressions;

namespace PropertyChangedSmart1
{

    /// <summary>
    /// This is a viewmodel class where we need to implement styles.
    /// We have one style, title.
    /// </summary>
    class MyViewModel1
    {
        private string _title = "Upper Title ";
        private static int _count = 1;
        public string Title
        {
            get 
            {
                _title = _title + _count.ToString();
                _count++;
                return _title; 
            }
        }
    }


    /// <summary>
    /// This is a viewmodel class where we need to implement styles.
    /// We have one style, title.
    /// </summary>
    class MyViewModel2
    {
        private string _title = "Lower Title ";
        private static int _count = 1;
        public string Title
        {
            get
            {
                _title = _title + _count.ToString();
                _count++;
                return _title;
            }
        }
    }
}
