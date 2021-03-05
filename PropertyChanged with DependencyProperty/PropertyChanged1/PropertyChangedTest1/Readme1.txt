
The PropertyChangedTest1 is the first and dumbest solution using DependencyObject
base class. Don't follow this! Never combine DependencyObject and IObservable to make
a twoway binding because you need a bunch of code to implement it and there's a 
problem between static and dynamic class members. And if you try to combine DependencyObject 
and INotifyPropertyChanged to achieve twoway binding, it goes impossible... 

After saying that, combining DependencyObject and IObservable or INotifyPropertyChanged 
would be a brilliant idea, but then you are trying something else than twoway binding... 
Actually PropertyChangedTest1 doesn't use twoway binding, but one oneway binding with a 
button using DependencyProperty and another oneway binding with a textlabel using Observable,
but you should use a real twoway binding using DependencyProperty only, as is done in the
PropertyChangedTest2.

There are seven projects, PropertyChangedTest1, PropertyChangedTest2, PropertyChangedTest3, 
PropertyChangedTest4, PropertyChangedTest5, PropertyChangedTest6 and PropertyChangedTest6. 
PropertyChangedTest2 is trivial and a good solution to demonstrate a simple user event done 
with DependencyProperty. PropertyChangedTest3 and 
PropertyChangedTest4 include Avalon Dock, which makes difficult to establish the same 
funtionality than in previous solutions. PropertyChangedTest5 has a title in its' only tab 
as an additional feature. PropertyChangedTest6 has multiple tabs.

And PropertyChangedTest7 is the last and only solution, which has a dockable pane Avalon Dock
is made for. Previous solutions have only one fixed pane. PropertyChangedTest7 has two panes, 
and another one is dockable. Avalon Dock does not allow all panes to be dockable, but at 
least one needs to be fixed.