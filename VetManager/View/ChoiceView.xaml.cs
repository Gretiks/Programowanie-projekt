using System.Windows;

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
            this.DataContext = new VetManager.ViewModel.Choice();
        }
    }
}