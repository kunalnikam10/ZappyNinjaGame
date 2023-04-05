using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUpDown : MonoBehaviour
{
    private Rigidbody2D rb;
    private float moveSpeed;

    // public AudioSource audioPlayer;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        moveSpeed = 8f;
    }

    public void MoveUp()
    {
        rb.velocity = Vector2.up * moveSpeed;
    }

    public void MoveDown()
    {
        rb.velocity = Vector2.up * -moveSpeed;
    }

    public void StopMoving()
    {
        rb.velocity = Vector2.zero;
    }

    // void OnCollisionEnter (Collision collision)
    // {
    //     if(collision.gameObject.tag == "CollisionTag"){
    //         audioPlayer.Play();
    //     }
    // }
}