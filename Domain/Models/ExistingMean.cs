using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class ExistingMean
    {
        public int ExistingMeanId { get; set; }
        public int RiskId { get; set; }
        public bool MeansUsed { get; set; }
        public string Description { get; set; }
        public int ProfieciencyLevel { get; set; }
        public int ResidualRisk { get; set; }
    }
}
