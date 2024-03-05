using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour
{
    public float force;
    private Rigidbody2D rb;
    private int Points=0;
    public Text ScoreText;
   // public AudioSource endAudio;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
           rb.velocity = Vector2.up * force;
        }
        else if (Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * force;
        }
       // else
       //{
       //   return;
        //}
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.tag == "pipescore")
            {
                PlayerManager.isGameOver=true;
                //Debug.Log("Game Over");
                gameObject.SetActive(false);
            }
            
        else
           {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
           }
         
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
    if (collision.gameObject.tag=="pipescore")
        {

            Points++;
            ScoreText.text=Points.ToString();
        }
    }
     
}
