﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Brello.Models
{
    public class BoardContext : DbContext
    {
        // Uses the connection string from the Web.config named "BoardContext"
        /*
        public BoardContext() {
            Boards = new DbSet<Board>();
        }*/

        public virtual IDbSet<Color> Colors { get; set; }
        public virtual IDbSet<Card> Cards { get; set; }
        public virtual DbSet<Board> Boards { get; set; }
        public object BrelloList { get; internal set; }

        // IQueryable, IList/List, ICollection/Collection, IDbSet/Dbset
    }
}