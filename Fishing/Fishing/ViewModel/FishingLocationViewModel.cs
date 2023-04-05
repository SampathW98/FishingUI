using Fishing.Models;
using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fishing.ViewModel
{
    public class FishingLocationViewModel : BaseViewModel
    {
        private FishingLocationModel location;

        public FishingLocationModel Location { get => location; set => location = value; }

        public string PeopleAtLocation { 
            get
            {
                var first = location.People.FirstOrDefault();
                if (first == null)
                    return "It's just you";
                return $"{first.Name} and {location.People.Count - 1} others";
            }
        }


        public FishingLocationViewModel(FishingLocationModel location)
        {
            this.location = location;
        }

    }
}
