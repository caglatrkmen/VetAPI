using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VeterinerAPI.Entities
{
    public class Patients:IEntity
    {
        public int Id { get; set; }

        public string HastaAdi { get; set; }

        public byte[] HastaFotograf { get; set; }

        public string Cinsi { get; set; }

        public string Tani { get; set; }

        public string SahipAdi { get; set; }

        public string SahipSoyadi { get; set; }

        public string SahipTel { get; set; }
    }
}
