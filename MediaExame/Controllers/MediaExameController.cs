namespace MediaExame.Controllers;
using MediaExame.Models;
using Microsoft.AspNetCore.Mvc; 
public class MediaExameController : Controller
{
    public IActionResult Index() => View(new MediaExameModel());

    public IActionResult MediaCalcular(MediaExameModel model){

        if(ModelState.IsValid){
            
            var resultado = (model.intermediaria * 0.35 + model.semestral * 0.35 + model.trabalho * 0.3 );
            if(resultado >= 6.51){
                TempData["resultado"] = $"Passou {resultado}";
                return RedirectToAction("Index");
            }else {
                TempData["resultado"] = $"Reprovou {resultado}";
                return RedirectToAction("Index");
            }
        }

        return View("Index", model);
    }
    
}