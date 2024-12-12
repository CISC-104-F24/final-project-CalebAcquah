using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Levelselector : MonoBehaviour
{
    

     public void NextLevel1()
    {
        SceneManager.LoadSceneAsync("Boss 1");
    }

    public void NextLevel2()
    {
        SceneManager.LoadSceneAsync("Boss 2");
    }

    public void FinalLevel()
    {
        SceneManager.LoadSceneAsync("Final Boss");
    }

    public void Levelselect()
    {
        SceneManager.LoadSceneAsync("Levels");
    }

    
   

}
    
