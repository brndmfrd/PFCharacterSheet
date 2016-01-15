using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;


namespace OptionsModule.Views
{
    public partial class OptionsViewAux : UserControl
    {
        public OptionsViewAux()
        {
            InitializeComponent();
        }

        private void SaveFileListBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }

        //// Deals with UI elements specific to loading a character
        //// todo:  do these need to be sepearate objects?
        //Views.UiElements dragDropObject;
        //Views.UiElements loadCharacterOptions;


        ///// <summary>
        ///// Initialize
        ///// </summary>
        //public OptionsViewControl()
        //{
        //    InitializeComponent();

        //    // --- todo: make a seperate method for all this ui object creation ---
        //    dragDropObject = new Views.UiElements();
        //    loadCharacterOptions = new Views.UiElements();

        //    // Load character options object
        //    loadCharacterOptions.CreateButtons();
        //    loadCharacterOptions.defaultLocationButton.Click += Load_Default_Button_Click;
        //    loadCharacterOptions.explorerButton.Click += Load_Explorer_Button_Click;
        //    loadCharacterOptions.fileDropButton.Click += Load_DragDrop_Button_Click;
        //    loadCharacterOptions.fileListBox.MouseDoubleClick += fileListBox_MouseDoubleClick;
        //    loadCharacterOptions.CreateFileDropTextBlock();
        //    loadCharacterOptions.fileDropTextBlock.AllowDrop = true;  // important to add this explicitly.  Will be contained in a SP that sets this to false by default.
        //}


        //void fileListBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        //{
        //    var selection = loadCharacterOptions.fileListBox.SelectedItem.ToString();

        //    if (string.IsNullOrEmpty(selection))
        //    {
        //        loadCharacterOptions.fileDropTextBlock.Text += "File load failed.  No action taken.\n\n";
        //        return;
        //    }

        //    // Open message box to confirm with user path is correct.
        //    if (loadCharacterOptions.ConfirmFileLoad(selection))
        //    {
        //        Models.LoadCharacter.CharacterfileAndPath = selection;   // Tell our Model the path of the file dropped
        //    }
        //    else
        //    {
        //        loadCharacterOptions.fileDropTextBlock.Text += "File load cancelled.  No action taken.\n\n";
        //    }
        //}


        ///// <summary>
        ///// Event handler for drag/drop objects in the stack panel "Sp2FileDrop"
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>        
        //private void File_Drop(object sender, DragEventArgs e)
        //{
        //    if (e.Data.GetDataPresent(DataFormats.FileDrop, true))
        //    {        
        //        // Get the path of the dropped file
        //        string[] filePathOfDroppedFile = 
        //            e.Data.GetData(DataFormats.FileDrop, true) as string[];
                              
        //        // Add path to filedroplbl to display path to user
        //        loadCharacterOptions.fileDropTextBlock.Text += 
        //            string.Format("Attempting to load file: \n {0}\n", filePathOfDroppedFile[0]);

        //        // Open message box to confirm with user path is correct.
        //        if (dragDropObject.ConfirmFileLoad(filePathOfDroppedFile[0]))
        //        {
        //            Models.LoadCharacter.CharacterfileAndPath = filePathOfDroppedFile[0];   // Tell our Model the path of the file dropped
        //        }
        //        else
        //        {
        //            loadCharacterOptions.fileDropTextBlock.Text += "File load cancelled.  No action taken.\n\n";
        //        }
        //    }            
        //}


        ///// <summary>
        ///// Event handler to load buttons into the character loader panel.  
        ///// This panel propigates buttons for the user to select the method to load in their character file.
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //private void Load_Character_Button_Click(object sender, RoutedEventArgs e)
        //{
        //    if (Sp1LoadOptions.Children.Contains(loadCharacterOptions.explorerButton) &&
        //        Sp1LoadOptions.Children.Contains(loadCharacterOptions.defaultLocationButton) && 
        //        Sp1LoadOptions.Children.Contains(loadCharacterOptions.fileDropButton))
        //    {
        //        Sp1LoadOptions.Children.Clear();    // Clear children
        //        Sp2LoaderPanel.Children.Clear();    // Clear grandchildren
        //    }
        //    else
        //    {
        //        Sp1LoadOptions.Children.Add(loadCharacterOptions.explorerButton);
        //        Sp1LoadOptions.Children.Add(loadCharacterOptions.defaultLocationButton);
        //        Sp1LoadOptions.Children.Add(loadCharacterOptions.fileDropButton);
        //    }   
        //}


