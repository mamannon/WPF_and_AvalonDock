# WPF_and_AvalonDock
 

For desktop applications, Windows Presentation Foundation ie. WPF is the way to go nowadays. Old Windows Forms is still feasible solution for simpler applications, which don't need scalable controls and superior graphics. WPF has interesting third party docking libaries and here we will study one of them, AvalonDock.

## Preface

This repository includes 14 projects, which are tutorials for both WPF messaging mechanisms and AvalonDock. We have three different ways to send messages or handle events in WPF: DependencyProperty, INotifyPropertyChanged and IObservable / IObserver pair. I'll show how to use DependencyProperty and INotifyPropertyChanged with AvalonDock. There's also one example of IObservable / IObserver use.

It is important to understand WPF MVVM (Model, View, ViewModel) pattern when using WPF and AvalonDock especially. This is not a tutorial for MVVM, so if you are not familiar with it, you should first introduce yourself with it.

## License

This repository has 14 projects licensed under the MIT License.