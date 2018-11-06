using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(comic_book_gallery.Startup))]
namespace comic_book_gallery
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
