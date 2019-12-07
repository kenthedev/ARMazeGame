using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fog : MonoBehaviour
{
     private void OnTriggerEnter(Collider collision)
    {
        
        if (collision.gameObject.CompareTag("Fog"))
        {
            Destroy(collision.gameObject);
            Debug.Log("Fog destroyed");
        }
    }
}
