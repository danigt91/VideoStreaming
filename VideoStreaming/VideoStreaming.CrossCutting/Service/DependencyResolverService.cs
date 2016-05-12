using Microsoft.Practices.Unity;
using VideoStreaming.CrossCutting.IoC;

namespace VideoStreaming.CrossCutting.Service
{
    public static class DependencyResolverService
    {

        static UnityContainer _container;

        public static void Register()
        {
            _container = new PrincipalContainer();
        }

        public static I ResolveCustomType<I>()
        {
            return _container.Resolve<I>();
        }

    }
}
