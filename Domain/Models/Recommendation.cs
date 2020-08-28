using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class Recommendation
    {
        public int RecommendationId { get; set; }
        public int RiskId { get; set; }
        public string Recommendations { get; set; }

    }
}
