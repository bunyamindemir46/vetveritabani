using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace vetveritabani.Entity
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public int? Olusturan { get; set; }
        public int? Guncelleyen { get; set; }
        public DateTime? OlusTar { get; set; }
        public DateTime? GuncelTar { get; set; }
    }
}
