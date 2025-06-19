using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetManager.ViewModel
{
    class Visits : PropertyChanger
    {
        private MainViewModel mainVm;

        public Visits(MainViewModel mainVm)
        {
            this.mainVm = mainVm;
        }
    }
}
