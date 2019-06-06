using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour
{
   
    public Sprite BSR_2;
    public Sprite BSR_3;
    public int hitsNeeded = 2;
    public int hitsTaken;
    public Rigidbody2D ball;
    private SpriteRenderer cc;

    void Start()
    {
        hitsTaken = 0;
        cc = GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        if (hitsTaken == 1)
        { cc.sprite = BSR_2;
        }
        if (hitsTaken == 2)
        {
            cc.sprite = BSR_3;
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {


        hitsTaken += 1;
        if (hitsTaken >= hitsNeeded)
        {
            Destroy(gameObject);
        }


    }
}
