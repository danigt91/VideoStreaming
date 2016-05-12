using Microsoft.Practices.Unity;
using VideoStreaming.Infraestructure.Data;
using VideoStreaming.Infraestructure.Data.Contract;
using VideoStreaming.Infraestructure.Data.Entity;
using VideoStreaming.Infraestructure.Data.Entity.Contract;
using VideoStreaming.Infraestructure.Data.Repository;
using VideoStreaming.Infraestructure.Data.Repository.Contract;
using VideoStreaming.Infraestructure.Data.Repository.Implementation;

namespace VideoStreaming.CrossCutting.IoC
{
    class PrincipalContainer : UnityContainer
    {

        public PrincipalContainer() : base()
        {

            InfraestructureInjection();

        }

        private void InfraestructureInjection()
        {
            /* Arquitectura */
            this.RegisterType<IContext, VideoStreamingContext>();
            this.RegisterType<IUnitOfWork<IContext>, UnitOfWork>();

            /* Repositorio de entidades */
            this.RegisterType(typeof(IDataRepository<>), typeof(DataRepository<>));
        }

    }
}
