using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using sample_app_razorpages.Resolvers;
using sample_app_razorpages.Models;
using Kontent.Ai.Delivery.Abstractions;
using Kontent.Ai.Delivery.Extensions;

namespace sample_app_razorpages
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services
                .AddSingleton<IContentLinkUrlResolver, CustomContentLinkUrlResolver>()
                .AddDeliveryInlineContentItemsResolver<Tweet, TweetResolver>()
                .AddDeliveryInlineContentItemsResolver<HostedVideo, HostedVideoResolver>()
                .AddSingleton<ITypeProvider, CustomTypeProvider>()
                .AddDeliveryClient(Configuration);                            
                
            services.AddRazorPages()
                .AddRazorPagesOptions(options =>
                {
                    options.Conventions.AddPageRoute("/Home/Index", "");
                });
    }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }

            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }
}
