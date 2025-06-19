using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetManager.ViewModel
{
    class Pets : PropertyChanger
    {
        private MainViewModel mainVm;

        public Pets(MainViewModel mainVm)
        {
            this.mainVm = mainVm;
        }
    }
}
