using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MainLogic.DataBase.Models
{
    public class OrganizationUnit
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public string Patronymic { get; set; }
        [Required]
        public int AmountEmployes { get; set; }
        [Required]
        public ProfessionType professionType { get; set; }
    }
}
