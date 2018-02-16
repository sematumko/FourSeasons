using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FourSeasons.Models;

namespace FourSeasons.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<News> list = new List<News>();

            list.Add(new News { Date = DateTime.Now, Header = "Очередное золото Дениса Спицова", Content = "Поздравляю с бронзовой медалью нашего земляка Дениса Спицова! Он занял третье место в лыжной гонке на 15 километров на Олимпийских играх в Пхёнчхане, уступив норвежцу и швейцарцу. Уверен, что в следующих соревнованиях он также покажет отличные результаты. Вологодчина и страна гордится им.", ImgLink = "~/images/news/banner1.jpg" });
            list.Add(new News { Date = DateTime.Today, Header = "В работе \"ВКонтакте\" произошел сбой", Content = "При попытке загрузить сайт отображалось сообщение \"К сожалению, сервер временно недоступен. Попробуйте повторить действие чуть позже\". Мобильное приложение \"ВКонтакте\" также было недоступно.При этом некоторым пользователям удавалось зайти на свою страницу. В компании подтвердили наличие проблем.Отмечается, что сбой произошел из - за серьезной аварии в энергосистеме одного из дата - центров.", ImgLink = "~/images/news/banner2.jpg" });
            

            return View(list);
        }

        public IActionResult NewsArchive()
        {
            List<News> list = new List<News>();

            list.Add(new News { Date = DateTime.Now, Header = "Очередное золото Дениса Спицова", Content = "Поздравляю с бронзовой медалью нашего земляка Дениса Спицова! Он занял третье место в лыжной гонке на 15 километров на Олимпийских играх в Пхёнчхане, уступив норвежцу и швейцарцу. Уверен, что в следующих соревнованиях он также покажет отличные результаты. Вологодчина и страна гордится им.", ImgLink = "~/images/news/banner1.jpg" });
            list.Add(new News { Date = DateTime.Today, Header = "В работе \"ВКонтакте\" произошел сбой", Content = "При попытке загрузить сайт отображалось сообщение \"К сожалению, сервер временно недоступен. Попробуйте повторить действие чуть позже\". Мобильное приложение \"ВКонтакте\" также было недоступно.При этом некоторым пользователям удавалось зайти на свою страницу. В компании подтвердили наличие проблем.Отмечается, что сбой произошел из - за серьезной аварии в энергосистеме одного из дата - центров.", ImgLink = "~/images/news/banner2.jpg" });
            list.Add(new News { Date = DateTime.Now, Header = "News 3", Content = "What a great content 3", ImgLink = "~/images/news/banner3.jpg" });
            list.Add(new News { Date = DateTime.Today, Header = "News 4", Content = "What a great content 4", ImgLink = "~/images/news/banner4.jpg" });


            return View(list);
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
