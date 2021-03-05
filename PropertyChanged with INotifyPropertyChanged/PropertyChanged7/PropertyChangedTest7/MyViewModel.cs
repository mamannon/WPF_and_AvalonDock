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
    /// This is the base viewmodel class. It includes INotifyPropertyChanged
    /// interface to make possible to update ContentId property. However,
    /// we don't use ContentId in this solution and INotifyPropertyChanged
    /// is redundant here.
    /// </summary>
    class MyViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

    /// <summary>
    /// This is a viewmodel class where we need to implement styles.
    /// We have one style, title.
    /// </summary>
    class MyViewModel1 : MyViewModel
    {
        private static string _title = "MyTitle1";
        public string Title
        {
            get 
            {
                _title = _title + "My";
                return _title; 
            }
        }
/*
        private string _contentId = null;
        public string ContentId
        {
            get { return _contentId; }
            set
            {
                if (_contentId != value)
                {
                    _contentId = value;
                    OnPropertyChanged("ContentId");
                }
            }
        }
*/
    }


    /// <summary>
    /// This is a viewmodel class where we need to implement styles.
    /// We have one style, title.
    /// </summary>
    class MyViewModel2 : MyViewModel
    {
        private static string _title = "MyTitle2";
        public string Title
        {
            get
            {
                _title = _title + "My";
                return _title;
            }
        }
/*
        private string _contentId = null;
        public string ContentId
        {
            get { return _contentId; }
            set
            {
                if (_contentId != value)
                {
                    _contentId = value;
                    OnPropertyChanged("ContentId");
                }
            }
        }
*/
    }
}
