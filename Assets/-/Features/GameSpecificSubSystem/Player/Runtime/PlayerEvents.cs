using System;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Serialization;

namespace Player.runtime
{
    public class PlayerEvents : MonoBehaviour
    {


        #region Publics

        public float m_speed = 0.5f;
        public float m_speedMax = 1.5f;
        public GameObject m_fire;
        
        #endregion


        #region Unity API

        private void Start()
        {
            _rigidbody = GetComponent<Rigidbody2D>();
        }

        private void Update()
        {
            if (_isThrusting)
            {

                if (_rigidbody.linearVelocity.magnitude < m_speedMax)
                {
                    m_fire.SetActive(true);
                    _rigidbody.AddForce(transform.up * m_speed, ForceMode2D.Force);
                }   
            }
            else
            {
                m_fire.SetActive(false);
            }
        }

        #endregion
        


        #region Main Methods

        public void OnMousePos(InputAction.CallbackContext context)
        {
            _mousePos = context.ReadValue<Vector2>();
            Vector3 mousePosInWorld = Camera.main.ScreenToWorldPoint(new Vector3(_mousePos.x, _mousePos.y, -Camera.main.transform.position.z));
            transform.rotation = Quaternion.LookRotation(Vector3.forward, mousePosInWorld);
            //transform.LookAt(transform.forward,mousePosInWorld);
        }

        public void OnMovement(InputAction.CallbackContext context)
        {
            if (context.performed)
            {
                _isThrusting = true;
            }

            if (context.canceled)
            {
                _isThrusting = false;
            }
        }
        
        #endregion

        
        #region Utils
        
        /* Fonctions privées utiles */
        
        #endregion
        
        
        #region Privates and Protected

        private Vector2 _mousePos;
        private Rigidbody2D _rigidbody;
        private bool _isThrusting;
        
        #endregion
    }
}
