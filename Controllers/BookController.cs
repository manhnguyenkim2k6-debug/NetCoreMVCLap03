using Microsoft.AspNetCore.Mvc;
using NetCoreMVCLap03.Models;
namespace NetCoreMVCLab03.Controllers
{
    public class BookController : Controller
    {
        protected Book book = new Book();
        public IActionResult Index(int? AuthorId, int? GenreId)
        {
            ViewBag.authors = book.Authors;
            ViewBag.genres = book.Genres;

            var books = book.GetBookList();

            // Lọc theo Tác giả nếu có chọn
            if (AuthorId.HasValue && AuthorId.Value > 0)
            {
                books = books.Where(b => b.AuthorId == AuthorId.Value).ToList();
            }

            // Lọc theo Thể loại nếu có chọn
            if (GenreId.HasValue && GenreId.Value > 0)
            {
                books = books.Where(b => b.GenreId == GenreId.Value).ToList();
            }

            return View(books);
        }

        public IActionResult Create()
        {
            ViewBag.authors = book.Authors;
            ViewBag.genres = book.Genres;
            Book model = new Book();
            return View(model);
        }

        public IActionResult Edit(int id)
        {
            ViewBag.authors = book.Authors;
            ViewBag.genres = book.Genres;

            Book model = book.GetBookById(id);

            if (model == null)
            {
                return NotFound();
            }

            return View(model);
        }
        public PartialViewResult PopularBook()
        {
            var books = book.GetBookList();
            return PartialView(books);
        }
    }
}
