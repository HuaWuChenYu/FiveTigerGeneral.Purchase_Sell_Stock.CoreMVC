using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Purchase_Sell_Stock.MVC.Controllers;

namespace Purchase_Sell_Stock.MVC
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
            services.AddSession();//����Session
            //���ÿ���������������Դ��
            services.AddCors(options =>
            {
                options.AddPolicy("any", builder =>
                {
                    builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod()   //����дAllowAnyHeader����ǰ�˵����� 
                    //.AllowCredentials()//ָ������cookie
                .AllowAnyOrigin(); //�����κ���Դ����������
                });
            });
            CustomerController.httpPart = Configuration["ConnectionStrings:httpPart"];
            FirstController.httpPart = Configuration["ConnectionStrings:httpPart"];
            GoodsController.httpPart = Configuration["ConnectionStrings:httpPart"];
            HomeController.httpPart = Configuration["ConnectionStrings:httpPart"];
            LoginController.httpPart = Configuration["ConnectionStrings:httpPart"];
            ModelController.httpPart = Configuration["ConnectionStrings:httpPart"];
            OrderController.httpPart = Configuration["ConnectionStrings:httpPart"];
            ProcurementController.httpPart = Configuration["ConnectionStrings:httpPart"];
            SettingController.httpPart = Configuration["ConnectionStrings:httpPart"];
            StroageController.httpPart = Configuration["ConnectionStrings:httpPart"];
            services.AddControllersWithViews();
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
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();
            app.UseCors("any");//��������
            app.UseRouting();
            app.UseSession();//����Session
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
