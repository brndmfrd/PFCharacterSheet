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
        // Deals with UI elements specific to loading a character
        Views.UiElements uiElements;


        /// <summary>
        /// Initialize
        /// </summary>
        public StartupScreenViewControl()
        {
            InitializeComponent();
            
            uiElements = new Views.UiElements();            
        }


        /// <summary>
        /// Event handler for drag/drop objects in the stack panel "Sp1FileDrop"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>        
        private void File_Drop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, true))
            {        
                // Get the path of the dropped file
                string[] filePathOfDroppedFile = e.Data.GetData(DataFormats.FileDrop, true) as string[];
                              
                // Add path to filedroplbl to display path to user
                uiElements.filedropTextBlock.Text += string.Format("Attempting to load file: \n {0}\n", filePathOfDroppedFile[0]);

                if (ConfirmFileLoad(filePathOfDroppedFile[0]))
                {
                    // Tell Model what the path of the file dropped is
                    Models.LoadCharacter.CharacterfileAndPath = filePathOfDroppedFile[0];
                }
                else
                {
                    uiElements.filedropTextBlock.Text += @"File load cancelled.  No action taken.";
                }
            }            
        }

        /// <summary>
        /// Confirm with the user that the path they have provided is one they would like to attempt 
        /// to load.
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        private bool ConfirmFileLoad(string path)
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


        /// <summary>
        /// On click display the file-drop space for users to drag/drop files to used as their character. 
        /// The filedroplbl will capture the full path to the file drag/dropped.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Sp1FileDrop.Children.Contains(uiElements.filedropTextBlock))
            {
                Sp1FileDrop.Children.Remove(uiElements.filedropTextBlock);
            }
            else
            {
                Sp1FileDrop.Children.Add(uiElements.filedropTextBlock);
            }
        }
    }
}
