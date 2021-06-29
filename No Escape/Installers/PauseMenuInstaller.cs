using No_Escape.Configuration.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zenject;

namespace No_Escape.Installers
{
    class PauseMenuInstaller : Installer
    {
        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<MenuButtonDisabler>().AsSingle();
        }
    }
}
