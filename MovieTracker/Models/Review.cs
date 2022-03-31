using System;
using System.Collections.Generic;

namespace MovieTracker.Models
{
    public partial class Review
    {
        public Guid ReviewId { get; set; }
        public Guid MovieId { get; set; }
        public string Person { get; set; } = null!;
        public string Text { get; set; } = null!;
        public DateTime CreatedOn { get; set; }
        public int Rating { get; set; }
    }
}
