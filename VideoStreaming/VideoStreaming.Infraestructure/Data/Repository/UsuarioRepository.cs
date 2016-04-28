using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoStreaming.Infraestructure.Data.Contract;
using VideoStreaming.Infraestructure.Data.Entity;
using VideoStreaming.Infraestructure.Data.Repository.Contract;
using VideoStreaming.Infraestructure.Data.Repository.Implementation;

namespace VideoStreaming.Infraestructure.Data.Repository
{
    public class UsuarioRepository : DataRepository<Usuario>
    {

        public UsuarioRepository(IUnitOfWork<IContext> _context) : base(_context)
        {
            
        }

    }
}
