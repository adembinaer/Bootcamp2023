using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherApp
{
    class WeatherMapResponse
    {
        //Nugget Packages Newtonsoft.Json zum JSON in c# konventieren zu können
        public Main main;
        public List<Weather> weather;

        //weather[0].description;
    }
}
