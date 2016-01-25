using System.Windows;
using log4net.Config;


namespace CharacterSheet
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            // Configure logging !!! Find a better path.
            XmlConfigurator.Configure(new System.IO.FileInfo(@"..\..\..\log4net.xml"));  

            Bootstrapper bootstrapper = new Bootstrapper();
            bootstrapper.Run();
        }
    }
}
