using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebProject.Models
{
    public class Comment
    {
        public int CommentID { get; set; }

        public string CommentContent { get; set; }

        public int UserID;

        public User User { get; set; }

        public int ProductID;

        public Product Product { get; set; }
    }
}
