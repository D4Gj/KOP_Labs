using MainLogic.Patterns.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainLogic.BindingModel;
using MainLogic.DataBase.Models;

namespace MainLogic.Patterns
{
    public class ConcreteBuilder : IBuilderOrganizationUnit
    {
        private OrganizationUnitBindingModel unit = new OrganizationUnitBindingModel();

        public OrganizationUnitBindingModel Build()
        {
            return unit;
        }

        public void SetAmountEmployes()
        {
            unit.AmountEmployes = 5;
        }

        public void SetName()
        {
            unit.Name = "vasya";
        }

        public void SetPatronymic()
        {
            unit.Patronymic = "vasyavich";
        }

        public void SetSurname()
        {
            unit.Surname = "vasyaev";
        }

        public void SetTypeOrganization()
        {
            unit.professionType = ProfessionType.Manager;
        }
    }
}
