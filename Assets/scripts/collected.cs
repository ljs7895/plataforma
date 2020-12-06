using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collected : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("notas"))
        {
            Destroy(other.gameObject);
        }
    }
}
