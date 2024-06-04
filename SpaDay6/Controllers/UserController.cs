using System.ComponentModel;
using Microsoft.AspNetCore.Mvc;

namespace SpaDay6;
[Route("/user")]
public class UserController : Controller
{

[HttpGet]
[Route("add")]
public IActionResult AddUser()
{
return View("Add");
}

[HttpPost("/user")]
   public IActionResult SubmitAddUserForm(User newUser, string verify)
   {

    if(newUser.Password != verify)
    {
    ViewBag.Error = "Passwords don't match.";
    ViewBag.User = newUser;
    return View("Add");
    }
    ViewBag.Username = newUser.Username;
    ViewBag.Email = newUser.Email;
    return View("Index");
    
   }
}
