using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taekwondo.DataAccessLayer.Modeles
{
    public class HistoriqueKibon
    {
        public int Id { get; set; }
        public int NombreKibons { get; private set; }
        public string KibonsStr { get; set; }
        public IList<Kibon> Kibons { get; private set; }
        public DateTime DateCreation { get; private set; }

        private readonly string _separator = "; ";

        public HistoriqueKibon(string[] kibonsStr, IList<Kibon> kibons)
        {
            SetKibons(kibonsStr);

            if (string.IsNullOrWhiteSpace(KibonsStr))
            {
                return;
            }

            NombreKibons = kibons.Count;
            Kibons = kibons;
            DateCreation = DateTime.Now;
        }

        public string[] GetKibons()
        {
            if (string.IsNullOrWhiteSpace(KibonsStr))
            {
                return Array.Empty<string>();
            }

            return KibonsStr.Split(_separator, StringSplitOptions.RemoveEmptyEntries);
        }

        private void SetKibons(IEnumerable<string> kibons)
        {
            if (kibons == null || !kibons.Any())
            {
                return;
            }
            KibonsStr = string.Join(_separator, kibons);
        }
    }
}
