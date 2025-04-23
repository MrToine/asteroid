using System;
using UnityEngine;

namespace Player.Runtime
{
    public class PlayerStats : MonoBehaviour
    {


        #region Publics

        //
    
        #endregion


        #region Unity API


        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
            CheckState();
        }

        private void OnCollisionEnter(Collision other)
        {
            _lives -= 1;
            _isTouched = true;
        }

        #endregion
    


        #region Main Methods

        void CheckState()
        {
            if (_isTouched)
            {
                _timer -= Time.deltaTime;
                if (_timer <= 0)
                {
                    Debug.Log("Touché !!");
                }
                _timer = 2.0f
            }
        }
    
        #endregion

    
        #region Utils
    
        /* Fonctions privées utiles */
    
        #endregion
    
    
        #region Privates and Protected

        [SerializeField] private int _lives = 5;
        private bool _isTouched = false;
        private float _timer;

        #endregion
    }
}
