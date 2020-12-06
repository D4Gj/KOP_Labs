using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainLogic.ViewModel;
using MainLogic.BindingModel;

namespace MainLogic.Logic
{
    public interface IOrganizationUnitLogic
    {
        void CreateOrUpdate(OrganizationUnitBindingModel model);

        List<OrganizationUnitViewModel> Read(OrganizationUnitBindingModel filter);

        void Delete(OrganizationUnitBindingModel model);
    }
}
