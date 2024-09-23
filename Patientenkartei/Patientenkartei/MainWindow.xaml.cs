using System;
using System.Windows;
using System.IO; // Input/Output
using System.Text;


namespace Patientenkartei
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

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            string content = textBoxContent.Text;
            string filename = textBoxFileName.Text;
            Console.WriteLine(content + filename); // Test ob clickbutton funktionert
            string dirPath = "C:/Users/Adem Mirsada/Desktop/"; // @"C:\Users\Adem Mirsada\Desktop\";

            using (FileStream fs = File.Create(dirPath + filename + ".txt")) //filename ist hier der "path" //.txt angeben wenn man direkt weiss welchen Datentyp man braucht.
            {
                byte[] contentConvertedToBytes = Encoding.ASCII.GetBytes(content);
                fs.Write(contentConvertedToBytes, 0, contentConvertedToBytes.Length); //offset = wo beginnen 0 = vom anfang
            }
            MessageBox.Show("Datei wurde angelegt");
        }
    }
}
