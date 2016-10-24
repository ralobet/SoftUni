using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace MVCBlog.Models
{
    public class Post
    {
        public Post()
        {
            this.Date = DateTime.Now.Date;
        }
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(250)]
        public string Title { get; set; }
        [Required]
        [DataType(DataType.MultilineText)]
        public string Body { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        
        [ForeignKey("Author_Id")]
        public ApplicationUser Author { get; set; }
        public string Author_Id { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}