using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Template.DesignPatterns.EventDriven
{
    public class Character : MonoBehaviour
    {
        [SerializeField]
        private float m_MoveAmount = 1.0f;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                transform.position += (transform.forward * m_MoveAmount);
            }
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                transform.position -= (transform.forward * m_MoveAmount);
            }
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                transform.position += (transform.right * m_MoveAmount);
            }
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                transform.position -= (transform.right * m_MoveAmount);
            }
        }
    }
}
