The PropertyChangedTest2 is the second one and here's the right way to use DependencyProperty: 
we combine a button and a textlabel with a single property CounterProperty by using a resource 
in a xaml file. Here I have separated working code from MainWindow into a UserControl also. 
However, this way may be problematic, because you need to create static objects in a xaml
file instead of dynamic instances in a code behind.

There are seven projects, PropertyChangedTest1, PropertyChangedTest2, PropertyChangedTest3, 
PropertyChangedTest4, PropertyChangedTest5, PropertyChangedTest6 and PropertyChangedTest6. 
PropertyChangedTest1 and PropertyChangedTest2 are trivial and their sole purpose is to 
demonstrate a simple user event done with DependencyProperty. PropertyChangedTest3 and 
PropertyChangedTest4 include Avalon Dock, which makes difficult to establish the same 
funtionality than in previous solutions. PropertyChangedTest5 has a title in its' only tab 
as an additional feature. PropertyChangedTest6 has multiple tabs.

And PropertyChangedTest7 is the last and only solution, which has a dockable pane Avalon Dock
is made for. Previous solutions have only one fixed pane. PropertyChangedTest7 has two panes, 
and another one is dockable. Avalon Dock does not allow all panes to be dockable, but at 
least one needs to be fixed.