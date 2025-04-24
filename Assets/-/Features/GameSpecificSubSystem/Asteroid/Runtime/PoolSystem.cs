using System;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroid.Runtime
{
    public class PoolSystem : MonoBehaviour
    {
        #region public

        public int m_poolSize = 100;
        public GameObject[] asteroidPrefab;

        #endregion

        private void Awake()
        {
            _pool = new List<GameObject>();
            for (int i = 0; i < m_poolSize; i++)
            {
                _randomSprite = UnityEngine.Random.Range(0, asteroidPrefab.Length);
                GameObject asteroid = Instantiate(asteroidPrefab[_randomSprite]);
                asteroid.SetActive(false);
                _pool.Add(asteroid);
            }
        }

        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        public GameObject GetAsteroid()
        {
            foreach (GameObject asteroid in _pool)
            {
                if (!asteroid.activeSelf)
                {
                    return asteroid;
                }
            }

            return null;
        }

        #region private

        private List<GameObject> _pool;
        private int _randomSprite = 0;

        #endregion

    }
}