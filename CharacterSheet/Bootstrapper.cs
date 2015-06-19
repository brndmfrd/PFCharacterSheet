using System.Windows;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.UnityExtensions;
using Microsoft.Practices.Unity;

namespace CharacterSheet
{
    class Bootstrapper : UnityBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return new Shell();
        }

        protected override void InitializeShell()
        {
            base.InitializeShell();

            Application.Current.MainWindow = (Window)this.Shell;
            Application.Current.MainWindow.Show();
        }

        protected override void ConfigureModuleCatalog()
        {
            base.ConfigureModuleCatalog();
            ModuleCatalog moduleCatalog = (ModuleCatalog)this.ModuleCatalog;
            moduleCatalog.AddModule(typeof(StartupScreenModule.StartupScreenModule));
            moduleCatalog.AddModule(typeof(NavigationBarModule.NavigationBarModule));
            moduleCatalog.AddModule(typeof(SpellsFeatsSkillsModule.SpellsFeatsSkillsModule));
            moduleCatalog.AddModule(typeof(GearModule.GearModule));
            moduleCatalog.AddModule(typeof(CombatModule.CombatModule));
            moduleCatalog.AddModule(typeof(CharacterModule.CharacterModule));
        }
    }
}
