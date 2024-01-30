using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteContracts
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        
    }
}
