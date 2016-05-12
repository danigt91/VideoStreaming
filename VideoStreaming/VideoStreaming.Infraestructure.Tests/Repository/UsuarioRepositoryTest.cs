using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using VideoStreaming.CrossCutting;
using VideoStreaming.Infraestructure.Data.Entity;
using VideoStreaming.Infraestructure.Data.Repository.Contract;
using System.Diagnostics;
using System.Data.Entity.Validation;
using System.Data.Entity.Infrastructure;
using VideoStreaming.Infraestructure.Service.Implementation;

namespace VideoStreaming.Infraestructure.Tests.Repository
{

    [TestClass]
    public class UsuarioRepositoryTest
    {

        private static IDataRepository<Usuario> _usuario;
        

        [AssemblyInitialize]
        public static void InjectMocks(TestContext context)
        {
            CrossCuttingService.UnityInject();
            _usuario = CrossCuttingService.ResolveCustomType<IDataRepository<Usuario>>();
        }

        [TestMethod]
        public void InjectionIsOK()
        {
            var x = _usuario.All().Count();
            Trace.WriteLine("Inyeccion de dependencias ok");
        }


        [TestMethod]
        public void AutoMapperEF6IsOK()
        {
            var x = _usuario.All();
            var auto = new AutoMapperEF6<Usuario, UsuarioDTOTest>();
            var xMap = auto.Map(x);

            Trace.WriteLine("Inyeccion de dependencias ok");
        }

        [TestMethod]
        public void CreateUserTest()
        {
            var nuevoUsuario = new Usuario()
            {
                UserName = "danigt91",
                Password = "QWERTY",
                ConfirmPassword = "QWERTY"
            };
            nuevoUsuario = _usuario.Create(nuevoUsuario);

            Trace.WriteLine("Usuario ID: " + nuevoUsuario.ID);

            Trace.WriteLine("Inyeccion de dependencias ok");
        }

        [TestMethod]
        [ExpectedException(typeof(DbEntityValidationException))]
        public void CreateUserFailPasswordTest()
        {
            var nuevoUsuario = new Usuario()
            {
                UserName = "danigt91",
                Password = "QWERTY",
                ConfirmPassword = "OTRA"
            };

            try
            {
                nuevoUsuario = _usuario.Create(nuevoUsuario);
            }
            catch (DbEntityValidationException e)
            {
                Trace.WriteLine(e.Message);

                foreach (var validationError in e.EntityValidationErrors)
                {
                    Trace.WriteLine(string.Join(", ", validationError.ValidationErrors.Select(x => "[" + x.PropertyName + "]: " + x.ErrorMessage)));
                }
                throw;
            }

            Trace.WriteLine("Usuario ID: " + nuevoUsuario.ID);

            Trace.WriteLine("Inyeccion de dependencias ok");
        }


        [TestMethod]
        [ExpectedException(typeof(DbUpdateException))]
        public void CreateUserUserNameFailTest()
        {
            var nuevoUsuario = new Usuario()
            {
                UserName = "danigt91",
                Password = "QWERTY",
                ConfirmPassword = "QWERTY"
            };

            try
            {
                nuevoUsuario = _usuario.Create(nuevoUsuario);
            }
            catch (DbUpdateException e)
            {
                Exception eDeep = e;
                Trace.WriteLine(eDeep.Message);
                while (eDeep.InnerException != null)
                {
                    eDeep = eDeep.InnerException;
                    Trace.WriteLine(eDeep.Message);
                }

                throw;
            }

            Trace.WriteLine("Usuario ID: " + nuevoUsuario.ID);

            Trace.WriteLine("Inyeccion de dependencias ok");
        }
    }
}
