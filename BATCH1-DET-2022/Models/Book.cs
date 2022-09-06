using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BATCH1_DET_2022.Models
{
    [Table("Book")]
    public class Book
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]

        [Required]
        public int BookID { get; set; }

        [Required]
        public string BookName { get; set; }

        
        public string author { get; set; }

        public int price { get; set; }


    }
}
