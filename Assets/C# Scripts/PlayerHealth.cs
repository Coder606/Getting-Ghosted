using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{   
    //THIS IS FOR PLAYER AND IMMA TRY REFERENCING 
    public int ghosts = 5;
    public int maxGhosts = 5;
    [SerializeField] HealthSystem hs;
    
        private void Start(){
            hs.DrawGhost(ghosts, maxGhosts);
        }
        public void DamagePlayer(int dmg){  
            if( ghosts <= maxGhosts)
            ghosts -= dmg;
            hs.DrawGhost(ghosts, maxGhosts);
            if(ghosts <= 0){
                SceneManager.LoadScene("GameOver",LoadSceneMode.Single);
            }

        }
}
