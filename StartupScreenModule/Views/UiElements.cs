using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace StartupScreenModule.Views
{
    /// <summary>
    /// Elements of this class are assigned values and used in the dynamic creation and presentation of 
    /// the View(s) for StartupScreenModule
    /// </summary>
    public class UiElements
    {
        public TextBlock filedropTextBlock;

        public UiElements()
        {
            CreateFileDropTextBlock();
        }

        private void CreateFileDropTextBlock()
        {
            filedropTextBlock = new TextBlock();
            filedropTextBlock.Name = "FileDropTextBlock";
            filedropTextBlock.Width = 400;
            filedropTextBlock.Height = 336;
            //filedroplbl.HorizontalContentAlignment = HorizontalAlignment.Center;
            filedropTextBlock.Foreground = Brushes.GreenYellow;
            filedropTextBlock.Text = "Drag/Drop a file here.\n\n";
            filedropTextBlock.TextWrapping = TextWrapping.Wrap;
        }
    }
}
