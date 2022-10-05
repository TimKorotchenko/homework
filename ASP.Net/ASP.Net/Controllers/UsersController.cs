using ASP.Net.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;

namespace ASP.Net.Controllers
{
    public class UsersController : Controller
    {
        // GET: Users
        public ActionResult Index()
        {
            // #1. Вичитали данные из файла в память
            var piple = new List<UserInfo>();

            
            using (StreamReader file = System.IO.File.OpenText(@"c:\user.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                piple = (List<UserInfo>)serializer.Deserialize(file, typeof(List<UserInfo>));
            }

            // #2. Полученные данные отдали во вью(с именем Индекс) для отрисовки
            return View(piple);

        }

        // Отрисовали разметку для ввода данных
        public ActionResult register()
        {
           
            return View();
        }

        [HttpPost]
        // Считали введенные данные через форму и обновили файл и перенаправили на Экшен отображения всех данных из файла
        public ActionResult Register(UserInfo model)
        {
            // #1. Вичитали данные из файла в память
            var people = new List<UserInfo>();
            var serializer = new JsonSerializer();
            using (StreamReader file = System.IO.File.OpenText(@"c:\user.json"))
            {
                
                people = (List<UserInfo>)serializer.Deserialize(file, typeof(List<UserInfo>));
            }

            // #2. Добавили данные введенные пользователем в нашу коллекцию в памяти из шага #1
            people.Add(model);
           
            // #3. Обновленную коллекцию из шага 2 сохранили в файл 
            using (var sw = new StreamWriter(@"c:\user.json"))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, people);
            }
            // #4. Перенаправление на Экшен Индекс Юзерс контороллера для отрисовки файла
            return RedirectToAction("Index");
        }
    }

}