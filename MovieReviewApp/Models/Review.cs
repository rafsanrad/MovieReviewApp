using System;

namespace MovieReviewApp.Models
{
    public class Review
    {
        public int ReviewId { get; set; }

        public int UserId { get; set; }

        public int MovieId { get; set; }

        public int Rating { get; set; }

        public string Comment { get; set; }

        public DateTime ReviewDate { get; set; }

        // Display information
        public string UserName { get; set; }

        public string MovieTitle { get; set; }
    }
}