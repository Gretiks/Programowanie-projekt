using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetManager.ViewModel
{
    class Owners : PropertyChanger
    {
        private MainViewModel mainVm;

        public Owners(MainViewModel mainVm)
        {
            this.mainVm = mainVm;
        }
    }
}
