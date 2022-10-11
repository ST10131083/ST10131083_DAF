using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ST10131083_DAF.Models.Dashboard
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public virtual ICollection<Disaster> Disasters { get; set; }
        public virtual ICollection<Good> Goods { get; set; }
    }
}
