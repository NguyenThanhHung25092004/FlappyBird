using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    // Start is called before the first frame update
    public float pipeSpeed = 5;
    public float deadZone = -90;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * pipeSpeed) * Time.deltaTime;
        destroyPipes();
    }

    void destroyPipes()
    {
        if ( transform.position.x < deadZone )
        {
            Destroy(gameObject);
        }
    }
}
