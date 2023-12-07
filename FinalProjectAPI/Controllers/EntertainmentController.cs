using FinalProjectAPI.Decorator;
using FinalProjectAPI.DecoratorManager;
using FinalProjectAPI.Mediator;
using FinalProjectAPI.Models;
using FinalProjectAPI.Singleton;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace FinalProjectAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class EntertainmentController : ControllerBase
    {
        static ChinaManager chinaManager = new ChinaManager();
        static InfantilManager infantilManager = new InfantilManager();
        ConcreteMediator mediator = new ConcreteMediator(chinaManager, infantilManager);
        CatalogSingleton catalogSingleton = CatalogSingleton.Instance;

        [HttpGet("Entertainment")]
        public async Task<IActionResult> getEntertainment()
        {
            List<EntertainmentItem> lista = catalogSingleton.GetList();
            return Ok(JsonConvert.SerializeObject(lista));
        }
        [HttpPost("Plugins")]
        public async Task<IActionResult> setPlugins([FromBody] PluginRequest request)
        {
            bool china = request.China;
            bool infantil = request.Infantil;

            if (china && infantil)
            {
                chinaManager.DoA();
            }
            else if (china && !infantil)
            {
                chinaManager.DoB();
            }
            else if (!china && infantil)
            {
                chinaManager.DoC();
            }
            else if (!china && !infantil)
            {
                chinaManager.DoD();
            }

            return Ok();
        }
    }

    public class PluginRequest
    {
        public bool China { get; set; }
        public bool Infantil { get; set; }
    }
}
