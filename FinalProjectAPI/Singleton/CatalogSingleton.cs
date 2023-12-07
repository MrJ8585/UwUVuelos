using FinalProjectAPI.Decorator;
using FinalProjectAPI.Models;

namespace FinalProjectAPI.Singleton
{
    public class CatalogSingleton : ConcreteEntertainment
    {
        private static CatalogSingleton instance;
        private List<EntertainmentItem> Entertainments = new List<EntertainmentItem>();


        private CatalogSingleton()
        {
        }

        public static CatalogSingleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CatalogSingleton();
                }
                return instance;
            }
        }

        public void SetList(List<EntertainmentItem> list)
        {
            Entertainments = list;
            catalog = list;
        }

        public List<EntertainmentItem> GetList()
        {
            return Entertainments;
        }

        public override List<EntertainmentItem> Operation()
        {
            foreach (EntertainmentItem ent in Entertainments)
            {
                Console.WriteLine(ent.Nombre + " " + ent.China + " " + ent.Infantil);
            }
            return catalog;
        }

    }
}
