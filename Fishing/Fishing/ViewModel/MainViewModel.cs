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

                    People = new System.Collections.Generic.List<PeopleModel>()
                    {
                        new PeopleModel()
                        {
                            Name = "James",
                            Image = "https://randomuser.me/api/portraits/men/13.jpg"
                        },
                        new PeopleModel()
                        {
                            Name = "Jenny",
                            Image = "https://randomuser.me/api/portraits/women/89.jpg"
                        },
                        new PeopleModel()
                        {
                            Name = "Rose",
                            Image = "https://randomuser.me/api/portraits/men/13.jpg"
                        },
                    },

                    Fish = new System.Collections.Generic.List<FishModel>()
                    {
                        new FishModel()
                        {
                            Name="Mysterious Flying Flish",
                            Image = "https://raw.githubusercontent.com/kphillpotts/Fishing/main/images/Fish2.png",

                        },
                        new FishModel()
                        {
                            Name="Silver Fish",
                            Image = "https://raw.githubusercontent.com/kphillpotts/Fishing/main/images/Fish1.png",
                        }
                    }
                });

            var secondLocation = new FishingLocationViewModel(
                new FishingLocationModel()
                {
                    Name = "North Mandalika Lake",
                    LatLong = "8°53'54.2“S 116°18'14.2“E",
                    LocationThumbnail = "https://raw.githubusercontent.com/kphillpotts/Fishing/main/images/Location2.png",
                    MapThumbnail = "https://raw.githubusercontent.com/kphillpotts/Fishing/main/images/Location2Map.png",
                    PanoramaImage = "https://raw.githubusercontent.com/kphillpotts/Fishing/main/images/lake-panorama-1.png",

                    People = new System.Collections.Generic.List<PeopleModel>()
                    {
                        new PeopleModel()
                        {
                            Name = "Frank",
                            Image = "https://randomuser.me/api/portraits/men/11.jpg"
                        },
                        new PeopleModel()
                        {
                            Name = "Jenny",
                            Image = "https://randomuser.me/api/portraits/women/89.jpg"
                        },
                        new PeopleModel()
                        {
                            Name = "Rose",
                            Image = "https://randomuser.me/api/portraits/men/13.jpg"
                        },
                        new PeopleModel()
                        {
                            Name = "Josh",
                            Image = "https://randomuser.me/api/portraits/men/2.jpg"
                        },
                        new PeopleModel()
                        {
                            Name = "George",
                            Image = "https://randomuser.me/api/portraits/men/3.jpg"
                        },
                    },

                    Fish = new System.Collections.Generic.List<FishModel>()
                    {
                        new FishModel()
                        {
                            Name="Mysterious Flying Flish",
                            Image = "https://raw.githubusercontent.com/kphillpotts/Fishing/main/images/Fish2.png",

                        },
                    }
                });

            FishingLocations = new ObservableRangeCollection<FishingLocationViewModel>();
            FishingLocations.Add(firstLocation);
            FishingLocations.Add(secondLocation);
        }
    }
}