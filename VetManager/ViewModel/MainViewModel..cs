using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetManager.ViewModel
{
    public class MainViewModel : PropertyChanger
    {

        private object currentView;

        public object CurrentView
        {
            get => currentView;
            set => SetField(ref currentView, value, nameof(CurrentView));
        }

        public MainViewModel()
        {
            
            CurrentView = new Login(this);
        }

        public void ChangeView(object viewModel)
        {
            CurrentView = viewModel;
        }
    }
}
