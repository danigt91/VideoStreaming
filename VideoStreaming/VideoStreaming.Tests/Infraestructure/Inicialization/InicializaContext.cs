using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoStreaming.Infraestructure.Data;
using VideoStreaming.Infraestructure.Data.Entity;

namespace VideoStreaming.Tests.Infraestructure.Inicialization
{
    [TestClass]
    public class InicializaContext
    {

        [TestMethod]
        public void CrearDBContext()
        {
            using (var db = new VideoStreamingContext())
            {
                var usuario = new Usuario()
                {
                    UserName = "danigt91",
                    Password = "12345",
                    ConfirmPassword = "12345"
                };
                db.Usuarios.Add(usuario);
                db.SaveChanges();
            }
        }

    }
}
