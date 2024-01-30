using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NoteContracts;
using Microsoft.EntityFrameworkCore;

namespace NoteDAL
{
    public class NoteRepository : IRepository<Note>
    {
        private readonly NoteDbContext _db;

        public NoteRepository()
        {
            _db = new NoteDbContext();
        }

        public IEnumerable<Note> GetAll()
        {
            return _db.Notes.ToList();
        }

    }
}
