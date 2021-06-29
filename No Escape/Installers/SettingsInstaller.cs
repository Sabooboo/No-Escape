using No_Escape.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zenject;

namespace No_Escape.Installers
{
    class SettingsInstaller : Installer
    {
        public override void InstallBindings()
        {
            Container.BindInterfacesTo<ModSettingsController>().AsSingle();
        }
    }
}
