using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using VetManager.ViewModel.BaseClass;

namespace VetManager.ViewModel
{
    class Choice : PropertyChanger
    {

        private ICommand? ShowOwnersCommand { get; set; }
        private ICommand? ShowAnimalsCommand { get; set; }
        private ICommand? ShowVisitsCommand { get; set; }
        private ICommand? LogOutCommand { get; set; }
        private readonly MainViewModel mainVm;

        public Choice(MainViewModel mainVm)
        {
            this.mainVm = mainVm;
            ShowOwnersCommand = new RelayCommand(ShowOwners, CanShowOwners);
            ShowAnimalsCommand = new RelayCommand(ShowAnimals, CanShowAnimals);
            ShowVisitsCommand = new RelayCommand(ShowVisits, CanShowVisits);
            LogOutCommand = new RelayCommand(LogOut, CanLogOut);
        }

        private bool CanShowOwners(object obj)
        {
            return true;
        }

        private void ShowOwners(object obj)
        {
            Debug.WriteLine("Wchodzę do owners");
            mainVm.CurrentView = new Owners(mainVm);
        }

        private bool CanShowAnimals(object obj)
        {
            return true;
        }

        private void ShowAnimals(object obj)
        {
            Debug.WriteLine("Wchodzę do animals");
            mainVm.CurrentView = new Pets(mainVm);
        }

        private bool CanShowVisits(object obj)
        {
            return true;
        }

        private void ShowVisits(object obj)
        {
            Debug.WriteLine("Wchodzę do visits");
            mainVm.CurrentView = new Visits(mainVm);
        }

        private bool CanLogOut(object obj)
        {
            return true;
        }

        private void LogOut(object obj)
        {
            Debug.WriteLine("Wchodzę do Logout");
            mainVm.CurrentView = new Login(mainVm);
        }
    }
}
