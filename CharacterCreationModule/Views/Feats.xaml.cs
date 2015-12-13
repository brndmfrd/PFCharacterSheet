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
using ActiveCharacter;
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

        private void FeatsGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.OemPlus)
            {
                NewCharacterContainer.Feats.Add(new Feat { Name = "", Description = "" });
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
