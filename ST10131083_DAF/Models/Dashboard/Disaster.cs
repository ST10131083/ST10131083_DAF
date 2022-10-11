﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ST10131083_DAF.Models.Dashboard
{
    public class Disaster
    {
        [Key]
        public int DisasterId { get; set; }
        public string DisasterName { get; set; }
        public string DisasterType { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public double AmountAllocation { get; set; }
        //[ForeignKey("CategoryId")]
        public int Categoryid { get; set; }
        public virtual Category Category { get; set; }


    }
}