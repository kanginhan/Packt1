using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Packt1.Data.Entities
{
    public class ProductFeature
    {
        public int ProductId { get; set; }
        public int FeatureId { get; set; }

        public Product Product { get; set; }
        public Feature Feature { get; set; }
    }
}
