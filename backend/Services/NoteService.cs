using backend.Domain;
using backend.Repositories;

namespace backend.Services
{
    public class NoteService : INoteService
    {
        private readonly IRepository<Note> _repository;

        public NoteService(IRepository<Note> repository)
        {
            _repository = repository;
        }

        bool INoteService.AddNote(Note note)
        {
            return _repository.Create(note);
        }

        List<Note> INoteService.GetAllNotes()
        {
            return _repository.List().ToList();
        }

        Note? INoteService.GetNoteById(string id)
        {
            return _repository.Get(id);
        }

        Note? INoteService.GetNoteByTitle(string title)
        {
            Note? note = _repository.List().Where(note => note.Title == title).FirstOrDefault();
            return note; 
        }

        bool INoteService.RemoveNote(string id)
        {
            return _repository.Delete(id);
        }

        bool INoteService.UpdateNote(Note note)
        {
            return _repository.SaveChanges(note);
        }
    }
}
