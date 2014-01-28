using System.Web.Mvc;
using StructureMap;
using Xvolt.Web.DependencyResolution;

namespace Xvolt.Web.App_Start
{
    public static class IoC
    {
        public static IContainer Initialize()
        {
            ControllerBuilder.Current.SetControllerFactory(new StructureMapControllerFactory());

            ObjectFactory.Initialize(x =>
            {
                x.Scan(y =>
                {
                    y.TheCallingAssembly();
                    y.AssembliesFromApplicationBaseDirectory();
                    y.WithDefaultConventions();
                });

            });

            return ObjectFactory.Container;
        }
    }
}