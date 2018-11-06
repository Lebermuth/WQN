using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WhatQuestNext.Startup))]
namespace WhatQuestNext
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
