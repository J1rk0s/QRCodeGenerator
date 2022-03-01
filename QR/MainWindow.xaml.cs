using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using QRCoder;
using QRCoder.Xaml;

namespace QR
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Generate_Click(object sender, RoutedEventArgs e)
        {
            string textZadan = Text.Text;
            QRCodeGenerator qRCodeGenerator = new QRCodeGenerator();

            QRCodeData dataQR = qRCodeGenerator.CreateQrCode(textZadan, QRCodeGenerator.ECCLevel.M);

            XamlQRCode qrcode = new XamlQRCode(dataQR);

            DrawingImage qrcoder = qrcode.GetGraphic(100);
            obrazek.Source = qrcoder;
        }
    }
}
