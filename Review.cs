using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ratingSystem
{
    class Review
    {
        public static string criteriaFile = "criteria.txt";

        public string customerReview = "review.txt";

        //setting properties of Review Class
        public string CustomerName { get; set; }
        public string CustomerContact { get; set; }
        public string CustomerEmail { get; set; }
        public Dictionary<string, int> CustomerRating { get; set; } //property to get or set user feedback
        public DateTime datetime { get; set; }

    }
}
