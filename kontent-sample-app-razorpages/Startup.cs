using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using kontent_sample_app_razorpages.Resolvers;
using Kentico.Kontent.Delivery;
using Kentico.Kontent.Delivery.InlineContentItems;
using KenticoKontentModels;

namespace kontent_sample_app_razorpages
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
                .AddDeliveryClient(Configuration)                            
                .AddMvc()
                    .SetCompatibilityVersion(CompatibilityVersion.Version_2_2)
                    .AddRazorPagesOptions(options =>
                {
                    options.Conventions.AddPageRoute("/Home/Index", "");
                });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
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

            app.UseMvc();
        }
    }
}
