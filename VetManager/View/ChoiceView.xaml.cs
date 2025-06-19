using System.Diagnostics;
using System.Windows;
using VetManager.ViewModel;

namespace VetManager.View
{
    /// <summary>
    /// Interaction logic for ChoiceView.xaml
    /// </summary>
    public partial class ChoiceView
    {
        public ChoiceView()
        {
            InitializeComponent();
            this.DataContext = new Choice(new MainViewModel());
            //Debug.WriteLine(DataContext?.GetType().Name);
        }
    }
}