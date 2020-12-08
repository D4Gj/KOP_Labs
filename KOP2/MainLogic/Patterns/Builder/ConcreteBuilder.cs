using MainLogic.Patterns.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainLogic.Patterns
{
    public class ConcreteBuilder : IBuilderUnit
    {
        private Unit unit = new Unit();

        public void SetName()
        {
            unit.Name = "Кириллл";
        }

        public void SetPatronymic()
        {
            unit.Patronymic = "Олегович";
        }
        

        public void Set()
        {
            unit.Surname = "Сурков";
        }

        public void SetTypeUnit()
        {
            unit.TypeUnit = "123";
        }

        public Unit Build()
        {
            return unit;
        }

        public void SetSurname()
        {
            throw new NotImplementedException();
        }

        public void SetAmountEmployes()
        {
            unit.AmountEmployee = "23";
        }

        public void SetTypeOrganization()
        {
            unit.TypeUnit = Enum;
        }
    }
}
