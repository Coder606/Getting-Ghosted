using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreSystem : MonoBehaviour
{
    public GameObject ScoreText;
    public static int theScore;


    void Update(){

            ScoreText.GetComponent<Text>().text = theScore + "/5";
            if(theScore == 5){

            SceneManager.LoadScene("YouWin", LoadSceneMode.Single);
            }
    }
}
