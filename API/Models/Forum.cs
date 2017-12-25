using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    [Table("Forums")]
    public class Forum
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Coin> Coins { get; set; }    
            = new List<Coin>();
    }
}
