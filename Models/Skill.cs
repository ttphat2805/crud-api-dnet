using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace crud_api_dnet.Models
{
    public class Skill
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Damage { get; set; }
        public int? HitPointId { get; set; }
        [ForeignKey("HitPointId")]
        public virtual Character? Character { get; set; }
    }
}