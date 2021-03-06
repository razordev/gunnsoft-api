﻿namespace Autofac
{
    public static class VersioningExtensions
    {
        public static TService ResolveVersioned<TService>
        (
            this IComponentContext extended,
            int version
        )
        {
            var service = default(TService);

            while (version > 0 && service == null)
            {
                service = extended.ResolveKeyed<TService>(version);

                version--;
            }

            return service;
        }
    }
}