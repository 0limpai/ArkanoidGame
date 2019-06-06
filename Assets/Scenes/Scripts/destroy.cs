using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour
{
   
    public Sprite BSR_2;
    public int hitsNeeded = 2;
    public int hitsTaken;

   

    void OnCollisionEnter2D(Collision2D collision)
    {
        

        hitsTaken += 1;
       if (hitsTaken >= 1)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = BSR_2;
        }

        else if (hitsTaken >= hitsNeeded)
            Destroy(gameObject);


    }
}
