using System.Data;
using System.Linq;
using System.Web.Mvc;
using Dapper;
using PathFinder.Models;

namespace PathFinder.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        [HttpGet]
        public ActionResult RegisterUser()
        {
            return View("_Registration", new Account());
        }

        [HttpPost]
        public ActionResult RegisterUser(Account model)
        {
            if (!ModelState.IsValid)
            {
                Response.StatusCode = 500;
                Response.TrySkipIisCustomErrors = true;
                return View("_Registration", model);
            }

            using (var conn = DatabaseConnection.PathFinderdb)
            {
                var db = new PathFinderdbEntities();
                var p = new Person();
                p.FirstName = model.Firstname;
                p.LastName = model.Lastname;
                p.Email = model.Email;
                p.Password = model.Password;

                db.People.Add(p);
                db.SaveChanges();

                /* var d = new DynamicParameters(new
                 {
                     model.Firstname,
                     model.Lastname,
                     model.Email,
                     model.Password
                     //model.Phone
                 });
                 
                 d.Add("Id", model.Id, DbType.Int32, ParameterDirection.InputOutput);
                 conn.Execute("Register", d, commandType: CommandType.StoredProcedure);
                 model.Id = d.Get<int>("Id");*/
            }

            return new HttpStatusCodeResult(200);
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View("_Login", new Account());
        }

        [HttpPost]
        public ActionResult Login(Account model)
        {
            if (!ModelState.IsValid) return View("~/Views/Home/Index.cshtml", model);

            using (var conn = DatabaseConnection.PathFinderdb)
            {
                var personList = conn.Query<Account>("SELECT * FROM Person").ToList();
                if (personList.Any(x => x.Email == model.Email && x.Password == model.Password))
                    return View("~/Views/Home/Index.cshtml");
                ModelState.AddModelError("Username", "Username or password field is invalid...");
                return View("_Login", model);
            }
        }
    }
}