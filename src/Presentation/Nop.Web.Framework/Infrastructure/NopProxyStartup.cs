using System;
using System.Linq;
using System.Net;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Nop.Core.Configuration;
using Nop.Core.Infrastructure;

namespace Nop.Web.Framework.Infrastructure
{
    /// <summary>
    /// Represents object for the configuring services on application startup
    /// </summary>
    public class NopProxyStartup : INopStartup
    {
        /// <summary>
        /// Add and configure any of the middleware
        /// </summary>
        /// <param name="services">Collection of service descriptors</param>
        /// <param name="configuration">Configuration of the application</param>
        public void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {

        }

        /// <summary>
        /// Configure the using of added middleware
        /// </summary>
        /// <param name="application">Builder for configuring an application's request pipeline</param>
        public void Configure(IApplicationBuilder application)
        {
            var appSettings = EngineContext.Current.Resolve<AppSettings>();

            if (appSettings.HostingConfig.UseProxy)
            {
                var options = new ForwardedHeadersOptions
                {
                    ForwardedHeaders = ForwardedHeaders.All,
                    ForwardLimit = 2
                };

                if (!string.IsNullOrEmpty(appSettings.HostingConfig.ForwardedForHeaderName))
                        options.ForwardedForHeaderName = appSettings.HostingConfig.ForwardedForHeaderName;

                if (!string.IsNullOrEmpty(appSettings.HostingConfig.ForwardedProtoHeaderName))
                    options.ForwardedProtoHeaderName = appSettings.HostingConfig.ForwardedProtoHeaderName;

                if(!string.IsNullOrEmpty(appSettings.HostingConfig.KnownProxies))
                {
                    var proxyIps = appSettings.HostingConfig.KnownProxies.Split(',', StringSplitOptions.RemoveEmptyEntries).ToList();
                    foreach (var strIp in proxyIps)
                    {
                        if (IPAddress.TryParse(strIp, out var ip))
                            options.KnownProxies.Add(ip);
                    }

                    if(options.KnownProxies.Count > 1)
                        options.ForwardLimit = null; //disable the limit, because KnownProxies is configured
                }

                //configure forwarding
                application.UseForwardedHeaders(options);
            }
        }

        /// <summary>
        /// Gets order of this startup configuration implementation
        /// </summary>
        public int Order => -1; // Routing should be loaded before calling other middleware
    }
}