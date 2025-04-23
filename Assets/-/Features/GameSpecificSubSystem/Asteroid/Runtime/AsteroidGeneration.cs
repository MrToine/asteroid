using UnityEngine;
using UnityEngine.Serialization;

namespace Asteroid.Runtime
{


    public class AsteroidGeneration : MonoBehaviour
    {
        #region public

        public GameObject[] asteroids;
        [FormerlySerializedAs("asteroidPool")] public PoolSystem m_asteroidPool;

        #endregion

        void Start()
        {

        }


        void LateUpdate()
        {
            _countDown += Time.deltaTime;
            if (_countDown > _timeToReach)
            {
                _timeToReach = Random.Range(3f, 6f);
                _countDown = 0;
                GameObject asteroid = m_asteroidPool.GetAsteroid();
                asteroid.transform.position = transform.position;
                asteroid.transform.rotation = Quaternion.identity;
                asteroid.SetActive(true);
                asteroid.GetComponent<MeteorMovement>().Launch();

            }
        }

        #region private


        private float _countDown;
        private float _timeToReach;
        private int _objectToInstantiate = 0;

        #endregion
    }
}