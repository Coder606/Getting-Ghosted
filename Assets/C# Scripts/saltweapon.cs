using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class saltweapon : MonoBehaviour
{
    public float shootingRange;
    public ParticleSystem salt;
    public AudioSource takedamage;
    public GameObject player;
    public PlayerHealth damagePlayer;

    public void OnParticleCollision(GameObject other)
    {
        
        //damage player by referencing the playerhealth script's take damage
        PlayerHealth health = other.GetComponent<PlayerHealth>();
        //if health is not equal to n u l l ????
        if(health != null){
            health.DamagePlayer(1);
            takedamage.Play();
            
        }
    }

    void Update(){
        //if the distance from player is less than shooting range, then
        float distancefromplayer = Vector2.Distance(player.transform.position, transform.position);
        if (distancefromplayer < shootingRange)
        {
            //see if salt is playing if its not! playing then play the dang salt particles ya hear?
            if (!salt.isPlaying) { 
                salt.Play(); 
                }

        }
        //if salt is playing then stop playing it when its far from player I guess u_u

        else if (salt.isPlaying) { 
            salt.Stop(); 
            }
    }
       
    }
    

