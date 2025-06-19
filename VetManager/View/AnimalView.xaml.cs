using System.Windows;


namespace VetManager.View
{
    /// <summary>
    /// Interaction logic for AnimalView.xaml
    /// </summary>
    public partial class AnimalView
    {
        public AnimalView()
        {
            InitializeComponent();
            this.DataContext = new VetManager.ViewModel.PetsEdition();
        }
    }
}
