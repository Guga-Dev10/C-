using FilmesAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmesAPI.Controllers
{
    [ApiController] //Define a classe como sendo uma classe controladora
    [Route("controller")] //Quando a rota tiver o nome do controlador a API será chamada
    public class FilmesController : ControllerBase
    {
        List<Filme> filmes = new List<Filme>();

        public void adicionarFilmes([FromBody] Filme filme)
        {
            filmes.Add(filme);
            Console.WriteLine(filme.Titulo);
        }
    }
}
