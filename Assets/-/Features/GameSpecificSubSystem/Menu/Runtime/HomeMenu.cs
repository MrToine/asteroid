using UnityEngine;
using UnityEngine.SceneManagement;

namespace Menu.Runtime
{
    public class HomeMenu : MonoBehaviour
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
        
        }

        #endregion
    


        #region Main Methods

        public void StartGame()
        {
            Debug.Log("StartGame");
            SceneManager.LoadScene("Game");
        }
    
        #endregion

    
        #region Utils
    
        /* Fonctions privées utiles */
    
        #endregion
    
    
        #region Privates and Protected

        //

        #endregion
    }
}
