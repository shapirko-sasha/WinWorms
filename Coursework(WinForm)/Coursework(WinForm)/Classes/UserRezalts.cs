using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework_WinForm_.Classes
{
    [Table("tblUserRezalts")]
    public class UserRezalts
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int UserScore { get; set; }

        [ForeignKey("DBUser")]
        public int UserID { get; set; }

        public virtual DBUser DBUser { get; set; }
    }
}
