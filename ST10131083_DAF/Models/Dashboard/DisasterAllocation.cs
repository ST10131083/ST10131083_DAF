using System.ComponentModel.DataAnnotations;

namespace ST10131083_DAF.Models.Dashboard
{
    public class DisasterAllocation
    {
        [Key]
        public int DisasterAllocationId { get; set; }
        public string DisasterName { get; set; }
        public string AmountDonated { get; set; }
        public string GoodsDonated { get; set; }
        public string AmountGoal { get; set; }

        public virtual Disaster Disaster { get; set; }
        public virtual Donation Donation { get; set; }

    }
}
