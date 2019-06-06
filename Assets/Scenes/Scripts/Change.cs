using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change : MonoBehaviour
{
    private SpriteRenderer rend;
    private Sprite BSR_1, BSR_2;




    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        BSR_1 = Resources.Load<Sprite>("BSR_1");
        BSR_2 = Resources.Load<Sprite>("BSR_1");
        rend.sprite = BSR_1;
    }

    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (rend.sprite == BSR_1)
        rend.sprite = BSR_2;

        
    }
}
