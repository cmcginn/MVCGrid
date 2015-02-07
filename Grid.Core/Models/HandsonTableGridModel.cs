using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grid.Core.Models
{
    public class HandsonTableGridModel:GridModel
    {
        public CellProperties[][] CellProperties { get; set; }
    }

    public class CellProperties
    {
        public bool ReadOnly { get; set; }
        public bool Hidden { get; set; }
    }
}
