using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

namespace Game.Runtime
{
    public class ProjectilePool : MonoBehaviour
    {


        #region Publics

        //
    
        #endregion


        #region Unity API


        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            for (int i = 0; i < _poolSize; i++)
            {
                GameObject instance = Instantiate(_objectPrefab);
                instance.SetActive(false);
                _listOfObjects.Add(instance);
            }
        }

        #endregion
    


        #region Main Methods

        public GameObject GetFirstAvailableProjectile()
        {
            foreach (var instance in _listOfObjects)
            {
                if (!instance.activeSelf)
                {
                    return instance;
                }
            }
            var newInstance = Instantiate(_objectPrefab, transform);
            newInstance.SetActive(false);
            _listOfObjects.Add(newInstance);
            return newInstance;
        }
    
        #endregion

    
        #region Utils
    
        /* Fonctions privées utiles */
    
        #endregion
    
    
        #region Privates and Protected

        [SerializeField]
        private GameObject _objectPrefab;
        
        [SerializeField]
        private int _poolSize = 10;
        
        private List<GameObject> _listOfObjects = new List<GameObject>();

        #endregion
    }
}
