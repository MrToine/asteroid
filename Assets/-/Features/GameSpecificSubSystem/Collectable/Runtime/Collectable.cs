using UnityEngine;

namespace Collectable.Runtime
{
    public class Collectable : MonoBehaviour
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
            RotateAndZoom();
        }

        void OnCollisionEnter2D(Collision2D other)
        {
            
            Debug.Log("Collision avec " + other.gameObject.name);
        }

        #endregion
    


        #region Main Methods

        //
    
        #endregion

    
        #region Utils
    
        /* Fonctions privées utiles */
        private void RotateAndZoom()
        {
            _timer -= Time.deltaTime;
            transform.RotateAround(transform.position, transform.up, Time.deltaTime * 120f);

            if (_timer <= 0)
            {
                if (_stateZoom)
                {
                    transform.localScale += new Vector3(0.01f, 0.01f, 0.01f);
                }
                else
                {
                    transform.localScale -= new Vector3(0.01f, 0.01f, 0.01f);
                }
                _timer = 2.5f;
            }
            else
            {
                _stateZoom = !_stateZoom;
            }
        }
    
        #endregion
    
    
        #region Privates and Protected

        private float _timer;
        private bool _stateZoom = false;
        [SerializeField] private GameObject[] _listOfProjectile;

        #endregion
    }
}
