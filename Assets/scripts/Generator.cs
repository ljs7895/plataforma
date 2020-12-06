using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    public GameObject[] obj;
    public float tiempoMin = 0.5f;
    public float tiempoMax = 1f;

    // Start is called before the first frame update
    void Start()
    {
        Generar();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Generar() {  
      Instantiate(obj[Random.Range(0, obj.Length)], transform.position, Quaternion.identity);
        Invoke("Generar", Random.Range(tiempoMin, tiempoMax));
    }
}
