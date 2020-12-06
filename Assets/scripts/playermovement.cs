using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    public float vel = 5;
    public float correrVel = 10;
    public float fuerzaSalto = 600f;

    public LayerMask capaSuelo;
    public Transform checkSuelo;
    bool enSuelo;
    bool correr;

    Rigidbody2D rb;
    Animator anim;
    Vector3 escalaPric;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        escalaPric = transform.localScale;
    }

    // Update is called once per frame
    private void Update()
    {
        float h;
        if (Input.GetKey(KeyCode.LeftShift))
        {
            correr = true;
        }
        else
        {
            correr = false;
        }
        if(correr)
        {
            h = Input.GetAxis("Horizontal") * correrVel;
        }
        else
        {
            h = Input.GetAxis("Horizontal") * vel;
        }


        rb.velocity = new Vector2(h, rb.velocity.y);

        if (Input.GetKeyDown(KeyCode.W) && enSuelo)
        {
            rb.AddForce(Vector2.up * fuerzaSalto);
            anim.SetTrigger("Saltar");
        }

        if (rb.velocity.x > 0)
        {
            transform.localScale = escalaPric;
        }
        else if (rb.velocity.x < 0)
        {
            transform.localScale = new Vector3(-escalaPric.x, escalaPric.y, escalaPric.z);
        }

        //animaciones

        if (h != 0)
        {
            anim.SetBool("Andar", true);
        }
        else
        {
            anim.SetBool("Andar", false);
        }
        anim.SetBool("Correr", correr);
        anim.SetBool("enSuelo", enSuelo);


    }


    private void FixedUpdate()
    {
        enSuelo = Physics2D.OverlapCircle(checkSuelo.position, 0.1f, capaSuelo);
    }
}
