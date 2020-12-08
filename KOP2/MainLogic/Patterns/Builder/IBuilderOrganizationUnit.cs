using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainLogic.BindingModel;

namespace MainLogic.Patterns.Builder
{
    public interface IBuilderOrganizationUnit
    {
        void SetName();
        void SetSurname();
        void SetPatronymic();
        void SetAmountEmployes();
        void SetTypeOrganization();
        OrganizationUnitBindingModel Build();
    }
}
