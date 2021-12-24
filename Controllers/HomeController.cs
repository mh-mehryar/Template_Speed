using Microsoft.AspNetCore.Mvc;



public class HomeController : Controller

{
    public IActionResult index()
    {
        return View();
    }
    public IActionResult about()
    {
        return View();
    }
    public IActionResult Contact()
    {
        return View();
    }
    public IActionResult Gallery()
    {
        return View();
    }
    public IActionResult Testimonial()
    {
        return View();
    }
}