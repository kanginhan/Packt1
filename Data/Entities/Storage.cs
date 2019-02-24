using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Packt1.Data.Entities
{
    public class Storage
    {
        public int Id { get; set; }
        [Required]
        public int Capacity { get; set; }

        public List<ProductVariant> ProductVariants { get; set; } =
        new List<ProductVariant>();
    }
}
