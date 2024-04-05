using System.Windows;
using System.Windows.Controls;

namespace QuestionnaireApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            string color = ((ComboBoxItem)cmbColor.SelectedItem).Content.ToString();
            string animal = ((ComboBoxItem)cmbAnimal.SelectedItem).Content.ToString();
            string season = ((ComboBoxItem)cmbSeason.SelectedItem).Content.ToString();

            MessageBox.Show($"Your answers:\nFavorite color: {color}\nFavorite animal: {animal}\nFavorite season: {season}");
        }
    }
}

