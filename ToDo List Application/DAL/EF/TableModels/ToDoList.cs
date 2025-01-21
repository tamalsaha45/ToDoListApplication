using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.TableModels
{
    public class ToDoList
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        [StringLength(50)]
        public string Status { get; set; }
        [Required]
        public DateTime DueDate { get; set; }
        [Required]
        [StringLength(50)]
        public string Priority { get; set; }
        [Required]
        [StringLength(50)]
        public string Category { get; set; }


        public virtual User User { get; set; }
        [ForeignKey("User")]
        [Required]
        public int UserId { get; set; }


    }
}
