using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zenject;
using UnityEngine.UI;
using IPA.Utilities;
using UnityEngine;
using HMUI;

namespace No_Escape.Configuration.Controllers
{
    class MenuButtonDisabler : IInitializable, IDisposable
    {

        private readonly PauseController pauseController;
        private PauseMenuManager pauseMenuManager;

        public MenuButtonDisabler(PauseController pauseController, PauseMenuManager pauseMenuManager)
        {
            this.pauseController = pauseController;
            this.pauseMenuManager = pauseMenuManager;
        }

        public void Initialize()
        {
            pauseController.didPauseEvent += PauseController_didPauseEvent;
        }

        private void PauseController_didPauseEvent()
        {
            DisableMenu();
        }

        private void DisableMenu()
        {
            // Somewhere right now PixelBoom is dying reading this. this is not good code. if you want to see Pog and Epic code for button disables look at PauseChamp :D
            Transform buttons = pauseMenuManager.transform.Find("Wrapper").transform.Find("MenuWrapper").transform.Find("Canvas").transform.Find("MainBar").transform.Find("Buttons");
            GameObject menuButton = buttons.GetChild(0).gameObject;
            menuButton.GetComponent<NoTransitionsButton>().interactable = false;


        }

        public void Dispose()
        {
            pauseController.didPauseEvent -= PauseController_didPauseEvent;
        }
    }
}
