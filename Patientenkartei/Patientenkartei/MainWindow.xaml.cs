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
        //3 Streamarten File, Memory, Network

        public const string DIR_PATH = @"C:\Users\Adem Mirsada\Desktop\";
        public const string FILE_EXT = ".txt";
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

            //using-parameter ohne const
            using (FileStream fs = File.Create(dirPath + filename + ".txt")) //filename ist hier der "path" //.txt angeben wenn man direkt weiss welchen Datentyp man braucht.
            {
                byte[] contentConvertedToBytes = Encoding.ASCII.GetBytes(content);
                fs.Write(contentConvertedToBytes, 0, contentConvertedToBytes.Length); //offset = wo beginnen 0 = vom anfang
            }
            MessageBox.Show("Datei wurde angelegt");
        }

        private void btnRead_Click(object sender, RoutedEventArgs e)
        {
            string filename = textBoxFileName.Text;
            
            //using-paramter mit const
            using (FileStream fs = File.OpenRead(DIR_PATH + filename + FILE_EXT))
            {
                //Helferklasse StreamReader/StreamWriter bequemer weg, keine tiefen bytes Litaratur wie bei FileStream File.Create();
                using(StreamReader sr = new StreamReader(fs))
                {
                    string content = sr.ReadToEnd();
                    textBoxContent.Text = content;
                }

                ////Nur zur Darstellung StreamWriter
                //using (StreamWriter sr = new StreamWriter(fs))
                //{
                //    string content = sr.Write();
                //    textBoxContent.Text = content;
                //}
            }
        }
    }
}
