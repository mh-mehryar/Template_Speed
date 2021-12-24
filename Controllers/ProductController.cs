using Microsoft.AspNetCore.Mvc;

public class Product : Controller
{
    public IActionResult Category()
    {
        return View();
    }
}