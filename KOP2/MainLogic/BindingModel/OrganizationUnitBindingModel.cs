using MainLogic.DataBase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MainLogic.BindingModel
{
    public class OrganizationUnitBindingModel
    {
        public int? Id { get; set; }

        public string Name { get; set; }
      
        public string Surname { get; set; }
      
        public string Patronymic { get; set; }
    
        public int AmountEmployes { get; set; }
        
        public ProfessionType professionType { get; set; }
    }
}
