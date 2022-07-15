The PropertyChangedTest1 is the first and easiest solution using Dispatcher property. 

There are three projects, PropertyChangedTest1, PropertyChangedTest2, PropertyChangedTest3. 
PropertyChangedTest1 is trivial and its sole purpose is to demonstrate how to use Dispatcher.
PropertyChangedTest2 include Avalon Dock with only one tab and one pane. PropertyChangedTest7 
has four tabs and two panes, and another pane is dockable. Avalon Dock does not allow all panes 
to be dockable, but at least one needs to be fixed.

Please note, that using Dispatcher is not a preferred way to build a reflection between user 
interface (UI) and code behind: it is recommended to use INotifyPropertyChanged interface or 
DependencyProperty instead of Dispatcher in WPF. It is also worth mentioning, that you probably 
don't need INotifyPropertyChanged, DependencyProperty or Dispatcher to establish a reflection
in WPF, because there components like DataGrid and ObservableCollection, which implements 
reflection already out of the box. However, Label is not such a component.