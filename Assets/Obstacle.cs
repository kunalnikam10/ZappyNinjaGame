using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private GameObject player;

    public AudioSource audioPlayer;

    void Start()
    {
        player=GameObject.FindGameObjectWithTag("Player");
        audioPlayer = GetComponent<AudioSource> ();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Border")
        {
            Destroy(this.gameObject);
        }

        else if(collision.tag == "Player")
        {
            audioPlayer.Play();
            
            Destroy(player.gameObject);
        }
    }

    
}
