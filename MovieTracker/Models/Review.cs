using System;
using System.Collections.Generic;

namespace MovieTracker.Models
{
    public partial class Review
    {
        public Guid ReviewId { get; set; }
        public Guid MovieId { get; set; }
        public string Author { get; set; } = null!;
        public string Text { get; set; } = null!;
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public bool IsDeleted { get; set; }
        public int Rating { get; set; }
    }
}
