using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    [Table("Coins")]
    public class Coin
    {

        public int Id { get; set; }
        public string Name { get; set; }
        [ForeignKey("ForumId")]
        public Forum Forum { get; set; }

        public int ForumId { get; set; }
        public ICollection<Post> Posts { get; set; }
            = new List<Post>();

    }
}
