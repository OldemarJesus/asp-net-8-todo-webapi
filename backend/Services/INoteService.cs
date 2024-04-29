using backend.Domain;

namespace backend.Services
{
    public interface INoteService
    {
        List<Note> GetAllNotes();
        Note? GetNoteById(string id);
        Note? GetNoteByTitle(string title);
        bool AddNote(Note note);
        bool RemoveNote(string id);
        bool UpdateNote(Note note);
    }
}
