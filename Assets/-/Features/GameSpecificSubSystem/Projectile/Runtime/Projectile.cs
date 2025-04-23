using UnityEngine;

namespace Weapon.Runtime
{
    public class Projectile : MonoBehaviour
    {


        #region Publics

        public float m_speed = 1.0f;
        
        #endregion


        #region Unity API


        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            _rigidbody = GetComponent<Rigidbody2D>();
            _rigidbody.linearVelocity = transform.up * m_speed * Time.deltaTime;
        }

        #endregion
        


        #region Main Methods

        //
        
        #endregion

        
        #region Utils
        
        /* Fonctions privées utiles */
        
        #endregion
        
        
        #region Privates and Protected

        private Rigidbody2D _rigidbody;

        #endregion
    }
}
