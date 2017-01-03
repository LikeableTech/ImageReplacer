namespace ImageReplacer.Views
{
    using System;
    using System.Windows;
    using System.Windows.Input;

    using ImageReplacer.Infrastructure;
    using ImageReplacer.ViewModels;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : IMainWindowView
    {
        public MainWindow()
        {
            InitializeComponent();
            this.MaxHeight = SystemParameters.MaximizedPrimaryScreenHeight;
            this.MaxWidth = SystemParameters.MaximizedPrimaryScreenWidth;
        }

        //private void CommandBinding_Executed_Close(object sender, ExecutedRoutedEventArgs e)
        //{
        //    SystemCommands.CloseWindow(this);
        //}

        //private void CommandBinding_Executed_Restore(object sender, ExecutedRoutedEventArgs e)
        //{
        //    SystemCommands.RestoreWindow(this);
        //}

        //private void CommandBinding_Executed_Maximise(object sender, ExecutedRoutedEventArgs e)
        //{
        //    SystemCommands.MaximizeWindow(this);
        //}

        //private void CommandBinding_Executed_Minimize(object sender, ExecutedRoutedEventArgs e)
        //{
        //    SystemCommands.MinimizeWindow(this);
        //}
        
        public IViewModel ViewModel
        {
            get
            {
                return (IMainWindowViewModel)DataContext;
            }
            set
            {
                DataContext = value;
            }
        }
    }

    public interface IMainWindowView : IView
    {
        
    }
}
