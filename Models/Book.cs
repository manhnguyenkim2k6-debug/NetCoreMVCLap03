using Microsoft.AspNetCore.Mvc.Rendering;

namespace NetCoreMVCLap03.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public int GenreId { get; set; }
        public string Image { get; set; }
        public float Price { get; set; }
        public int TotalPage { get; set; }
        public string Sumary { get; set; }
        //
        public List<Book> GetBookList()
        {
            List<Book> books = new List<Book>()
            {
                new Book()
                {
                    Id = 1,
                    Title = "Chí Phèo ",
                    AuthorId = 1,
                    GenreId = 1,
                    Image = "~/images/b1.jbg",
                    Price = 500000,
                    Sumary = "",
                    TotalPage = 250
                },
                new Book()
                {
                    Id = 2,
                    Title = "Nàng tiên cua ",
                    AuthorId = 1,
                    GenreId = 1,
                    Image = "~/images/b2.jbg",
                    Price = 300000,
                    Sumary = "",
                    TotalPage = 200
                },
                new Book()
                {
                    Id = 3,
                    Title = " Sự tích con thạch sùng ",
                    AuthorId = 1,
                    GenreId = 1,
                    Image = "~/images/b3.jbg",
                    Price = 400000,
                    Sumary = "",
                    TotalPage = 550
                },
            };
            return books;
        }
        //
        public Book GetBookById(int id)
        {
            Book book = this.GetBookList().FirstOrDefault(b => b.Id == id);
            return book;
        }
        //
        public List<SelectListItem> Authors { get; } = new List<SelectListItem>
        {
            new SelectListItem { Value = "1", Text = "Chí Phèo" },
            new SelectListItem { Value = "2", Text = "Nàng tiên cua " },
            new SelectListItem { Value = "3", Text = "Sự tích con thạch sùng" }
        };
        public List<SelectListItem> Genres { get; } = new List<SelectListItem>
        {
            new SelectListItem { Value = "1", Text = "Truyện tranh" },
            new SelectListItem { Value = "2", Text = "Truyện cổ tích" },
            new SelectListItem { Value = "3", Text = "Truyện dân gian" }
        };
    }
}