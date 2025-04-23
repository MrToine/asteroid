using System;
using UnityEngine;

namespace Projectile.Runtime
{
    public class Projectile : MonoBehaviour
    {


        #region Publics

        public float m_speed = 1.0f;
        
        
        #endregion


        #region Unity API


        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Awake()
        {
            _timer = 0;
            _rigidbody = GetComponent<Rigidbody2D>();
            _gameObject = gameObject;
        }

        private void Update()
        {
            _timer -= Time.deltaTime;
            if (_timer <= 0)
            {  
                _gameObject.SetActive(false);
                _rigidbody.linearVelocity = Vector2.zero;
                _rigidbody.angularVelocity = 0f;
                _timer = _lifetime;
            }
        }

        private void OnEnable()
        {
            _rigidbody.linearVelocity = transform.up * (m_speed * Time.deltaTime);
        }

        private void OnCollisionEnter2D(Collision2D other)
        {
            _gameObject.SetActive(false);
        }

        #endregion
        


        #region Main Methods

        //
        
        #endregion

        
        #region Utils
        
        /* Fonctions privées utiles */
        
        #endregion
        
        
        #region Privates and Protected
        
        private GameObject _gameObject;
        private Rigidbody2D _rigidbody;
        private float _timer;
        
        [SerializeField]
        private float _lifetime = 3.0f;

        #endregion
    }
}
