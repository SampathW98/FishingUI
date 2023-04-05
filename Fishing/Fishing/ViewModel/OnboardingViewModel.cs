using Fishing.Models;
using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Fishing.ViewModel
{
    public class OnboardingViewModel : BaseViewModel
    {
        private ObservableRangeCollection<OnboardingModel> items;
        public ObservableRangeCollection<OnboardingModel> Items { get => items; set => items = value; }


        public OnboardingViewModel()
        {
            //create dummy data
            Items = new ObservableRangeCollection<OnboardingModel>
            {
                new OnboardingModel
                {
                    Title = "Discover nature and catch the fish",
                    Content = "Coral king crab heelsplitter, in painted comber Banded eel bicolor blenny. Hippo tang snaggletooth shark, drenched rabbitfish.",
                    Image = "loadingImg01"
                },
                new OnboardingModel
                {
                    Title = "Find new fishing spots",
                    Content = "Peppered moray stingray grouper our kelp. Puffer fish stingray, bicolor blenny and quickly moving, stingray menacing crab flounder, " +
                    "black clown goby hammerhead with lobster crawling butterflyfish.",
                    Image = "loadingImg02"
                },
                new OnboardingModel
                {
                    Title = "Who is fishing near me",
                    Content = "Butter hamlet bonnethead elktoe. Bursa trigger funny filefish, a Snaggletooth shark lobster in. ",
                    Image = "loadingImg03"
                }
            };

        }

    }
}
