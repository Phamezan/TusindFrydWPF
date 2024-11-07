using System.Windows;

namespace TusindFrydWPF
{
    public partial class MainWindow : Window
    {
        List<FlowerSort> flowerSorts;
        public MainWindow()
        {
            InitializeComponent();
            flowerSorts = new List<FlowerSort>();
        }

        private void btnOpretBlomst_Click(object sender, RoutedEventArgs e)
        {
            CreateFlowerSortDialog createFlowerSortDialog = new CreateFlowerSortDialog();
            createFlowerSortDialog.ShowDialog();
            if (createFlowerSortDialog.DialogResult == true)
            {
                flowerSorts.Add(createFlowerSortDialog.flowerSort);
                txtblockBlomster.Text = string.Join("\n", flowerSorts.Select(sort => $"{sort.Name}:{sort.ProductionTime}:{sort.HalfLifeTime}:{sort.Size}"));
            }
        }
    }
}