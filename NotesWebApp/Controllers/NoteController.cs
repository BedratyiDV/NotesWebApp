using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NoteContracts;
using NotesProcessor;

namespace NotesWebApp.Controllers
{
    public class NoteController : Controller
    {
        private readonly INoteProcessor _noteProcessor;

        public NoteController(INoteProcessor noteProcessor)
        {
            _noteProcessor = noteProcessor;
        }

        // GET: NoteController
        public IActionResult Index()
        {
            IEnumerable<Note> notes = _noteProcessor.GetAll();
            return View(notes);
        }
    }
}
