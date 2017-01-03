namespace TitleBar.Views
{
    using System;
    using System.Windows;
    using System.Windows.Input;

    using ImageReplacer.Infrastructure;

    using ViewModels;

    /// <summary>
    /// Interaction logic for TitleBar.xaml
    /// </summary>
    public partial class TitleBarControl : ITitleBarView
    {
        public TitleBarControl()
        {
            InitializeComponent();

            this.MouseDown += this.TitlePanelOnMouseDown;
            this.MouseDoubleClick += this.TitlePanelOnMouseDoubleClick;
        }

        private void TitleBar_OnLoaded(object sender, RoutedEventArgs e)
        {
            var parentWindow = this.GetParentWindow();
            parentWindow.SizeChanged += this.ParentWindowOnSizeChanged;
            this.SetMaximizeAndRestoreButtonVisibility(parentWindow);
        }

        private Window GetParentWindow()
        {
            return Window.GetWindow(this);
        }

        private void TitlePanelOnMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.GetParentWindow().DragMove();
            }
        }

        private void TitlePanelOnMouseDoubleClick(object sender, MouseButtonEventArgs mouseButtonEventArgs)
        {
            var parentWindow = this.GetParentWindow();
            if (parentWindow.WindowState == WindowState.Maximized)
            {
                this.RestoreWindow();
            }
            else
            {
                this.MaximizeWindow();
            }
        }

        private void RestoreWindow()
        {
            SystemCommands.RestoreWindow(this.GetParentWindow());
        }

        private void MaximizeWindow()
        {
            SystemCommands.MaximizeWindow(this.GetParentWindow());
        }

        private void MinimizeWindow()
        {
            SystemCommands.MinimizeWindow(this.GetParentWindow());
        }

        private void CloseWindow()
        {
            SystemCommands.CloseWindow(this.GetParentWindow());
        }

        private void ParentWindowOnSizeChanged(object sender, SizeChangedEventArgs sizeChangedEventArgs)
        {
            var parentWindow = this.GetParentWindow();
            this.SetMaximizeAndRestoreButtonVisibility(parentWindow);
        }

        private void SetMaximizeAndRestoreButtonVisibility(Window parentWindow)
        {
            if (parentWindow.WindowState == WindowState.Maximized)
            {
                this.BtnMaximize.Visibility = Visibility.Collapsed;
                this.BtnRestore.Visibility = Visibility.Visible;
            }
            else
            {
                this.BtnRestore.Visibility = Visibility.Collapsed;
                this.BtnMaximize.Visibility = Visibility.Visible;
            }
        }

        private void CommandBinding_CanExecute_Close(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }
        private void CommandBinding_CanExecute_Restore(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }
        private void CommandBinding_CanExecute_Maximise(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }
        private void CommandBinding_CanExecute_Minimize(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void CommandBinding_Executed_Close(object sender, ExecutedRoutedEventArgs e)
        {
            this.CloseWindow();
        }

        private void CommandBinding_Executed_Restore(object sender, ExecutedRoutedEventArgs e)
        {
            this.RestoreWindow();
        }

        private void CommandBinding_Executed_Maximise(object sender, ExecutedRoutedEventArgs e)
        {
            this.MaximizeWindow();
        }

        private void CommandBinding_Executed_Minimize(object sender, ExecutedRoutedEventArgs e)
        {
            this.MinimizeWindow();
        }

        public IViewModel ViewModel
        {
            get
            {
                return (ITitleBarViewModel)DataContext;
            }
            set
            {
                DataContext = value;
            }
        }

        private void ContextMenuButton_OnClick(object sender, RoutedEventArgs e)
        {
            this.ContextMenuButton.ContextMenu.IsOpen = true;
        }
    }

    public interface ITitleBarView : IView
    {
        
    }
}
