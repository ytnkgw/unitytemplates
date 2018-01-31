using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

namespace Template.DesignPatterns.EventDriven
{

    public class BaseTrigger : MonoBehaviour
    {

        private void OnEvent01Trigger ()
        {
            MessageBroker.Default.Publish<Event01>(new Event01 { Msg = "Event01 triggered" }); // event trigger
        }

        private void OnEvent02Trigger()
        {
            MessageBroker.Default.Publish<Event02>(new Event02 { Msg = "Event01 triggered" });
        }

        private void OnEvent03Trigger()
        {
            MessageBroker.Default.Publish<Event03>(new Event03 { Msg = "Event01 triggered" });
        }

    }

}