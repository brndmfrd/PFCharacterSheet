using System.Windows.Controls;
using System.Windows.Input;

namespace CharacterCreationModule.Views
{
    /// <summary>
    /// Interaction logic for BasicInfo.xaml
    /// </summary>
    public partial class BasicInfo : UserControl
    {
        public BasicInfo()
        {
            InitializeComponent();
        }

        private void DataGrid_PreviewMouseWheel(object sender, MouseWheelEventArgs e)
        {
            // This tells the associated element to use the MainContentScrollViewer for scrolling
            MainContentScrollViewer.ScrollToVerticalOffset(MainContentScrollViewer.VerticalOffset - e.Delta / 3);
        }
    }
}
