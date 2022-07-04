using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float rotateSpeed; // control how fast the player rotates
    public float moveSpeed; // control how fast the player moves
    public Transform pivotPoint; // point to rotate object around

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // rotate player
        transform.Rotate(0, 0, Input.GetAxis("Horizontal") * rotateSpeed * Time.deltaTime);

        // rotate around pivot
        //transform.RotateAround(pivotPoint.position, Vector3.up, Input.GetAxis("Horizontal") * Time.deltaTime);

        // move player
        transform.position += new Vector3(Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime, 0, 0);
    }
}
