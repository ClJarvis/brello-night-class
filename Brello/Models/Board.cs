using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brello.Tests.Models
{
    public class Board
    {
        public int BoardId { get; set; }
        public int Title { get; set; }
        public virtual ICollection<BrelloList> Lists { get; set; }
        public virtual ICollection<Brello.Models.ApplicationUser> Followers { get; set; }
    }
}
