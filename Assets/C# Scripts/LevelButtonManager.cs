using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelButtonManager : MonoBehaviour
{   

    public void RestartGame(){
    StartCoroutine(Restart());
    }
        public void TitleScreenGame(){
        StartCoroutine(TitleScreen());
    }
    //apparently you have to use coroutines whatever the frick that is just 
    //to make your button sound play after itself gdi >:(
    public void Quit(){
        StartCoroutine(QuitGame());
    }

   
        IEnumerator Restart(){
        yield return new WaitForSeconds(1);
            SceneManager.LoadScene("GraveYard", LoadSceneMode.Single);
        }

        IEnumerator TitleScreen(){
            
              yield return new WaitForSeconds(1);
            SceneManager.LoadScene("TitleScreen", LoadSceneMode.Single);
        }

        IEnumerator QuitGame(){
        yield return new WaitForSeconds(1);
            Debug.Log("I've Quit The Game");
            Application.Quit();
        }

      
}
