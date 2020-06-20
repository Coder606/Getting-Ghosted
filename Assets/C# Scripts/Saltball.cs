using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saltball : MonoBehaviour
{
    public AudioSource takedamage;
    public PlayerHealth playerHealth;
    // Start is called before the first frame update

   void OnTriggerEnter2D(Collider2D other) {
       Debug.Log("has been hit");
        PlayerHealth health = other.GetComponent<PlayerHealth>();
       if(health != null){
           health.DamagePlayer(1);
           takedamage.Play();
       }
    }

}
