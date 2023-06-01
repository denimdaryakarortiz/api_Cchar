using api_app_2.Data;
using api_app_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace api_app_2.Controllers
{
    public class UsuarioController : ApiController
    {
        // GET api/<controller>
        public List<Usuario> Get()
        {
            return UsuarioData.Listar();
        }
        //// GET api/<controller>/5
        public List<Usuario> Get(string idu)
        {
            return UsuarioData.Obtener(idu: idu);
        }


        // POST api/<controller>
        public bool Post([FromBody] Usuario oUsuario)
        {
            return UsuarioData.registrarUsuario(oUsuario);
        }

        // PUT api/<controller>/5
        public bool Put([FromBody] Usuario oUsuario)
        {
            return UsuarioData.actualizarUsuario(oUsuario);
        }

        // DELETE api/<controller>/5
        public bool Delete(string idu)
        {
            return true;
        }
    }
}