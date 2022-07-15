The PropertyChangedSmart1 is the only solution of 18 solutions I recommend to use further: 
other solutions are for studying. This one is using 'DockingManager.LayoutItemTemplateSelector' 
property, which makes possible to sort wanted templates among other templates. There is 
also 'DockingManager.LayoutItemContainerStyleSelector', which makes styling, I.E. for 
example pane titles, icons and custon close events possible. This solution
has two panes and second one is dockable. Avalon Dock does not allow all panes 
to be dockable, but at least one needs to be fixed.

One need to implement LayoutRoot into MainWindow.xaml to create multiple panes or 
dockable panes. Tabs in a dockable pane need templates for the content to show and wanted 
templates has to be binded to 'AnchorablesSource="{Binding Documents2}"' by an 
ObservableCollection.  

This solution uses the recommended INotifyPropertyChanged interface. It is also worth mentioning, 
that you probably don't need INotifyPropertyChanged, DependencyProperty or Dispatcher to establish 
the binding in WPF, because there are components like DataGrid and ObservableCollection, 
which implement binding already out of the box. However, Label is not such a component.
