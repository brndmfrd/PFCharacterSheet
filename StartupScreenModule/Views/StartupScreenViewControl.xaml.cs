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
        // todo:  do these need to be sepearate objects?
        Views.UiElements dragDropObject;
        Views.UiElements loadCharacterOptions;


        /// <summary>
        /// Initialize
        /// </summary>
        public StartupScreenViewControl()
        {
            InitializeComponent();

            // --- todo: make a seperate method for all this ui object creation ---
            dragDropObject = new Views.UiElements();
            loadCharacterOptions = new Views.UiElements();

            // Load character options object
            loadCharacterOptions.CreateButtons();
            loadCharacterOptions.defaultLocationButton.Click += Load_Default_Button_Click;
            loadCharacterOptions.explorerButton.Click += Load_Explorer_Button_Click;
            loadCharacterOptions.fileDropButton.Click += Load_DragDrop_Button_Click;

            // Drag/Drop object
            dragDropObject.CreateFileDropTextBlock();
            dragDropObject.fileDropTextBlock.AllowDrop = true;
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
                string[] filePathOfDroppedFile = 
                    e.Data.GetData(DataFormats.FileDrop, true) as string[];
                              
                // Add path to filedroplbl to display path to user
                dragDropObject.fileDropTextBlock.Text += 
                    string.Format("Attempting to load file: \n {0}\n", filePathOfDroppedFile[0]);

                // Open message box to confirm with user path is correct.
                if (dragDropObject.ConfirmFileLoad(filePathOfDroppedFile[0]))
                {
                    Models.LoadCharacter.CharacterfileAndPath = filePathOfDroppedFile[0];   // Tell our Model the path of the file dropped
                }
                else
                {
                    dragDropObject.fileDropTextBlock.Text += @"File load cancelled.  No action taken.\n\n";
                }
            }            
        }


        /// <summary>
        /// Event handler to load objects into the character loader options panel.  
        /// This panel propigates buttons for the user to select the method to load in their character file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Load_Character_Button_Click(object sender, RoutedEventArgs e)
        {
            if (Sp1LoadOptions.Children.Contains(loadCharacterOptions.explorerButton) &&
                Sp1LoadOptions.Children.Contains(loadCharacterOptions.defaultLocationButton) && 
                Sp1LoadOptions.Children.Contains(loadCharacterOptions.fileDropButton))
            {
                Sp1LoadOptions.Children.Remove(loadCharacterOptions.explorerButton);
                Sp1LoadOptions.Children.Remove(loadCharacterOptions.defaultLocationButton);
                Sp1LoadOptions.Children.Remove(loadCharacterOptions.fileDropButton);
            }
            else
            {
                Sp1LoadOptions.Children.Add(loadCharacterOptions.explorerButton);
                Sp1LoadOptions.Children.Add(loadCharacterOptions.defaultLocationButton);
                Sp1LoadOptions.Children.Add(loadCharacterOptions.fileDropButton);
            }
        }


        /// <summary>
        /// Event handler when the user selects to load their character from one of 
        /// the files from the default file directories.  This location will likely be the same directory where the 
        /// application executable is saved.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Load_Default_Button_Click(object sender, RoutedEventArgs e)
        {
            if (Sp2LoaderPanel.Children.Contains(dragDropObject.fileDropTextBlock))
            {
                Sp2LoaderPanel.Children.Remove(dragDropObject.fileDropTextBlock);
            }
            else
            {
                Sp2LoaderPanel.Children.Add(dragDropObject.fileDropTextBlock);
            }
        }


        /// <summary>
        /// Event handler when the user elects to select their character by using the native file explorer for 
        /// their operating system.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Load_Explorer_Button_Click(object sender, RoutedEventArgs e)
        {
            
        }


        /// <summary>
        /// Event handler when the user elects to drag/drop their charcter file into the application.  
        /// This panel is propigated with a textbox where the user may drag/drop into.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Load_DragDrop_Button_Click(object sender, RoutedEventArgs e)
        {
            if (Sp2LoaderPanel.Children.Contains(dragDropObject.fileDropTextBlock))
            {
                Sp2LoaderPanel.Children.Remove(dragDropObject.fileDropTextBlock);
            }
            else
            {
                Sp2LoaderPanel.Children.Add(dragDropObject.fileDropTextBlock);
            }
        }



    }
}
