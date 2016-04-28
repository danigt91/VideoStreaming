using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoStreaming.Infraestructure.Data.Contract;
using VideoStreaming.Infraestructure.Data.Entity;

namespace VideoStreaming.Infraestructure.Data
{
    public class VideoStreamingContext : DbContext, IContext, IDisposable
    {

        public DbSet<Usuario> Usuarios { get; set; }

    }
}
