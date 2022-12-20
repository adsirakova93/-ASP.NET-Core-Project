using SuperDoc.Models.Physicians.Enums;
using SuperDoc.Services.Physicians.Models;
using System.Collections.Generic;

namespace SuperDoc.Areas.Admin.Models.Physicians
{
    public class AllPhysiciansAdminQueryModel
    {
        public const int PhysiciansPerPage = 2;

        public int CurrentPage { get; init; } = 1;

        public bool Approved { get; set; }

        public PhysicianSorting Sorting { get; init; }

        public IEnumerable<PhysicianServiceModel> Physicians { get; set; }

        public int TotalPhysicians { get; set; }
    }
}
