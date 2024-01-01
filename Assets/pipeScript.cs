using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeScript : MonoBehaviour
{

    public float movespeed = 20;

    public float deadX = -45;
    void Start()
    {
        
    }

    void Update()
    {
        transform.position += (Vector3.left * movespeed) * Time.deltaTime;

        if (transform.position.x < -45) {
            // Debug.log("pipe deleted!");
            Destroy(gameObject);
        }

    }
}
