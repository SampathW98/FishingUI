using Fishing.Models;
using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fishing.ViewModel
{
    public class FishingLocationViewModel : BaseViewModel
    {
        private FishingLocationModel location;

        public FishingLocationModel Locaton { get => location; set => location = value; }


        public FishingLocationViewModel(FishingLocationModel location)
        {
            this.location = location;
        }

    }
}
