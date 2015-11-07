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



        internal void CreateButtons()
        {
            ResourceDictionary rds = new ResourceDictionary();
            rds.Source = new Uri("pack://application:,,,/ActiveCharacter;component/SharedResources/NavigationStyles.xaml");

            Thickness customMargin = new Thickness() { Bottom = 5, Right = 5, Left = 5, Top = 5 };

            explorerButton = new Button();
            explorerButton.Content = "Select From Windows Explorer";
            explorerButton.Width = 200;
            explorerButton.Height = 80;
            explorerButton.Margin = customMargin;
            explorerButton.Style = (Style)rds["NavigationButtonStyle"];

            defaultLocationButton = new Button();
            defaultLocationButton.Content = "Select From Default Location";
            defaultLocationButton.Width = 200;
            defaultLocationButton.Height = 80;
            defaultLocationButton.Margin = customMargin;
            defaultLocationButton.Style = (Style)rds["NavigationButtonStyle"];

            fileDropButton = new Button();
            fileDropButton.Content = "Drag/Drop File";
            fileDropButton.Width = 200;
            fileDropButton.Height = 80;
            fileDropButton.Margin = customMargin;
            fileDropButton.Style = (Style)rds["NavigationButtonStyle"];    
      
            // Umm... I want this, too.  I'll find a better spot for it later.
            fileListBox = new ListBox();
            fileListBox.Background = null;
            fileListBox.Foreground = Brushes.GreenYellow;
            
        }



    }
}
