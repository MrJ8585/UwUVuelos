using FinalProjectAPI.Models;

namespace FinalProjectAPI.Decorator
{
    public class InfantDecorator : BaseDecorator
    {
        public InfantDecorator(EntertainmentBase entertainment) : base(entertainment)
        {
            catalog = entertainment.catalog;
        }
        public override List<EntertainmentItem> Operation()
        {
            List<EntertainmentItem> filteredList = catalog.Where(item => item.Infantil == false).ToList();
            catalog = filteredList;
            return base.Operation();
        }
    }
}
