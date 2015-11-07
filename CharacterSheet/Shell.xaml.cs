using System.Windows;
using System.Windows.Input;

namespace CharacterSheet
{
    /// <summary>
    /// Interaction logic for Shell.xaml
    /// </summary>
    public partial class Shell : Window
    {
        public Shell()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Enable click 'n drag property of the application window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }

        /// <summary>
        /// Closes the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bttn_close_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();  
        }

        /// <summary>
        /// Minimizes the application window to the task bar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bttn_minimize_MouseDown(object sender, MouseButtonEventArgs e)
        {
            WindowState = WindowState.Minimized;    
        }        
    }
}
