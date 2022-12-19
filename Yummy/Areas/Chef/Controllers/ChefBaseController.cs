using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Yummy.Areas.Chef.Controllers
{
    [Area("Chef")]
    [Authorize(Roles = "Chef")]
    public class ChefBaseController : Controller
    {
       
    }
}