        ///// <summary>
        ///// Event handler when the user selects to load their character from one of 
        ///// the files from the default file directories.  This location will likely be the same directory where the 
        ///// application executable is saved.
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //private void Load_Default_Button_Click(object sender, RoutedEventArgs e)
        //{
        //    // Clear any old data and start clean
        //    loadCharacterOptions.fileListBox.Items.Clear();
        //    Sp2LoaderPanel.Children.Clear();

        //    // get files in default location
        //    var allTheFiles = Models.LoadCharacter.GetFilesFromDefaultDir();

        //    // fill our listbox
        //    foreach (var f in allTheFiles)
        //    {
        //        loadCharacterOptions.fileListBox.Items.Add(f);
        //    }

        //    // add our listbox to the UI
        //    Sp2LoaderPanel.Children.Add(loadCharacterOptions.fileListBox);
        //    Sp2LoaderPanel.Children.Add(loadCharacterOptions.fileDropTextBlock);
        //}


        ///// <summary>
        ///// Event handler when the user elects to select their character by using the native file explorer for 
        ///// their operating system.
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //private void Load_Explorer_Button_Click(object sender, RoutedEventArgs e)
        //{
        //    // -- Open panel if it is not already open --
        //    //if (!Sp2LoaderPanel.Children.Contains(dragDropObject.fileDropTextBlock))
        //    //{
        //    //    Sp2LoaderPanel.Children.Add(dragDropObject.fileDropTextBlock);
        //    //}
        //    Sp2LoaderPanel.Children.Clear();
        //    Sp2LoaderPanel.Children.Add(loadCharacterOptions.fileDropTextBlock);

        //    // -- Open windows file explorer --
        //    var ofd = new Microsoft.Win32.OpenFileDialog();
        //    var success = ofd.ShowDialog();                     // returns nullable bool

        //    // -- Leave if failure in file explorer -- 
        //    if (success != true)
        //    {
        //        loadCharacterOptions.fileDropTextBlock.Text += "File load failed. No action taken.\n\n";
        //        return;
        //    }

        //    // Open message box to confirm with user path is correct.
        //    if (dragDropObject.ConfirmFileLoad(ofd.FileName))
        //    {
        //        Models.LoadCharacter.CharacterfileAndPath = ofd.FileName;   // Tell our Model the path of the file dropped
        //        loadCharacterOptions.fileDropTextBlock.Text += "File load successfull!\n\n";
        //    }
        //    else
        //    {
        //        loadCharacterOptions.fileDropTextBlock.Text += "File load cancelled. No action taken.\n\n";
        //    }        

        //}


        ///// <summary>
        ///// Event handler when the user elects to drag/drop their charcter file into the application.  
        ///// This panel is propigated with a textbox where the user may drag/drop into.
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //private void Load_DragDrop_Button_Click(object sender, RoutedEventArgs e)
        //{
        //    //if (!Sp2LoaderPanel.Children.Contains(dragDropObject.fileDropTextBlock))
        //    //{
        //    //    Sp2LoaderPanel.Children.Add(dragDropObject.fileDropTextBlock);
        //    //}
        //    Sp2LoaderPanel.Children.Clear();
        //    Sp2LoaderPanel.Children.Add(loadCharacterOptions.fileDropTextBlock);
        //}


        ///// <summary>
        ///// Event handler that allows users to create a new character sheet
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //private void Create_Character_Buttton_Click(object sender, RoutedEventArgs e)
        //{

        //}

        //private void Save_Character_Button_Click(object sender, RoutedEventArgs e)
        //{

        //}

        //private void Config_Button_Click(object sender, RoutedEventArgs e)
        //{

        //}

    }
}
