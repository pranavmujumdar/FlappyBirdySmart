using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallaxer : MonoBehaviour
{
    //public Vector3 spawnPos;
    public Vector3 destroyPos;
    public float speed = 5f;
    public Rigidbody2D rb;

    private void Start()
    {
        //transform.position = spawnPos;
    }
    private void FixedUpdate()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
        //Debug.Log(transform.position.x);
    }

    private void LateUpdate()
    {
        if (transform.position.x <= destroyPos.x)
        {
            transform.position = new Vector3(7.4f,transform.position.y, transform.position.z);
        }
    }

}
