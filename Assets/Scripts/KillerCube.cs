using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillerCube : MonoBehaviour
{
    private bool i;
    public Transform target1;
    public Transform target2;
    public float speed;

    void Start()
    {
        i = true;
    }

    void Update()
    {
        if (i == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, target1.position, speed * Time.deltaTime);
            if (transform.position == target1.position)
            {
                i = false;
            }
        }

        if (i == false)
        {
            transform.position = Vector3.MoveTowards(transform.position, target2.position, speed * Time.deltaTime);
            if (transform.position == target2.position)
            {
                i = true;
            }
        }

    }
}
