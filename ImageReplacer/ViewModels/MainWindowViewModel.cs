using Prism.Mvvm;

namespace ImageReplacer.ViewModels
{
    using System.Windows;

    using ImageReplacer.Infrastructure;

    public class MainWindowViewModel : BindableBase, IMainWindowViewModel
    {
        private string _title = "Image Replacer";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public MainWindowViewModel()
        {

        }
    }

    public interface IMainWindowViewModel : IViewModel
    {
        string Title { get; set; }
    }
}
