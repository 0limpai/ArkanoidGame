﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewGame : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {

        Application.LoadLevel("Level1");
    }
}

