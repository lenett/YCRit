using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EvaWeb.Areas.library.Models;
using EvaWeb.Models;
using System.IO;
using EvaWeb.Areas.library.ViewModels;

namespace EvaWeb.Areas.library.Controllers
{
    [Area("Library")]
    public class BooksController : Controller
    {
        private ApplicationContext db;

        public BooksController(ApplicationContext context)
        {
            db = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await db.Books.ToListAsync());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(BooksModel bookModel)
        {

            Books book = new Books();
            if (bookModel.Picture != null)
            {
                byte[] imageData = null;
                // считываем переданный файл в массив байтов
                using (var binaryReader = new BinaryReader(bookModel.Picture.OpenReadStream()))
                {
                    imageData = binaryReader.ReadBytes((int)bookModel.Picture.Length);
                }
                // установка массива байтов
                book.Picture = imageData;
            }
            book.Name = bookModel.Name;
            book.Description = bookModel.Description;
            book.Author = bookModel.Author;
            book.IsActive=bookModel.IsActive;
            book.Text=bookModel.Text;  

            db.Books.Add(book);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id != null)
            {
                Books book = await db.Books.FirstOrDefaultAsync(p => p.Id == id);
                if (book != null)
                {
                    db.Books.Remove(book);
                    await db.SaveChangesAsync();
                    return RedirectToAction("Index");
                }
            }
            return NotFound();
        }

        [HttpGet]
        [ActionName("Delete")]
        public async Task<IActionResult> ConfirmDelete(int? id)
        {
            if (id != null)
            {
                Books book = await db.Books.FirstOrDefaultAsync(p => p.Id == id);
                if (book != null)
                    return View(book);
            }
            return NotFound();
        }

    }
}
