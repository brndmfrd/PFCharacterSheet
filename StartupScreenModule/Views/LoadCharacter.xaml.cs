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

namespace OptionsModule.Views
{
    /// <summary>
    /// Interaction logic for LoadCharacter.xaml
    /// </summary>
    public partial class LoadCharacter : UserControl
    {
        public LoadCharacter()
        {
            InitializeComponent();
        }

        //private void SaveFileListBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
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




    }
}
