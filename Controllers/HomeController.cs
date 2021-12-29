using Microsoft.AspNetCore.Mvc;



public class HomeController : Controller

{
    public readonly Connect _Connect;
    public HomeController(Connect Connect)
    {
        _Connect = Connect;
    }
    public IActionResult index()
    {
        // Products pro = new Products();
        // pro.Brand = "Mono";
        // pro.Model = "2021";
        // pro.Price = 15000000;

        // _Connect.product.Add(pro);
        // _Connect.SaveChanges();

        return View();
    }
    public IActionResult add_product(Products pro)
    {
        // Products pro = new Products();
        // pro.Brand = "Mono";
        // pro.Model = "2021";
        // pro.Price = 15000000;
        pro.Brand = pro.Brand;
        pro.Model = pro.Model;
        pro.Price = pro.Price;

        _Connect.product.Add(pro);
        _Connect.SaveChanges();
        // return RedirectToAction("index");
        return View();
    }
    public IActionResult Products()
    {
        var pro_list = _Connect.product.ToList();
        return View(pro_list);
    }
    public IActionResult Delete(int id)
    {
        var select = _Connect.product.Where(a=>a.id == id).SingleOrDefault();
        _Connect.product.Remove(select);
        _Connect.SaveChanges();
        return RedirectToAction("Products");
    }
    public IActionResult about()
    {
        return View();
    }
    public IActionResult Contact()
    {
        return View();
    }
    // public IActionResult Gallery()
    // {
    //     return View();
    // }
    public IActionResult Testimonial()
    {
        return View();
    }
}