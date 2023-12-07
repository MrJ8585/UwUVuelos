using FinalProjectAPI.Mediator;
using FinalProjectAPI.Models;

namespace FinalProjectAPI.Decorator
{
    public abstract class BaseDecorator : EntertainmentBase
    {
        public EntertainmentBase entertainment;


        public BaseDecorator(EntertainmentBase entertainment)
        {
            this.entertainment = entertainment;
        }

        public override List<EntertainmentItem> Operation()
        {
            if (this.entertainment != null)
            {
                this.entertainment.catalog = catalog;
                this.entertainment.mediator = mediator;
                return this.entertainment.Operation();
            }
            else
            {
                return new List<EntertainmentItem>();
            }
        }
        public void SetMediator(IMediator mediator)
        {
            this.mediator = mediator;
        }
    }
}
