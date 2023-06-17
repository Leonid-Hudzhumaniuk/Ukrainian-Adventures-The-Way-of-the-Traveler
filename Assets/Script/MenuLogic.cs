using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuLogic : MonoBehaviour
{
    public void OpenScene( int SceneNum)
    {                    
        SceneManager.LoadScene(SceneNum);
    } 
    
    public void ExitGame()
    {                    
        Application.Quit();
    }
}
