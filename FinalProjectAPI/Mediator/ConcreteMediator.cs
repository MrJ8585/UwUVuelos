using FinalProjectAPI.Decorator;
using FinalProjectAPI.DecoratorManager;

namespace FinalProjectAPI.Mediator
{
    public class ConcreteMediator : IMediator
    {
        private ChinaManager china;
        private InfantilManager infantil;

        public ConcreteMediator(ChinaManager china, InfantilManager infantil)
        {
            this.china = china;
            this.china.SetMediator(this);
            this.infantil = infantil;
            this.infantil.SetMediator(this);
        }

        public void Notify(object sender, string command)
        {
            if (command == "A") this.infantil.DoE();
            if (command == "B") this.infantil.DoF();
            if (command == "C") this.infantil.DoG();
            if (command == "D") this.infantil.DoH();
            
        }
    }
}
