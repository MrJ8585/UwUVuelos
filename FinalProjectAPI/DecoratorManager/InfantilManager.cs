using FinalProjectAPI.Decorator;
using FinalProjectAPI.Mediator;
using FinalProjectAPI.Singleton;

namespace FinalProjectAPI.DecoratorManager
{
    public class InfantilManager : BaseComponent
    {
        static CatalogSingleton catalogSingleton = CatalogSingleton.Instance;
        public void DoE()
        {
            var lista = new InfantDecorator(catalogSingleton);
            catalogSingleton.SetList(lista.Operation());
            _mediator.Notify(null, "E");
        }
        public void DoF()
        {
            _mediator.Notify(null, "F");
        }
        public void DoG()
        {
            var lista = new InfantDecorator(catalogSingleton);
            catalogSingleton.SetList(lista.Operation());
            _mediator.Notify(null, "G");
        }
        public void DoH()
        {
            _mediator.Notify(null, "H");
        }
    }
}
