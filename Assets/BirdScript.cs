using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidBody;
    public GameObject tailUp;
    public GameObject tailDown;
    public float flapStrength;
    LogicScript logic;
    private bool birdIsAlive = true;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true && birdIsAlive == true)
        {
            myRigidBody.linearVelocity = Vector2.up * flapStrength;
            tailUp.SetActive(true);
            tailDown.SetActive(false);
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            tailUp.SetActive(false);
            tailDown.SetActive(true);
        }


        if (transform.position.y > 18 || transform.position.y < -17)
        {
            logic.isGameOver();
            birdIsAlive = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.isGameOver();
        birdIsAlive = false;
    }
}
