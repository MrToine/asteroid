using UnityEngine;

public class ScreenWrapper : MonoBehaviour
{


    #region Publics

    //
    
    #endregion


    #region Unity API


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        _playerPos = transform.position;
        _camera = Camera.main;
        
        cameraHeight = _camera.orthographicSize * 2;
        cameraWidth = cameraHeight * _camera.aspect;

        leftBound = _camera.transform.position.x - cameraWidth / 2f;
        rightBound = _camera.transform.position.x + cameraWidth / 2f;
        bottomBound = _camera.transform.position.y - cameraHeight / 2f;
        topBound = _camera.transform.position.y + cameraHeight / 2f;

    }

    // Update is called once per frame
    private void Update()
    {
        _playerPos = transform.position;
        if (transform.position.x < leftBound)
        {
            _playerPos.x = rightBound;
        }

        if (transform.position.x > rightBound)
        {
            _playerPos.x = leftBound;
        }

        if (transform.position.y < bottomBound)
        {
            _playerPos.y = topBound;
        }

        if (transform.position.y > topBound)
        {
            _playerPos.y = bottomBound;
        }
        transform.position = _playerPos;
    }

    #endregion
    


    #region Main Methods

    //
    
    #endregion

    
    #region Utils
    
    /* Fonctions privées utiles */
    
    #endregion
    
    
    #region Privates and Protected

    private Vector2 _playerPos;
    private Camera _camera;

    private float cameraHeight;
    private float cameraWidth;

    private float leftBound;
    private float rightBound;
    private float bottomBound;
    private float topBound;


    #endregion
}
