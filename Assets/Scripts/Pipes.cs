using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipes : MonoBehaviour
{
    public float spacing = 2.5f; // Distance between pipes
    private const int totalPipes = 3;
    private Vector3 startPos;
    public float pipeVariance = 1f;
    public float speed = 5f;
    public BottomPipe bottomPipe;
    private void Awake()
    {
        startPos = transform.localPosition;
        RandomizeY();
    }

    private void LateUpdate()
    {
        transform.Translate(Vector3.left *  speed * Time.deltaTime);
        if (transform.localPosition.x < -spacing)
        {
            transform.Translate(Vector3.right *
                spacing * totalPipes);
            RandomizeY();
           // bottomPipe.RandomizeYBottom();
            bottomPipe.setYPosition(Random.Range(-2, 1));
        }
        
    }

    public void InitialPosition()
    {
        transform.localPosition = startPos;
        
        //RandomizeY();
    }

    private void RandomizeY()
    {
        transform.Translate(Vector3.up
            * Random.Range(-pipeVariance, pipeVariance));
        Debug.Log("called");
        
    }
}
