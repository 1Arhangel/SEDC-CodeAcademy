using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAcademy.MVCModels.v2._0.WebApp.Models
{
    public class Customer
    {
        public int ID { get; set; }

        [Required]
        [StringLength(30, MinimumLength =2, ErrorMessage = "Името не го даваме")]
        public string Name { get; set; }


        [Required]
        [StringLength(30, MinimumLength = 2)]
        public string Surname { get; set; }


        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }


        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }


        //allow nulls = ?
        //calendar on UI
        [DataType(DataType.Date)]
        public DateTime? DateOfBirth { get; set; }


        public bool IsVIP { get; set; }

        
    }
}
