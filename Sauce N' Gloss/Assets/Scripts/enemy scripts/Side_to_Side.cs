using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Side_to_Side : MonoBehaviour
{
    public float moveSpeed = 2;
    private Vector3 startPosition;
    public Vector3 targetPosition;
    private bool moveToTarget;

    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
        moveToTarget = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (moveToTarget)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);
            if (transform.position == targetPosition)
            {
                moveToTarget = false;
            }
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, startPosition, moveSpeed * Time.deltaTime);
            if (transform.position == startPosition)
            {
                moveToTarget = true;
            }
        }
        
    }
}
