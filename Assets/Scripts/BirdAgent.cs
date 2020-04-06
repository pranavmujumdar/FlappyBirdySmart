using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MLAgents;
using MLAgents.Sensors;

public class BirdAgent : Agent
{
    //public Transform spawnPos;
    

    public GameObject ScoreZone;
    
    public bool useVectorObs;

    public float tapForce = 200f;
    public float tiltSmooth = 5;
    Rigidbody2D m_AgentRb;
    private Vector3 startPos;
    //Quaternion downRotatation;
    //Quaternion forwardRotation;
    public bool isDead = false;
    public PipeSet pipes;
    public ScoreUpdater score;

    private bool screenPressed =false;

    private void Start()
    {
        startPos = transform.position;
    }
    public override void Initialize()
    {
        m_AgentRb = GetComponent<Rigidbody2D>();
       // downRotatation = Quaternion.Euler(0, 0, -90);
     //   forwardRotation = Quaternion.Euler(0, 0, 35);
    }

    public void PassedThrough()
    {
        // We use a reward of 5.
        AddReward(1f);
        Debug.Log("score");
    }
    public void Died()
    {
        isDead = true;
        Debug.Log("Here in Died");
        AddReward(-1f);
        
        EndEpisode();
    }

    public void MoveAgent(float[] act)
    {
        int tap = Mathf.FloorToInt(act[0]);
        if(tap > 0)
        {
            Push();
        }
    }
    

    public override void OnActionReceived(float[] vectorAction)
    {
        {
            AddReward(0.1f);
            int action = Mathf.FloorToInt(vectorAction[0]);
            if(action == 0)
            {
            }
            if(action == 1)
            {
                Push();
            }
        }
    }

    public override void CollectObservations(VectorSensor sensor)
    {
        base.CollectObservations(sensor);
    }

    public override float[] Heuristic()
    {
        var action = new float[1];        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Pressed");
            action[0] = 1 ;
        }
        else
        {
            action[0] = 0;
        }
        return action;
    }

    public override void OnEpisodeBegin()
    {

        //Debug.Log(transform.position.x);
        Debug.Log("Episode Begin");
        isDead = false;
        pipes.ResetPos();
        m_AgentRb.velocity = Vector3.zero;
        transform.position = startPos;
        RandomizeY();
        score.resetScore();
    }
    private void RandomizeY()
    {
        this.transform.Translate(Vector3.up
            * Random.Range(-1f, 1f));
    }

    private void Push()
    {
        m_AgentRb.velocity = Vector3.zero;
        m_AgentRb.AddForce(Vector2.up * tapForce, ForceMode2D.Force);
    }

}
