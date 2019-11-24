﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveByTouch : MonoBehaviour
{
  
    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0); // first is 0, second is 1, and so on
            Vector3 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
            touchPosition.z = 0;
            transform.position = touchPosition;
        }
    }
}
