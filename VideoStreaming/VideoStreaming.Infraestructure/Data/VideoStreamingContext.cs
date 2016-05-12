﻿using System;
using System.Data.Entity;
using VideoStreaming.Infraestructure.Data.Contract;
using VideoStreaming.Infraestructure.Data.Entity;

namespace VideoStreaming.Infraestructure.Data
{
    public class VideoStreamingContext : DbContext, IContext, IDisposable
    {

        public DbSet<Usuario> Usuarios { get; set; }

    }
}
