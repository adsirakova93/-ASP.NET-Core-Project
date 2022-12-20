using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static SuperDoc.Areas.Admin.AdminConstants;

namespace SuperDoc.Areas.Admin.Controllers
{
    [Area(AreaName)]
    [Authorize(Roles = AdministratorRoleName)]
    public abstract class AdminController : Controller
    {
    }
}
