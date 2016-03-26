using System.Windows.Controls;
using System.Windows.Input;
using CharacterCreationModule.Models;

namespace CharacterCreationModule.Views
{
    /// <summary>
    /// Interaction logic for Feats.xaml
    /// </summary>
    public partial class Feats : UserControl
    {
        public Feats()
        {
            InitializeComponent();
        }

        // Press the '+' button to add a new empty row
        private void FeatsGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.OemPlus)
            {
                NewCharacterContainer.Feats.Add(new DisplayObject { Name = "", Value = "" });
                e.Handled = true;
            }

            //if (e.Key == Key.OemMinus)
            //{                
            //    // if at least one element--
            //    NewCharacterContainer.Feats.RemoveAt(NewCharacterContainer.Feats.Count - 1);
            //}
        }
    }
}
