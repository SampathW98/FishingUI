using Fishing.Models;
using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fishing.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        public string UserImage { get; set; }
        public string Location { get; set; }
        public string Temp { get; set; }
        public string CurrentDate { get; set; }
        public string WeatherCondition { get; set; }
        public string WeatherIcon { get; set; }
        public string ChanceOfRain { get; set; }

        public ObservableRangeCollection<FishingLocationViewModel> FishingLocations { get; set; }


        public MainViewModel()
        {
            Location = "Mataram";
            Temp = "30°C";
            CurrentDate = "Web 15 March, 2021";
            WeatherCondition = "Sunny Day";
            WeatherIcon = "SunnyIcon";
            ChanceOfRain = "15%";
            UserImage = "https://randomuser.me/api/portraits/men/32.jpg";


            var firstLocation = new FishingLocationViewModel(
                new FishingLocationModel()
                {
                    Name = "South Mandalika Lake",
                    LatLong = "8°53'54.2“S 116°18'14.2“E",
                    LocationThumbnail = "https://raw.githubusercontent.com/kphillpotts/Fishing/main/images/Location1.png",
                    MapThumbnail = "https://raw.githubusercontent.com/kphillpotts/Fishing/main/images/Location1Map.png",
                    PanoramaImage = "https://raw.githubusercontent.com/kphillpotts/Fishing/main/images/lake-panorama-1.png",
                }
            );
        }
    }
}