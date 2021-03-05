The PropertyChangedTest5 is one solution using INotifyPropertyChanged interface with 
Avalon Dock. This fifth one is using 'DockingManager.LayoutItemTemplateSelector' 
property, which makes possible to sort wanted templates among other templates. There is 
also 'DockingManager.LayoutItemContainerStyleSelector', which makes styling, I.E. for 
example pane titles, icons and custon close events possible.

One need to implement styles as properties in appropriate viewmodels. This is done via 
styleselector class just like with templateselector. Note that you cannot create seperate
classes to implement styles, because selectors do not allow that: you need to include all
in an appropriate viewmodel.

There are seven projects, PropertyChangedTest1, PropertyChangedTest2, PropertyChangedTest3, 
PropertyChangedTest4, PropertyChangedTest5, PropertyChangedTest6 and PropertyChangedTest6. 
PropertyChangedTest1 and PropertyChangedTest2 are trivial and their sole purpose is to 
demonstrate a simple user event done with INotifyPropertyChanged. PropertyChangedTest3 and 
PropertyChangedTest4 include Avalon Dock, which makes difficult to establish the same 
funtionality than in previous solutions. PropertyChangedTest5 has a title in its' only tab 
as an additional feature. PropertyChangedTest6 has multiple tabs.

And PropertyChangedTest7 is the last and only solution, which has a dockable pane Avalon Dock
is made for. Previous solutions have only one fixed pane. PropertyChangedTest7 has two panes, 
and another one is dockable. Avalon Dock does not allow all panes to be dockable, but at 
least one needs to be fixed.