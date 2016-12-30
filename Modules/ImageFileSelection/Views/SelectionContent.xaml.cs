using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ImageReplacer.Infrastructure;
using ImageFileSelection.ViewModels;

namespace ImageFileSelection.Views
{

    /// <summary>
    /// Interaction logic for SelectionContent.xaml
    /// </summary>
    public partial class SelectionContent : ISelectionContentView
    {
        public SelectionContent()
        {
            InitializeComponent();
        }

        public IViewModel ViewModel
        {
            get { return (ISelectionContentViewModel)DataContext; }
            set { DataContext = value; }
        }
    }

    public interface ISelectionContentView : IView
    {
        
    }
}
