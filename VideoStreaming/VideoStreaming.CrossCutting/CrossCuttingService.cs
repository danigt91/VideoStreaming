using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoStreaming.CrossCutting.IoC;

namespace VideoStreaming.CrossCutting
{
    public static class CrossCuttingService
    {

        static UnityContainer _container;

        public static void UnityInject()
        {
            _container = new PrincipalContainer();
        }

        public static I ResolveCustomType<I>()
        {
            return _container.Resolve<I>();
        }

    }
}
