using BookLibraryRepoPetternCore;
using BookLibraryRepoPetternServicelayer.Interface;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace BookLibraryRepoPettern.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookRepository bookRepo;


        public BookController(IBookRepository bookRepo, IWebHostEnvironment webHostEnvironment)
        {
            this.bookRepo = bookRepo;
            webHostEnvironment = webHostEnvironment;
        }

        public async Task<IActionResult> Index()
        {
            var data = await this.bookRepo.GetAll();
            return View(data);
        }

        //[HttpPost]
        //public async Task <IActionResult> CreateOrEdit(int id = 0) 
        //{ 
        //    if (id == 0) 
        //    {
        //        return View(new Book());
        //    }
        //    else {
        //        try
        //        {
        //            Book book = await bookRepo.GetById(id);

        //            if (book != null)
        //            {
        //                return View(book);
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            TempData["ErrorMessage"] = ex.Message;
        //            return RedirectToAction("Index");
        //        }
        //        TempData["SuccesMessage"] = "Book Details not found with Id";
        //        return RedirectToAction("Index");
        //    }

            
        //}

        public IActionResult create()
        { 
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateOrEdit(Book model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                   

                    if (model.Id == 0)
                    {
                        await bookRepo.Add(model);

                        TempData["SuccesMessage"] = "Book Created Successfully";

                        return RedirectToAction(nameof(Index));
                    }
                    else
                    {
                        await bookRepo.Update(model);
                        TempData["SuccesMessage"] = "Book Details updated Successfully";
                        RedirectToAction(nameof(Index));

                    }

                   
                }
                else
                {
                    TempData["ErrorMessage"] = "Model State is Invalid";
                    return View();
                }
            }
            catch (Exception ex)
            {

                TempData["ErrorMessage"] = ex.Message;
            }

            
            return View();

            
        }

        [HttpGet]
        public async Task <IActionResult> Delete(int id)
        {
            Book book = await bookRepo.GetById(id);
            try
            {
                if (book != null)
                {
                    return View(book);
                }
            }
            catch (Exception ex)
            {

                TempData["ErrorMessage"] = ex.Message;
                return RedirectToAction("Index");
            }

            TempData["errorMessage"] = $"Book detail not found with Id : {id}";
            return RedirectToAction("Index");
        }
        [HttpPost, ActionName("Delete")]
        public async Task <IActionResult> DeleteConfirmed(Book id)
        {
            try
            {
                await bookRepo.Delete(id);
                TempData["SuccesMessage"] = "Book Details updated Successfully";
                RedirectToAction(nameof(Index));

    }
            catch (Exception ex)
            {


                TempData["ErrorMessage"] = ex.Message;
                return View();
            };
             return View();

           
        }
    }
}
