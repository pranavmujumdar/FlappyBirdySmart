using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottomPipe : MonoBehaviour
{
    private Vector3 startPosLocal;
    // Start is called before the first frame update
    private void Start()
    {
        startPosLocal = transform.localPosition;
        Debug.Log("Y of bottom: "+startPosLocal.y);
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    public void RandomizeYBottom()
    {
        
        transform.Translate(Vector3.down
            * Random.Range(0, 1.5f));
        Debug.Log("Bttom"+ transform.localPosition.y);
    }

    public void setYPosition(float y)
    {
        transform.localPosition = startPosLocal;
        transform.Translate(new Vector3(startPosLocal.x, y, startPosLocal.z), Space.Self);
        Debug.Log("Changed y");
    }
}
