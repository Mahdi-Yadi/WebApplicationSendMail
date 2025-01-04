using Microsoft.AspNetCore.Mvc;
namespace WebApplication1.Controllers;
public class HomeController : Controller
{

    public IActionResult Index()
    {

        return View();
    }

    [HttpPost]
    public IActionResult SendEmail(string email, string subject, string text)
    {

        var res = MailServices.MailSender.SendMail(email, subject, text);

        if (res == true)
        {
            ViewBag.result = "ایمیل ارسال شد";
            return Redirect("/");
        }
        else
        {
            ViewBag.result = "ایمیل ارسال نشد";
            return Redirect("/");
        }
    }

}