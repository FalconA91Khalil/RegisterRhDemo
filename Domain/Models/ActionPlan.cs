using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class ActionPlan
    {
        public int ActionPlanId { get; set; }
        public int RiskId { get; set; }
        public bool MakeActionPlan { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Responsible { get; set; }
        public string Deadline { get; set; }
        public decimal EstimatedCost { get; set; }
        public bool ActionPlanCompleted { get; set; }
        public int ProficiencyLevel { get; set; }
        public int ResidualRisk { get; set; }
    }
}
