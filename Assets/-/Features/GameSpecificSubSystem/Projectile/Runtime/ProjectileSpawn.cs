using UnityEngine;
using UnityEngine.InputSystem;

namespace Weapon.Runtime
{
    public class ProjectileSpawn : MonoBehaviour
    {


        #region Publics

        public GameObject m_projectilePrefab;
        
        #endregion


        #region Unity API


        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            
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
                _SpawnProjectile();
            }
        }
        
        #endregion

        
        #region Utils
        
        /* Fonctions privées utiles */
        private void _SpawnProjectile()
        {
            GameObject projectile = Instantiate(m_projectilePrefab);
            projectile.transform.position = transform.position;
            projectile.transform.rotation = transform.rotation;
        }
        
        #endregion
        
        
        #region Privates and Protected

        //

        #endregion
    }
}
