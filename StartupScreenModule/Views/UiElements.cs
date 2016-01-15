using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace OptionsModule.Views
{
    /// <summary>
    /// Elements of this class are assigned values and used in the dynamic creation and presentation of 
    /// the View(s) for StartupScreenModule
    /// </summary>
    public class UiElements
    {
        public TextBlock fileDropTextBlock;
        public Button defaultLocationButton;
        public Button explorerButton;
        public Button fileDropButton;
        public ListBox fileListBox;


        /// <summary>
        /// Constructor
        /// </summary>
        public UiElements()
        {
        }


        public void CreateFileDropTextBlock()
        {
            fileDropTextBlock = new TextBlock();
            fileDropTextBlock.Name = "FileDropTextBlock";
            fileDropTextBlock.Width = 400;
            fileDropTextBlock.Height = 336;
            //filedroplbl.HorizontalContentAlignment = HorizontalAlignment.Center;
            fileDropTextBlock.Foreground = Brushes.GreenYellow;
            fileDropTextBlock.Text = "Drag/Drop a file here.\n\n";
            fileDropTextBlock.TextWrapping = TextWrapping.Wrap;            
        }


        /// <summary>
        /// Confirm with the user that the path they have provided is one they would like to attempt 
        /// to load.
        /// </summary>
        /// <param name="path">File path to character file.</param>
        /// <returns></returns>
        public bool ConfirmFileLoad(string path)
        {
            var result =
                MessageBox.Show(string.Format("Load {0}?", path),
                "Please Confirm File",
                MessageBoxButton.OKCancel,
                MessageBoxImage.Question,
                MessageBoxResult.Cancel
                );

            if (result == MessageBoxResult.OK)
            {
                return true;
            }
            else
            {
                return false;
            }
        }




    }
}
