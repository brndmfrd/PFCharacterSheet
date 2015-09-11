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
using System.IO;

namespace StartupScreenModule.Views
{
    /// <summary>
    /// Interaction logic for StartupScreenViewControl.xaml
    /// </summary>
    public partial class StartupScreenViewControl : UserControl
    {
        public StartupScreenViewControl()
        {
            InitializeComponent();
        }


        private void File_Drop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, true))
            {
                string[] filePathOfDroppedFile = e.Data.GetData(DataFormats.FileDrop, true) as string[];
            }
        }
    }
}
