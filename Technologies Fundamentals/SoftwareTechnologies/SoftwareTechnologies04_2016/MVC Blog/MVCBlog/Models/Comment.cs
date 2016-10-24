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
    public class Comment
    {
        public Comment()
        {
            this.Date = DateTime.Now.Date;
        }
        
        public int Id { get; set; }
        public string Text { get; set; }
        public Post Post { get; set; }
        public string Body { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        
        [ForeignKey("Author_Id")]
        public ApplicationUser Author { get; set; }
        public string Author_Id { get; set; }
      }  
    }
