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

namespace ImageFileSelection.Views
{
    using ImageReplacer.Infrastructure;

    /// <summary>
    /// Interaction logic for SelectionToolbar.xaml
    /// </summary>
    public partial class SelectionToolbar : ISelectionToolbarView
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SelectionToolbar"/> class.
        /// </summary>
        public SelectionToolbar()
        {
            InitializeComponent();
        }

        public IViewModel ViewModel
        {
            get { return (IViewModel)DataContext; }
            set { DataContext = value; }
        }
    }

    public interface ISelectionToolbarView : IView
    {

    }
}
