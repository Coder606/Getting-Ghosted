using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectfrend : MonoBehaviour
{

    public AudioSource collect;


    void OnTriggerEnter2D(Collider2D other)
    {

        collect.Play();
        ScoreSystem.theScore += 1;
        Destroy(gameObject);
    }
}
