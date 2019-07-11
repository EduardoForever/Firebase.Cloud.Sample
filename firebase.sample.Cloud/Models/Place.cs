using System;
namespace Firebase.sample.Cloud.Models
{
    public class Place : FirebaseModel
    {
        public string PlaceName { get; set; }
        public string PlaceImage { get; set; }
        public string Description { get; set; }
    }
}
