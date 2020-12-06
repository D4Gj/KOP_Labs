using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MainLogic.DataBase;
using System.Threading.Tasks;
using MainLogic.BindingModel;
using MainLogic.DataBase.Models;
using MainLogic.ViewModel;

namespace MainLogic.Logic
{
    public class OrganizationUnitLogic : IOrganizationUnitLogic
    {
        public void CreateOrUpdate(OrganizationUnitBindingModel model)
        {
            OrganizationUnit organizationUnit;
            using (var context = new Database())
            {

                if (model.Id.HasValue)
                {
                    organizationUnit = context.OrganizationUnit.FirstOrDefault(rec => rec.Id == model.Id);
                    if (organizationUnit == null)
                    {
                        throw new Exception("Элемент не найден");
                    }
                }
                else
                {
                    organizationUnit = new OrganizationUnit
                    {
                        Name = model.Name,
                        Surname = model.Surname,
                        Patronymic = model.Patronymic,
                        AmountEmployes = model.AmountEmployes,
                        professionType = model.professionType
                    };
                    context.OrganizationUnit.Add(organizationUnit);
                    context.SaveChanges();
                    return;
                }
                organizationUnit.Name = model.Name;
                organizationUnit.Surname = model.Surname;
                organizationUnit.Patronymic = model.Patronymic;
                organizationUnit.professionType = model.professionType;
                organizationUnit.AmountEmployes = model.AmountEmployes;
                context.SaveChanges();
            }
        }
        public void Delete(OrganizationUnitBindingModel model)
        {
            using (var context = new Database())
            {
                var unit = context.OrganizationUnit.FirstOrDefault(rec => rec.Id == model.Id);
                if (unit != null)
                {
                    context.OrganizationUnit.Remove(unit);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Элемент не найден");
                }
            }
        }

        public List<OrganizationUnitViewModel> Read(OrganizationUnitBindingModel filter)
        {
            using (var context = new Database())
            {
                return context.OrganizationUnit
                .Where(rec => filter == null || rec.Id == filter.Id)
                .ToList()
               .Select(rec => new OrganizationUnitViewModel
               {
                   Id = rec.Id,
                   Name = rec.Name,
                   Surname = rec.Surname,
                   Patronymic = rec.Patronymic,
                   professionType = rec.professionType,
                   AmountEmployes = rec.AmountEmployes
               })
               .ToList();
            }
        }
    }
}
