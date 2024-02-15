using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EventoController : ControllerBase
{
    public EventoController()
    {
        
    }

    [HttpGet]
    public IEnumerable<Evento> Get()
    {
       return new Evento[] {
        new Evento(){
            EventoId = 1,
            Tema = "Angular 11",
            Lote = "1° Lote",
            QtdPessoas = 250,
            Local = "Aqui",
            DataEvento = DateTime.Now.AddDays(2).ToString(),
            ImagemURL = "foto.png"
        },
         new Evento(){
            EventoId = 2,
            Tema = "Angular 11",
            Lote = "1° Lote",
            QtdPessoas = 250,
            Local = "Aqui",
            DataEvento = DateTime.Now.AddDays(2).ToString(),
            ImagemURL = "foto.png"
        }
       };
    }

    [HttpPost]
    public string Post()
    {
       return "post value";
    }
}
