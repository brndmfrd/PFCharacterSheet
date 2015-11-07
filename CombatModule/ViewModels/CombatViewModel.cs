using Microsoft.Practices.Prism.Regions;


namespace CombatModule.ViewModels
{
    public class CombatViewModel : INavigationAware
    {
        
       

        // ------- needed for INavigationAware -------
        public void OnNavigatedFrom(NavigationContext navigationContext)
        {
        }
        public void OnNavigatedTo(NavigationContext navigationContext)
        {
            
        }
        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return true;
        }
    }
}
