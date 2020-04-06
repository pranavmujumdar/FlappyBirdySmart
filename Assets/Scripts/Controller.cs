using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Controller : MonoBehaviour
{
    public float tapForce = 10;
    public float tiltSmooth = 5;
    public Vector3 startPos;

    Rigidbody2D rigidbody;
    Quaternion downRotatation;
    Quaternion forwardRotation;

    private void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        downRotatation = Quaternion.Euler(0, 0, -90);
        forwardRotation = Quaternion.Euler(0, 0, 35);
        rigidbody.simulated = true;
        startPos = transform.position;
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            transform.rotation = forwardRotation;
            rigidbody.velocity = Vector3.zero;
            rigidbody.AddForce(Vector2.up * tapForce, ForceMode2D.Force);
        }
        transform.rotation = Quaternion.Lerp(transform.rotation, downRotatation, tiltSmooth * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.gameObject.tag);
        /*if(collision.gameObject.CompareTag("ScoreZone"))
        {
            Debug.Log("score");
        }*/
        if(collision.gameObject.CompareTag("DeadZone"))
        {
            rigidbody.simulated = false;
            Debug.Log("Dead");

            SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
        }
    }
}
