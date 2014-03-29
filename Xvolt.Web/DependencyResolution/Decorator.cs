using StructureMap.Interceptors;
using StructureMap.Pipeline;

namespace Xvolt.Web.DependencyResolution
{
    public static class StructureMapDecoratorHelperExtension
    {
        public static DecoratorHelper<TTarget> Decorate<TTarget>(this SmartInstance<TTarget> instance)
        {
            return new DecoratorHelper<TTarget>(instance);
        }
    }

    public class DecoratorHelper<TTarget>
    {
        private readonly SmartInstance<TTarget> _instance;

        public DecoratorHelper(SmartInstance<TTarget> instance)
        {
            _instance = instance;
        }

        public DecoratedInstance<TTarget> With<TDecorator>()
        {
            ContextEnrichmentHandler<TTarget> decorator = (ctx, t) =>
            {
                var pluginType = ctx.BuildStack.Current.RequestedType;

                ctx.RegisterDefault(pluginType, t);

                return ctx.GetInstance<TDecorator>();
            };

            _instance.EnrichWith(decorator);

            return new DecoratedInstance<TTarget>(_instance, decorator);
        }
    }

    public class DecoratedInstance<TTarget>
    {
        private readonly SmartInstance<TTarget> _instance;
        private ContextEnrichmentHandler<TTarget> _decorator;

        public DecoratedInstance(SmartInstance<TTarget> instance, ContextEnrichmentHandler<TTarget> decorator)
        {
            _instance = instance;
            _decorator = decorator;
        }

        public DecoratedInstance<TTarget> AndThen<TDecorator>()
        {
            //Must be captured as a local variable, otherwise the closure's decorator will
            //always be the outer-most decorator, causing a Stack Overflow.
            var previousDecorator = _decorator;

            ContextEnrichmentHandler<TTarget> newDecorator = (ctx, t) =>
            {
                var pluginType = ctx.BuildStack.Current.RequestedType;

                var innerInstance = previousDecorator(ctx, t);

                ctx.RegisterDefault(pluginType, innerInstance);

                return ctx.GetInstance<TDecorator>();
            };

            _instance.EnrichWith(newDecorator);

            _decorator = newDecorator;

            return this;
        }
    }
}