using NoteContracts;

namespace NotesProcessor
{
    public class NoteProcessor : INoteProcessor
    {
        private readonly IRepository<Note> _repository;

        public NoteProcessor(IRepository<Note> repository)
        {
            _repository = repository;
        }

        public IEnumerable<Note> GetAll()
        {
            return _repository.GetAll();
        }
    }
}