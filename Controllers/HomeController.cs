using Microsoft.AspNetCore.Mvc;

namespace TPBase.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        ViewBag.ListSeries = BD.ListaSeries();
        return View();
    }
     public List<Actor> VerActores(int idSerie)
    {
        return BD.ListaActores(idSerie);
    } 
     public List<Temporada> VerTemporadas(int idSerie)
    {
        return BD.ListaTemporadas(idSerie);
    }
     public Serie VerMasInfo(int idSerie)
    {
        return BD.TraerUnaSerie(idSerie);
    }
}
