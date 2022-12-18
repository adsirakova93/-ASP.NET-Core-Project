using Xunit;
using MyTested.AspNetCore.Mvc;
using TheBookClub.Controllers;
using TheBookClub.Models.BookModels;
using System.Collections.Generic;
using static TheBookClub.Tests.Data.Books;

namespace TheBookClub.Tests.ControllerTests
{
    public class HomeControllerTest
    {
        [Fact]
        public void IndexShouldReturnViewWithCorrectData()
        => MyController<HomeController>
            .Instance(c=> c.WithData(TenBooks))
            .Calling(c => c.Index())
            .ShouldReturn()
            .View(v=> 
                    v.WithModelOfType<List<IndexBookViewModel>>()
                    .Passing(m=> m.Count.CompareTo(3)));
    }
}
