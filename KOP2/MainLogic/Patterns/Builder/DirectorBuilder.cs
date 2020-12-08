using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainLogic.Patterns.Builder
{
    public class DirectorBuilder
    {
        public Unit Build(IBuilderUnit builderUnit)
        {
            builderUnit.SetName();
            builderUnit.SetPatronymic();
            builderUnit.SetTypeOrganization();
            builderUnit.SetSurname();
            builderUnit.SetTypeOrganization();
            return builderUnit.Build();
        }
    }
}
