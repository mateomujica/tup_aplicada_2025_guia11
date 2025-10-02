using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometriaModels.Models
{
     abstract class FiguraModel
    {
        public int? Id { get; set; }

        public double? Area { get; set; }
    }
}
