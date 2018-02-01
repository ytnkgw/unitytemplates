using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Template.HierarchyDesign
{

    public class Tips : MonoBehaviour
    {

        [SerializeField, TextArea(10, 10)]
        private string tips;

        private void Start()
        {
            tips += ""; // To avoid show warning.
        }

    }

}