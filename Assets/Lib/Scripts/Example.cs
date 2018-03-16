/*
 * This example script is showing coding style in this project.
 * TIPS : this is the description why you write the code like below.
 * Unity source code : https://bitbucket.org/Unity-Technologies/
 */

using UnityEngine;

namespace MyLib
{
    public class Example : MonoBehaviour
    {
        /*
         * TIPS : Use "static readonly" to constant value.
         * TIPS : Use capital letters for constant value.
         */
        private static readonly int MAX_INT = 10;

        /*
         * TIPS : List from public valiables and methods.
         * 1. Enable reader to see the core functional things. And make it faster to understand what this script is doing.
         * 
         * [Obsolete]
         * TIPS : Order of listing valiables declaration.
         * delegate > constant > member valiables
         * 1. list from the things you don't use so much. 
         * > maybe this is not true cause future coder will read through from 
         *   the things isn't used so much, which means non-core things.
         */
        public delegate void ExampleEvent();
        public ExampleEvent onStart;
        public ExampleEvent onEnd;

        /*
         * TIPS : User upper camel case for enum.
         */
        private enum ExampleState : int
        {
            None = -1,
            Waiting = 0,
            Playing = 1,
            End = 2
        }

        /*
         * TIPS : Use Lower Camel Case.
         * 1. make difference clearer between properties and methods
         */
        public int sampleInt
        {
            get { return _sampleInt; }
        }

        /*
         * TIPS : Use "_" as a first expression of private member valiables and Lower Camel Case.
         * 1. It makes it clear the difference between member valiables and function valiables.
         * 2. It prevent time wasting activity; finding a name of valiables.
         */
        [SerializeField]
        private int _sampleInt;

        /*
         * TIPS : Draw a line "//-------------" before #region preprocessor
         * 1. It makes boderline clearer
         */
        // ---------------------------------
        #region MonoBehavior functions
        private void Start()
        {
            /*
             * TIPS : Comment "FIXME" or "TODO" for the port which should be fixed later.
             */
            // FIXME : I'm not neccesary here
            _sampleInt = MAX_INT + _sampleInt;

            if (onStart != null) onStart();
        }

        private void OnDestroy()
        {
            if (onEnd != null) onEnd();
        }
		/*
         * TIPS : Write which section ends next to "#endregion".
         */
		#endregion // MonoBehavior functions


		/*
		 * TIPS : Enclose test cases with #region TEST and #if TEST.
		 * To modify and add defined symbols, check out "Window" > "Symbols".
		 */
		// ---------------------------------
		#region TEST
#if TEST
		/*
	     * TIPS : Put "t_" in head of valuable name for test case.
	     */
		private int t_int;

		private void TestCase()
		{
			t_int++;
			Debug.Log("[TEST] int : " + t_int.ToString());
		}
#endif
		#endregion // TEST
	}
}
