using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainLogic.DataBase.Models;
using System.ComponentModel;

namespace MainLogic.ViewModel
{
    public class OrganizationUnitViewModel
    {
        public int Id { get; set; }
        [DisplayName("Имя")]
        public string Name { get; set; }
        [DisplayName("Фамилия")]
        public string Surname { get; set; }
        [DisplayName("Отчество")]
        public string Patronymic { get; set; }        
        [DisplayName("Количество сотрудников")]
        public int AmountEmployes { get; set; }
        [DisplayName("Профессия")]
        public ProfessionType professionType { get; set; }
    }
}
