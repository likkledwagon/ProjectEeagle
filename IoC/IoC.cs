using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;

namespace IoC
{
    public class IoC
    {
        private static readonly UnityContainer Container = new UnityContainer();

        public static T Resolve<T>()
        {
            return Container.Resolve<T>();
        }

        public static void Register<T, TU>() where TU : T
        {
            Container.RegisterType<T, TU>();
        }
    }
}
