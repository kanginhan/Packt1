using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Packt1.Features.Filters
{
    public class FiltersListViewModel
    {
        public IEnumerable<string> Brands { get; set; }
        public IEnumerable<int> Storage { get; set; }
        public IEnumerable<string> Colours { get; set; }
        public IEnumerable<string> OS { get; set; }
        public IEnumerable<string> Features { get; set; }
    }
}
