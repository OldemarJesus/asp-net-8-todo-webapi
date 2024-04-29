
using backend.Context;
using backend.Domain;

namespace backend.Repositories
{
    public class NoteRepository : IRepository<Note>
    {
        private readonly ApplicationDbContext _context;

        public NoteRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        bool IRepository<Note>.Create(Note item)
        {
            _context.Notes.Add(item);
            return true;
        }

        bool IRepository<Note>.Delete(string id)
        {
            Note? note = _context.Notes.Where(note => note.Id.ToString() == id).ToList().FirstOrDefault(); 

            if (note != null)
            {
                _context.Notes.Remove(note);
                return true;
            }

            return false;
        }

        Note? IRepository<Note>.Get(string id)
        {
            return _context.Notes.Find(id);
        }

        IQueryable<Note> IRepository<Note>.List()
        {
            List<Note> notes = _context.Notes.ToList();
            return notes.AsQueryable();
        }

        bool IRepository<Note>.SaveChanges(Note item)
        {
            _context.Notes.Update(item);
            return true;
        }
    }
}
