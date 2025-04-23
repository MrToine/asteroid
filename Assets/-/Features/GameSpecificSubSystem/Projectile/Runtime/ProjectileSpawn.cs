using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Projectile.Runtime
{
    public class ProjectileSpawn : MonoBehaviour
    {


        #region Publics

        //
        
        #endregion


        #region Unity API


        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //
        }

        // Update is called once per frame
        void Update()
        {
            
        }

        #endregion
        


        #region Main Methods

        public void OnShoot(InputAction.CallbackContext context)
        {
            if (context.performed)
            {
                //BRR BRR PATAPIM
                var projectile = _poolSystem.GetFirstAvailableProjectile();
                projectile.transform.position = transform.position;
                projectile.transform.rotation = transform.rotation;
                projectile.SetActive(true);
            }
        }
        
        #endregion

        
        #region Utils
        
        /* Fonctions privées utiles */
        
        #endregion
        
        
        #region Privates and Protected

        [SerializeField]
        private ProjectilePool _poolSystem;

        #endregion
    }
}
