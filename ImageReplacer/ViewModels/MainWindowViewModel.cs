using Prism.Mvvm;

namespace ImageReplacer.ViewModels
{
    public class MainWindowViewModel : BindableBase
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
}
