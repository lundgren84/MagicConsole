using MagicConsole.features.Authentication.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace MagicConsole.features.Authentication
{
    public class AuthenticationController : Controller
    {
        private UserManager<IdentityUser> userManager;
        private readonly RoleManager<IdentityRole> roleManager;
        public AuthenticationController()
        {
            var context = new IdentityDatabaseContext();
            var store = new UserStore<IdentityUser>(context);
            userManager = new UserManager<IdentityUser>(store);
            roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
        }

        // GET: Authentication
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Login(LoginFormModel model)
        {
            var formModel = new LoginFormModel
            {
                Username = model.Username
            };

            if (!ModelState.IsValid)
            {
                return View(formModel);
            }

            var user = await userManager.FindAsync(model.Username, model.Password);
            if (user == null)
            {
                ModelState.AddModelError(string.Empty, "Wrong e-mail or password");
                return View(formModel);
            }

            var identity = await userManager.CreateIdentityAsync(user,
                DefaultAuthenticationTypes.ApplicationCookie);
            var authorisationManager = HttpContext.GetOwinContext().Authentication;
            authorisationManager.SignIn(identity);

            return RedirectToAction("Index", "Home", null);
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Register(RegisterFormModel model)
        {
            var formModel = new RegisterFormModel
            {
                Username = model.Username,
                RememberMe = model.RememberMe
            };

            if (!ModelState.IsValid)
            {    
                return View(formModel);
            }

            var user = new IdentityUser
            {
                UserName = model.Username,
                Email = model.Username,
            };
            var result = await userManager.CreateAsync(user, model.Password);

            if (result.Succeeded)
            {
                var identity = await userManager.CreateIdentityAsync(user,
                    DefaultAuthenticationTypes.ApplicationCookie);

                var authorisationManager =
                    HttpContext.GetOwinContext().Authentication;
                //Sign in
                authorisationManager.SignIn(identity);

                return RedirectToAction("Index", "Home", null);
            }

            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error);
            }

            return View(formModel);
        }

        public ActionResult ForgotPassword()
        {
            return View();
        }

        public ActionResult Logout()
        {
            var authorisationManager = HttpContext.GetOwinContext().Authentication;
            authorisationManager.SignOut(DefaultAuthenticationTypes.ApplicationCookie);

            return RedirectToAction("Index", "Home", null);
        }
    }
}