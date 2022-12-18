using Xunit;
using MyTested.AspNetCore.Mvc;
using TheBookClub.Controllers;
using static TheBookClub.Tests.Data.Books;
using static TheBookClub.Tests.Data.Genres;
using static TheBookClub.Tests.Data.Authors;
using TheBookClub.Models.BookViewModels;
using System.Collections.Generic;
using System.Linq;

namespace TheBookClub.Tests.ControllerTests
{
    public class BookControllerTests
    {
        [Fact]
        public void GetAddShouldViewWithCorrectModelWithData()
            => MyController<BookController>
                .Instance(c => c.WithData(TenBooks))
                .Calling(c => c.Add())
                .ShouldReturn()
                .View(v => v.WithModelOfType<AddBookFormModel>());

        [Fact]
        public void PostAddShouldTheViewWhenTheDataIsIncorect()
            => MyController<BookController>
                .Instance()
                .Calling(c => c.Add(new AddBookFormModel { }))
                .ShouldHave()
                .ActionAttributes(a => a.RestrictingForHttpMethod(HttpMethod.Post))
                .AndAlso()
                .ShouldHave()
                .InvalidModelState()
                .AndAlso()
                .ShouldReturn()
                .View(v => v.WithModelOfType<AddBookFormModel>());

        [Fact]
        public void PostAddSouldRedirectToCorrectActionWhenTheDataIsValid()
            => MyController<BookController>
                .Instance()
                .Calling(c => c.Add(new AddBookFormModel {}))
                .ShouldHave()
                .ActionAttributes(a => a.RestrictingForHttpMethod(HttpMethod.Post))
                .AndAlso()
                .ShouldHave()
                .ValidModelState()
                .AndAlso()
                .ShouldReturn()
                .RedirectToAction("Index", "Home");
    }
}
