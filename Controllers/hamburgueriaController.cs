using Microsoft.AspNetCore.Mvc;
using listaburguersonline.db;
using System.Linq;
using System.Collections.Generic;

namespace listaburguersonline.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class hamburgueriaController : ControllerBase
    {
        private hamburgueriaContext _db { get; set; }
        public hamburgueriaController(hamburgueriaContext contexto)
        {
            _db = contexto;
        }
        
        [HttpGet]
        public List<Burguer> Get()
        {
            var retorno = _db.Burguer
                .OrderByDescending(hb => hb.Preco)
                .ThenBy(hb => hb.Nome)   
                .ToList(); 

            return retorno;
        }
    }
}