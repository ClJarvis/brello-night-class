using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Brello.Models
{
    public class Board
    {
<<<<<<< HEAD
        [System.ComponentModel.DataAnnotations.Key]
=======
        [Key]
>>>>>>> 780784439ff333ec8eefc1857ee45d938ce4ca45
        public int BoardId { get; set; }
        public string Title { get; set; }
        public ApplicationUser Owner { get; set; }
        // Changed from ICollection to List
        public virtual List<BrelloList> Lists { get; set; }
        public virtual List<ApplicationUser> Followers { get; set; }

        public Board() {
            Lists = new List<BrelloList>();
            Followers = new List<ApplicationUser>();
        }

    }
}