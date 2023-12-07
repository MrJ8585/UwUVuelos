using FinalProjectAPI.Models;
using System.Linq;

namespace FinalProjectAPI.Decorator
{
    public class ChinaDecorator : BaseDecorator
    {
        public ChinaDecorator(EntertainmentBase entertainment) : base(entertainment)
        {
            catalog = entertainment.catalog;
        }
        public override List<EntertainmentItem> Operation()
        {
            List<EntertainmentItem> filteredList = catalog.Where(item => item.China == false).ToList();
            catalog = filteredList;
            return base.Operation();
        }
    }
}
