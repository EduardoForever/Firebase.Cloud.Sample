using Plugin.CloudFirestore.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Firebase.sample.Cloud.Models
{
    public class FirebaseModel
    {
        [Id]
        public string Id { get; set; }

        public string OwnerId { get; set; }
    }
}
