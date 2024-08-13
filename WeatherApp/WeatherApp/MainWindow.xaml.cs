using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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

namespace WeatherApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly string apiKey = "daa165c2d50865a2078272770f6cadc8";

        private readonly string requestUrl = "http://api.openweathermap.org/geo/1.0/direct"; // Direkt von OpenWeather "http://api.openweathermap.org/geo/1.0/direct?q={city name},{state code},{country code}&limit={limit}&appid={API key}";
        public MainWindow()
        {
            InitializeComponent();

            HttpClient httpClient = new HttpClient();

            var city = "Berlin";
            var finalUri = requestUrl + "?q=" + city + "&appid" + apiKey;

            // Antwort vom Server HttpClient GetAsync() auf Fragestellung von HttpResponseMessage 
            HttpResponseMessage httpResponse = httpClient.GetAsync(finalUri).Result; //GetAsync = Neue Thread läuft asynchron weiter
            //Testlauf was erhalten von httpResponse
            string response = httpResponse.Content.ReadAsStringAsync().Result;

            Console.WriteLine(response);

        }
    }
}
