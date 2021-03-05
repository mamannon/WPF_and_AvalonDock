/*
 * This Project is the first and dumbest one to introduce DependencyProperty.
 * Never combine DependencyObject and IObservable, there's a problem with static
 * and dynamic class members. And if you try to use DependencyObject and 
 * INotifyPropertyChanged, it goes impossible...
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.ComponentModel;
using System.Diagnostics;

namespace PropertyChangedTest1
{
	/// <summary>
	/// This is the carrier class of the message.
	/// </summary>
	public class UserEvent
    {
        public int number { get; set; }
        public UserEvent(int code)
        {
            number = code;
        }
    }

    /// <summary>
    /// Observer can use this to unsubscribe itself from getting messages.
    /// </summary>
    /// <typeparam name="ObserverInfo"></typeparam>
    class Unsubscriber<UserInterfaceEvent> : IDisposable
    {
        private List<IObserver<UserInterfaceEvent>> mObservers;
        private IObserver<UserInterfaceEvent> mObserver;

        internal Unsubscriber(List<IObserver<UserInterfaceEvent>> observers, IObserver<UserInterfaceEvent> observer)
        {
            mObservers = observers;
            mObserver = observer;
        }

        public void Dispose()
        {
            if (mObservers.Contains(mObserver))
            {
                mObservers.Remove(mObserver);
            }
        }
    }

    /// <summary>
    /// This class is the workhorse. 
    /// </summary>
    public class CountModel : DependencyObject, IObservable<UserEvent>
    {

        /// <summary>
        /// Maintain a list of observers.
        /// </summary>
        private static List<IObserver<UserEvent>> mObservers = new List<IObserver<UserEvent>>();

        /// <summary>
        /// Notify observers when event occurs IE the function below is called.
        /// </summary>
        protected static void NotifyChanged(int counter)
        {
            foreach (var observer in mObservers)
            {
                observer.OnNext(new UserEvent(counter));
            }
        }

        /// <summary>
        /// This is the method observers use to sing in a list to get messages.
        /// </summary>
        /// <param name="observer">UserInterfaceEvent</param>
        /// <returns></returns>
        public IDisposable Subscribe(IObserver<UserEvent> observer)
        {

            // Check whether observer is already registered. If not, add it.
            if (!mObservers.Contains(observer))
            {
                mObservers.Add(observer);
            }
            return new Unsubscriber<UserEvent>(mObservers, observer);
        }

        /// <summary>
        /// This field is the core part of the program. Notice that it is static and must be
        /// static, so there is only one instance of CounterProperty in a whole application!
        /// </summary>
        public static readonly DependencyProperty CounterProperty =
            DependencyProperty.Register("Counter",
                typeof(int), // The datatype of this property.
                typeof(CountModel), // The class where this property is.
                new FrameworkPropertyMetadata(0,  // Initial value of the property.
                    FrameworkPropertyMetadataOptions.AffectsRender, // This will force UI refresh.
                    new PropertyChangedCallback(CounterValueChanged),  // This will be called after the property value is changed.
                    new CoerceValueCallback(AdjustCounter))); // This will be called to adjust or check the correctness of the value before changing it.

        /// These are the getter and setter of the CounterProperty.
        public int Counter
        {
            get { return (int)GetValue(CounterProperty); }
            set { SetValue(CounterProperty, value); }
        }

        /// <summary>
        /// This will be called to check the correctness of CounterProperty.
        /// </summary>
        /// <param name="element"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        private static object AdjustCounter(DependencyObject element, object value)
        {
            int newValue = (int)value;
            if (newValue < 0) value = 0;

            return newValue;
        }

        /// <summary>
        /// After the CounterProperty value is changed, we need to refresh counterLabel. This
        /// could be also done much easier in a XAML file: then you don't need IObservable interface 
        /// and not even this method! Look PropertyChangedTest2...
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private static void CounterValueChanged(DependencyObject sender, DependencyPropertyChangedEventArgs args)
        {
            CountModel source = sender as CountModel;
            int counter = (int)args.NewValue;

            if (source != null)
            {
                NotifyChanged(counter);
            }
        }

    }


    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IObserver<UserEvent>
    {

        /// <summary>
        /// required to implement IObserver.
        /// </summary>
        /// <param name="provider"></param>
        public virtual void Subscribe(IObservable<UserEvent> provider)
        {
            // Subscribe to the Observable
            if (provider != null)
                provider.Subscribe(this);
        }

        /// <summary>
        /// required to implement IObserver.
        /// </summary>
        public virtual void OnCompleted()
        {
            Console.WriteLine("Observable sent OnCompleted event.");
        }

        /// <summary>
        /// required to implement IObserver.
        /// </summary>
        /// <param name="ex"></param>
        public virtual void OnError(Exception ex)
        {
            var st = new StackTrace();
            var sf = st.GetFrame(0);
            var currentMethodName = sf.GetMethod();
            Trace.WriteLine($"Exception at {currentMethodName}: {ex.Message}");
        }

        /// <summary>
        /// required to implement IObserver.
        /// </summary>
        /// <param name="ev"></param>
        public virtual void OnNext(UserEvent ev)
        {
            counterLabel.Content = ev.number;
        }

        CountModel countModel = new CountModel();

        public MainWindow()
        {
            InitializeComponent();
            counterLabel.Content = 0;
            Subscribe(countModel);
        }

        /// <summary>
        /// Here is the starting place of business logic after user has clicked button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            // This is the row where the counter is increased by one.
            countModel.Counter++;
        }
    }
}
