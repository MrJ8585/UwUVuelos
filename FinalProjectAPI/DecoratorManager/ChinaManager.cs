using FinalProjectAPI.Decorator;
using FinalProjectAPI.Mediator;
using FinalProjectAPI.Models;
using FinalProjectAPI.Singleton;

namespace FinalProjectAPI.DecoratorManager
{
    public class ChinaManager : BaseComponent
    {
        static CatalogSingleton catalogSingleton = CatalogSingleton.Instance;
        public void DoA()
        {
            var lista = new ChinaDecorator(catalogSingleton);
            catalogSingleton.SetList(lista.Operation());
            _mediator.Notify(null, "A");
        }
        public void DoB()
        {
            var lista = new ChinaDecorator(catalogSingleton);
            catalogSingleton.SetList(lista.Operation());
            _mediator.Notify(null, "B");
        }
        public void DoC()
        {
            _mediator.Notify(null, "C");
        }
        public void DoD()
        {
            _mediator.Notify(null, "D");
        }
    }
}
