using FinalProjectAPI.Mediator;
using FinalProjectAPI.Models;

namespace FinalProjectAPI.Decorator
{
    public abstract class EntertainmentBase
    {
        public List<EntertainmentItem> catalog { get; set; }
        public abstract List<EntertainmentItem> Operation();
        public IMediator mediator;
    }
}
