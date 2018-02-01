using UniRx;
using UnityEngine;

namespace Template.DesignPatterns.EventDriven
{

    public abstract class BaseBehavior : MonoBehaviour
    {
        /*
         * you can use those method below to catch events.
         * To inherite this class and make child class for specific use.
         */
        // ---------------
        #region UniqueLifeCycle
        protected virtual void OnEvent01(Event01 arg) { }

        protected virtual void OnEvent02(Event02 arg) { }

        protected virtual void OnEvent03(Event03 arg) { }
        // 04, 05, 06 ....
        #endregion

        private void OnEnable()
        {
            // Register receivers.
            MessageBroker.Default.Receive<Event01>().Subscribe(OnEvent01).AddTo(gameObject);
            MessageBroker.Default.Receive<Event02>().Subscribe(OnEvent02).AddTo(gameObject);
            MessageBroker.Default.Receive<Event03>().Subscribe(OnEvent03).AddTo(gameObject);
        }
    }

    /*
     * List of the classes to filter MessageBroker
     */
    // ---------------
    #region EventClass
    public class Event01
    {
        public string Msg { get; set; }
    }

    public class Event02
    {
        public string Msg { get; set; }
    }

    public class Event03
    {
        public string Msg { get; set; }
    }
    // 04, 05, 06 ....
    #endregion

}