using System.Security.Claims;
using static BeautyZone.Areas.Admin.AdminConstants;

namespace BeautyZone.Infrastructure
{
    public static class ClaimsPrincipalExtensions
    {
        public static string GetId(this ClaimsPrincipal user)
            => user.FindFirst(ClaimTypes.NameIdentifier).Value;

        public static bool IsAdmin(this ClaimsPrincipal user)
            => user.IsInRole(AdministratorRoleName);

        public static bool IsPhysician(this ClaimsPrincipal user)
            => user.IsInRole(WebConstants.PhysicianRoleName);

        public static bool IsPatient(this ClaimsPrincipal user)
            => user.IsInRole(WebConstants.PatientRoleName);
    }
}
