using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taekwondo.DataAccessLayer.Modeles
{
    public class Technique
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Traduction { get; set; }
        public string Description { get; set; }
        private string CriteresValidite { get; set; }
        public TypeTechnique Type { get; set; }
        public MembreAnatomique Membre { get; set; }
        public GradeAdulte GradeAdulte { get; set; }
        public GradeEnfant GradeEnfant { get; set; }

        private readonly string _separator = "; ";



        public string[] GetCriteresValidite()
        {
            if (string.IsNullOrWhiteSpace(CriteresValidite))
            {
                return Array.Empty<string>();
            }

            return CriteresValidite.Split(_separator, StringSplitOptions.RemoveEmptyEntries);
        }

        public void SetCriteresValidite(string[] criteres)
        {
            if (criteres != null && criteres.Length > 0)
            {
                CriteresValidite = string.Join(_separator, criteres);
            }
        }
    }
}
