using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CatalogoExpress.Models;

namespace CatalogoExpress.Controllers;

public class ProductosController : Controller
{
    public IActionResult Index(){
         
        Catalogo Micatalogo=new Catalogo();
        ViewBag.Productos=Micatalogo.ObtenerProductos();

        return View();
    }

    public IActionResult Detalle(string nombre){
        //TODO 2:
            
                Catalogo Micatalogo=new Catalogo();
        ViewBag.Productos=Micatalogo.ObtenerProductoPorNombre(nombre);
        // - Si el nombre viene vacio/null o no existe -> View de no encontrado
        if(ViewBag.Productos == null)
        {
            return View("NoEncontrado");
        }
        else
        {
            return View();
        }
       

      
     }
}
