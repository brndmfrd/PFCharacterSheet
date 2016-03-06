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

            // This is where our ever important logger config file lives
            XmlConfigurator.Configure(new System.IO.FileInfo(@"..\..\..\Configurations\log4net.xml"));  

            Bootstrapper bootstrapper = new Bootstrapper();
            bootstrapper.Run();
        }
    }
}
