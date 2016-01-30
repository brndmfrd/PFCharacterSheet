using System.Collections.Generic;
using Microsoft.Practices.Prism.Regions;
using ActiveCharacter;
using ModuleTools;
using GearModule.Model;
using GearModule.Views;


namespace GearModule.ViewModels
{
    public class GearViewModel : ObservableObject, INavigationAware
    {
        public IEnumerable<Item> Gear { get { return Character.Gear; }}

        // Listbox in primary view uses this accessor for what is has currently selected
        // Navigation allows the Aux view to 'refresh' and update based on the selected value
        public Item MySelectedItem
        {
            get { return SelectedState.CurrentSelectedFeat; }
            set
            {
                SelectedState.CurrentSelectedFeat = value;   
                GearModule.regionManager.RequestNavigate("AuxContentRegion", typeof(Views.GearViewAux).FullName);
            }
        }

        #region Navigation
        public void OnNavigatedFrom(NavigationContext navigationContext)
        {
        }
        public void OnNavigatedTo(NavigationContext navigationContext)
        {
            // If we have no character data load these defaults (for testing purposes only, remove later)
            if (ActiveCharacter.Character.Gear.Count <= 0)
            {
                Character.Gear.Add(new Item() { Name = "Item 1", Amount = 10, Description = "Item 1 description" });
                Character.Gear.Add(new Item() { Name = "Item 2", Amount = 9, Description = "Item 2 description" });
                Character.Gear.Add(new Item() { Name = "Item 3", Amount = 8, Description = "Item 3 description" });
                Character.Gear.Add(new Item() { Name = "Item 4", Amount = 7, Description = "Item 4 description" });
                Character.Gear.Add(new Item() { Name = "Item 5", Amount = 6, Description = "Item 5 description" });
                Character.Gear.Add(new Item() { Name = "Item 6", Amount = 5, Description = "Item 6 description" });
                Character.Gear.Add(new Item() { Name = "Item 7", Amount = 4, Description = "Item 7 description" });
                Character.Gear.Add(new Item() { Name = "Item 8", Amount = 3, Description = "Item 8 description" });
                Character.Gear.Add(new Item() { Name = "Item 9", Amount = 2, Description = "Item 9 description" });
                Character.Gear.Add(new Item() { Name = "Item 10", Amount = 1, Description = "Item 10 description" });
                Character.Gear.Add(new Item() { Name = "Item 1", Amount = 10, Description = "Item 1 description" });
                Character.Gear.Add(new Item() { Name = "Item 2", Amount = 9, Description = "Item 2 description" });
                Character.Gear.Add(new Item() { Name = "Item 3", Amount = 8, Description = "Item 3 description" });
                Character.Gear.Add(new Item() { Name = "Item 4", Amount = 7, Description = "Item 4 description" });
                Character.Gear.Add(new Item() { Name = "Item 5", Amount = 6, Description = "Item 5 description" });
                Character.Gear.Add(new Item() { Name = "Item 6", Amount = 5, Description = "Item 6 description" });
                Character.Gear.Add(new Item() { Name = "Item 7", Amount = 4, Description = "Item 7 description" });
                Character.Gear.Add(new Item() { Name = "Item 8", Amount = 3, Description = "Item 8 description" });
                Character.Gear.Add(new Item() { Name = "Item 9", Amount = 2, Description = "Item 9 description" });
                Character.Gear.Add(new Item() { Name = "Item 10", Amount = 1, Description = "Item 10 description" });
               
            }

            // Needed for MySelectedItem to update when item selection changes. 
            RaisePropertyChangedEvent("MySelectedItem");

        }
        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return true;
        }
        #endregion Navigation
    }
}
