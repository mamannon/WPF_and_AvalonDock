The PropertyChangedTest3 is one solution using Dispatcher property with 
Avalon Dock. This third one is using 'DockingManager.LayoutItemTemplateSelector' 
property, which makes possible to sort wanted templates among other templates. There is 
also 'DockingManager.LayoutItemContainerStyleSelector', which makes styling, I.E. for 
example pane titles, icons and custon close events possible. Furthermore, this solution
has two panes and second one is dockable.

One need to implement LayoutRoot into UserControlWindow.xaml to create multiple panes or 
dockable panes. Tabs in a dockable pane need templates for the content to show and wanted 
templates has to be binded to 'AnchorablesSource="{Binding Documents2}"' by an 
ObservableCollection.  

There are three projects, PropertyChangedTest1, PropertyChangedTest2, PropertyChangedTest3. 
PropertyChangedTest1 is trivial and its sole purpose is to demonstrate how to use Dispatcher.
PropertyChangedTest2 include Avalon Dock with only one tab and one pane. PropertyChangedTest7 
has four tabs and two panes, and another pane is dockable. Avalon Dock does not allow all panes 
to be dockable, but at least one needs to be fixed.

Please note, that using Dispatcher is not a preferred way to build a reflection between user 
interface (UI) and code behind: it is recommended to use INotifyPropertyChanged interface or 
DependencyProperty instead of Dispatcher in WPF. It is also worth mentioning, that you probably 
don't need INotifyPropertyChanged, DependencyProperty or Dispatcher to establish a reflection
in WPF, because there are components like DataGrid and ObservableCollection, which implements 
reflection already out of the box. However, Label is not such a component.