using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeedControill : MonoBehaviour
{
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            DataPlayer.Instanse.seed++;
            Destroy(this.gameObject);
        }
    }
   
}
