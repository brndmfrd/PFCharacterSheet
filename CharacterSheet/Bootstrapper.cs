using System.Windows;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.UnityExtensions;

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
            moduleCatalog.AddModule(typeof(OptionsModule.OptionsModule));
            moduleCatalog.AddModule(typeof(NavigationBarModule.NavigationBarModule));
            moduleCatalog.AddModule(typeof(GearModule.GearModule));
            moduleCatalog.AddModule(typeof(CombatModule.CombatModule));
            moduleCatalog.AddModule(typeof(CharacterModule.CharacterModule));
            moduleCatalog.AddModule(typeof(SpellsModule.SpellsModule));
            moduleCatalog.AddModule(typeof(FeatsModule.FeatsModule));
            moduleCatalog.AddModule(typeof(SkillsModule.SkillsModule));
            moduleCatalog.AddModule(typeof(StatusBarModule.StatusBarModule));
            moduleCatalog.AddModule(typeof(CharacterCreationModule.CharacterCreationModule));
        }
    }
}
