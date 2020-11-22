using Microsoft.AspNetCore.Mvc;
using listaburguersonline.db;
using System.Linq;
using System.Collections.Generic;

namespace xxx 
{
    [ApiController]
    [Route("[controller]")]
    public class unidadeController : ControllerBase
    {
        private hamburgueriaContext _db {get; set;}
        public unidadeController(hamburgueriaContext contexto)
        {
            _db = contexto;
        }

        [HttpGet]
        public List <Unidade> Get()
        {
            var unidade = _db.Unidade
                .ToList();
            
            return unidade;
        }
    }
}