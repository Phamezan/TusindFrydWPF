using Microsoft.Win32;
using System.Windows;
using System.Windows.Media.Imaging;

namespace TusindFrydWPF
{
    public partial class CreateFlowerSortDialog : Window
    {
        public FlowerSort flowerSort { get; set; }
        public CreateFlowerSortDialog()
        {
            InitializeComponent();
        }

        private void btnFil_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                Uri fileUri = new Uri(openFileDialog.FileName);
                imgFil.Source = new BitmapImage(fileUri);
            }
        }
        private void btnOK_Click(object sender, RoutedEventArgs e)
        {

            flowerSort.Name = txtboxName.Text;
            flowerSort.ProductionTime = int.Parse(txtboxProduktionsTid.Text);
            flowerSort.HalfLifeTime = int.Parse(txtboxHalveringsTid.Text);
            flowerSort.Size = int.Parse(txtboxStørrelse.Text);
            DialogResult = true;
        }

        private void txtboxTextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if(!string.IsNullOrEmpty(txtboxName.Text) 
                && !string.IsNullOrEmpty(txtboxProduktionsTid.Text) 
                && !string.IsNullOrEmpty(txtboxHalveringsTid.Text) && !string.IsNullOrEmpty(txtboxStørrelse.Text))
            {
                flowerSort = new FlowerSort();
                btnOK.IsEnabled = true;
            }
        }
        private void btnFortryd_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
