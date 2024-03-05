using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipes : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    Rigidbody2D rb;
    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity=Vector2.left*speed;
    }
    private void OnTriggerEnter2D(Collider2D collisition)
    {
        if(collisition.gameObject.tag=="endpipe")
        {
            Destroy(gameObject);
        }
    }
}
