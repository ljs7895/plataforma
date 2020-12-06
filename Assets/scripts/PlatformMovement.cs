using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovement : MonoBehaviour
{

    public GameObject ObjMove;
    public Transform StartPoint;
    public Transform EndPoint;


    public float vel;

    private Vector3 Move;
    // Start is called before the first frame update
    void Start()
    {
        Move = EndPoint.position;
    }

    // Update is called once per frame
    void Update()
    {
        ObjMove.transform.position = Vector3.MoveTowards(ObjMove.transform.position, Move, vel * Time.deltaTime);
        
        if (ObjMove.transform.position == EndPoint.position)
        {
            Move = StartPoint.position;
        }
        if (ObjMove.transform.position == StartPoint.position)
        {
            Move = EndPoint.position;
        }
    }
}
