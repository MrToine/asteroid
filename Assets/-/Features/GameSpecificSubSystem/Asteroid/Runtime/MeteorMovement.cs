using UnityEngine;
using UnityEngine.Serialization;


namespace Asteroid.Runtime
{
    public class MeteorMovement : MonoBehaviour
    {

        #region public

        [FormerlySerializedAs("forceAmount")] public float m_forceAmount = 1f;
        public float m_randomDirection = 0.3f;
       

        #endregion

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
           
        }

        // Update is called once per frame
        void Update()
        {

        }

        public void SetDirection()
        {


        }

        void OnCollisionEnter2D(Collision2D other)
        {
            gameObject.SetActive(false);
        }
        public void Launch()
        {
            _worldCenter = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width / 2, Screen.height / 2, 10));
            Vector2 _baseDirection = (_worldCenter - transform.position).normalized;
            Vector2 _randomOffset = Random.insideUnitCircle * m_randomDirection;
            Vector2 _finalDirection = (_baseDirection + _randomOffset).normalized;

            Rigidbody2D _rb = GetComponent<Rigidbody2D>();
            _rb.AddForce(_finalDirection * m_forceAmount * _rb.mass, ForceMode2D.Impulse);
        }

        #region private

        private Vector2 _coinHautDroit;
        private Vector2 _coinBasDroit;
        private Vector2 _coinHautGauche;
        private Vector2 _coinBasGauche;
        private Vector2 _screenCenter;
        private Vector3 _worldCenter;

        #endregion
    }
}
