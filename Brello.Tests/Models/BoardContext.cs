using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Brello.Models;

namespace Brello.Tests.Models
{
    public class BoardContext : DbContext
    {
        //uses teh connetion strinng from teh web.config named "BoardContext"
        //public BoardContext() : base("name=BoardContext"){}
        public virtual IDbSet<Color> Colors { get; set; }
        public virtual IDbSet<Card> Cards { get; set; }
    }
}
