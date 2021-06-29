using BeatSaberMarkupLanguage;
using BeatSaberMarkupLanguage.Attributes;
using BeatSaberMarkupLanguage.Components;
using BeatSaberMarkupLanguage.GameplaySetup;
using BeatSaberMarkupLanguage.ViewControllers;
using No_Escape.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Zenject;

namespace No_Escape.UI
{
    internal class ModSettingsController : IInitializable, IDisposable
    {
        public void Initialize()
        {
            GameplaySetup.instance.AddTab(Assembly.GetExecutingAssembly().GetName().Name, "No_Escape.UI.Views.ModSettings.bsml", this);
        }

        [UIValue("disable-options")]
        private List<object> options = new object[] { "Menu", "Continue" }.ToList();

        [UIValue("disable-value")]
        private string currentSelectedButton
        {
            get => PluginConfig.Instance.DisableButton;
            set => PluginConfig.Instance.DisableButton = value;
        }

        public void Dispose()
        {
            GameplaySetup.instance?.RemoveTab(Assembly.GetExecutingAssembly().GetName().Name);
        }
    }
}
