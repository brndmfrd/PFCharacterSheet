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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Label filedroplbl = new Label();
            filedroplbl.Name = "FileDropLabel";
            filedroplbl.Width = 400;
            filedroplbl.Height = 336;
            filedroplbl.HorizontalContentAlignment = HorizontalAlignment.Center;
            filedroplbl.Foreground = Brushes.GreenYellow;
            filedroplbl.Content = "Drag/Drop a file here.";

            if (Sp1FileDrop.Children.Contains(filedroplbl))
            {
                Sp1FileDrop.Children.Remove(filedroplbl);
            }
            else
            {
                Sp1FileDrop.Children.Add(filedroplbl);
            }
        }
    }
}
