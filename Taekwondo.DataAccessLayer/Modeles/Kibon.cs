using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taekwondo.DataAccessLayer.Modeles
{
    public class Kibon
    {
        public int Id { get; set; }
        public int NombreTechnique { get; set; }
        public IList<Technique> Techniques { get; set; } = new List<Technique>();
        public NiveauDifficulte NiveauDifficulte { get; set; }

    }
}
