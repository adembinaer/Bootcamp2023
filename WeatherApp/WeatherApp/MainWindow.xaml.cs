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
using Newtonsoft.Json;

namespace WeatherApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly string apiKey = "daa165c2d50865a2078272770f6cadc8";

        private readonly string requestUrl = "https://api.openweathermap.org/data/2.5/weather";
        // Direkt von OpenWeather "https://api.openweathermap.org/data/2.5/weather?q={city name}&appid={API key}";
        public MainWindow()
        {
            InitializeComponent();

            UpadateData("Sarajevo");

            //WeatherMapResponse result = GetWeatherData("Berlin");
            ////result. ...... 

            //string finalWeather = "sun.png";

            //string currentWeahter = result.weather[0].main.ToLower();

            //if (currentWeahter.Contains("rain"))
            //{
            //    finalWeather = "rain.png";
            //}
            //else if (currentWeahter.Contains("snow"))
            //{
            //    finalWeather = "snow.png";
            //}
            //else if (currentWeahter.Contains("cloud"))
            //{
            //    finalWeather = "cloud.png";
            //}

            //backroundImage.ImageSource = new BitmapImage(new Uri("images/" + finalWeather, UriKind.Relative));

            //labelCelsius.Content = result.main.temp.ToString("F1") + "°C";

            //labelInfo.Content = result.weather[0].main; // Dringend anschauen das mit weather[]. via openweather
        }

        public void UpadateData(string city)
        {
            WeatherMapResponse result = GetWeatherData(city);
        
            string finalWeather = "sun.png";

            string currentWeahter = result.weather[0].main.ToLower();

            if (currentWeahter.Contains("rain"))
            {
                finalWeather = "rain.png";
            }
            else if (currentWeahter.Contains("snow"))
            {
                finalWeather = "snow.png";
            }
            else if (currentWeahter.Contains("cloud"))
            {
                finalWeather = "cloud.png";
            }

            backroundImage.ImageSource = new BitmapImage(new Uri("images/" + finalWeather, UriKind.Relative));

            labelCelsius.Content = result.main.temp.ToString("F1") + "°C";

            labelInfo.Content = result.weather[0].main; 
        }
        public WeatherMapResponse GetWeatherData(string city)
        {
            HttpClient httpClient = new HttpClient();
            //var city = "Berlin";
            var finalUri = requestUrl + "?q=" + city + "&appid=" + apiKey + "&units=metric";
            // Antwort vom Server HttpClient GetAsync() auf Fragestellung von HttpResponseMessage 
            HttpResponseMessage httpResponse = httpClient.GetAsync(finalUri).Result; //GetAsync = Neue Thread läuft asynchron weiter
            //Testlauf was erhalten von httpResponse
            string response = httpResponse.Content.ReadAsStringAsync().Result;
            WeatherMapResponse weatherMapResponse = JsonConvert.DeserializeObject<WeatherMapResponse>(response);
            //weatherMapResponse.main.temp
            //Console.WriteLine(weatherMapResponse);
            return weatherMapResponse;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string query = textBoxQuery.Text;
            //WeatherMapResponse result = GetWeatherData(query);

            UpadateData(query);

        }
    }
}
