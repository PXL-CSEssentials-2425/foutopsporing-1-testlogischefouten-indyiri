using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace H10Oef1TestLogischeFouten
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        Random random = new Random();

        int randomImage;

        private void startButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int product = 0;

                int counter = 1;

                int number = 0;

                resultTextBox.Text = "";

                number = Convert.ToInt32(numberTextBox.Text);

                while (product <= 1000 || counter <= 51)
                {
                    product = number * counter;

                    resultTextBox.Text += $"{counter} x {number} = {product}\n";

                    counter++;
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
                numberTextBox.Focus();
            }
        }

        private void start2Button_Click(object sender, RoutedEventArgs e)
        {
            int product = 0;

            int counter = 1;

            int number = 0;

            resultTextBox.Text = "";

            number = Convert.ToInt32(numberTextBox.Text);

            while (product <= 1000 && counter <= 51)

            {
                resultTextBox.Text = resultTextBox.Text + counter.ToString() + " x " +

                number.ToString() + " = " + product.ToString() + "\r\n";

                counter++;

            }
        }

        private void showImageButton_Click(object sender, RoutedEventArgs e)
        {
            randomImage = random.Next(0,10);

            if (randomImage == 0)
            {
                showImage.Source = new BitmapImage(new Uri("Images/zee0.jpg", UriKind.Relative));
            }
            else if (randomImage == 1)
            {
                showImage.Source = new BitmapImage(new Uri("Images/zee1.jpg", UriKind.Relative));
            }
            else if (randomImage == 2)
            {
                showImage.Source = new BitmapImage(new Uri("Images/zee2.jpg", UriKind.Relative));
            }
            else if (randomImage == 3)
            {
                showImage.Source = new BitmapImage(new Uri("Images/zee3.jpg", UriKind.Relative));
            }
            else if (randomImage == 4)
            {
                showImage.Source = new BitmapImage(new Uri("Images/zee4.jpg", UriKind.Relative));
            }
            else if (randomImage == 5)
            {
                showImage.Source = new BitmapImage(new Uri("Images/zee5.jpg", UriKind.Relative));
            }
            else if (randomImage == 6)
            {
                showImage.Source = new BitmapImage(new Uri("Images/zee6.jpg", UriKind.Relative));
            }
            else if (randomImage == 7)
            {
                showImage.Source = new BitmapImage(new Uri("Images/zee7.jpg", UriKind.Relative));
            }
            else if (randomImage == 8)
            {
                showImage.Source = new BitmapImage(new Uri("Images/zee8.jpg", UriKind.Relative));
            }
            else if (randomImage == 9)
            {
                showImage.Source = new BitmapImage(new Uri("Images/zee9.jpg", UriKind.Relative));
            }
        }

        private void showImageWithCheckButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {  
                randomImage = random.Next(0, 10);

                if (randomImage == 0)
                {
                    showImage.Source = new BitmapImage(new Uri("Images/zee0.jpg", UriKind.Relative));
                }
                else if (randomImage == 1)
                {
                    showImage.Source = new BitmapImage(new Uri("Images/zee1.jpg", UriKind.Relative));
                }
                else if (randomImage == 2)
                {
                    showImage.Source = new BitmapImage(new Uri("Images/zee2.jpg", UriKind.Relative));
                }
                else if (randomImage == 3)
                {
                    showImage.Source = new BitmapImage(new Uri("Images/zee3.jpg", UriKind.Relative));
                }
                else if (randomImage == 4)
                {
                    showImage.Source = new BitmapImage(new Uri("Images/zee4.jpg", UriKind.Relative));
                }
                else if (randomImage == 5)
                {
                    showImage.Source = new BitmapImage(new Uri("Images/zee5.jpg", UriKind.Relative));
                }
                else if (randomImage == 6)
                {
                    showImage.Source = new BitmapImage(new Uri("Images/zee6.jpg", UriKind.Relative));
                }
                else if (randomImage == 7)
                {
                    showImage.Source = new BitmapImage(new Uri("Images/zee7.jpg", UriKind.Relative));
                }
                else if (randomImage == 8)
                {
                    showImage.Source = new BitmapImage(new Uri("Images/zee8.jpg", UriKind.Relative));
                }
                else if (randomImage == 9)
                {
                    showImage.Source = new BitmapImage(new Uri("Images/zee9.jpg", UriKind.Relative));
                }
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message, "Image not found!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void startCorrectButton_Click(object sender, RoutedEventArgs e)
        {
            {
                int product = 0;

                int counter = 1;

                int number = 0;

                resultTextBox.Text = "";

                number = Convert.ToInt32(numberTextBox.Text);

                while (product <= 1000 && counter <= 51)
                {
                    product = number * counter;

                    resultTextBox.Text += $"{counter} x {number} = {product}\n";

                    counter++;
                }
            }
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            numberTextBox.Clear();
            resultTextBox.Clear();
            numberTextBox.Focus();
        }

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}