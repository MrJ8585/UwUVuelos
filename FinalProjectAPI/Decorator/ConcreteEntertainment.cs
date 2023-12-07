using FinalProjectAPI.Models;

namespace FinalProjectAPI.Decorator
{
    public class ConcreteEntertainment : EntertainmentBase
    {
        public override List<EntertainmentItem> Operation()
        {
            return catalog;
        }
    }
}
