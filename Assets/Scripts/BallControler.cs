using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControler : MonoBehaviour
{
    Rigidbody ballRigidBody;
    int forceMultiplier;
    private float elapsedTime = 0f;
    public float increaseInterval = 1f; 
    

    void Start()
    {
        ballRigidBody = GetComponent<Rigidbody>();
    }

    void Update()
    {   
        //Building up force of roll
       if(Input.GetKey(KeyCode.Space))
        {
            ForceAdd();
        }
          //Releasing the bowling ball
        if(Input.GetKeyUp(KeyCode.Space))
        {
            ImpulseForce(forceMultiplier);
        } 
    }

    public void ImpulseForce(int forceMultiplier)
    {
        //Force applictaion
        Vector3 ballDrive = new Vector3(-5.0f -forceMultiplier, 0f, 0f);
        ballRigidBody.AddForce(ballDrive,ForceMode.Impulse);
    }

    public void ForceAdd()
    {
        {
            //Increasing force per second 
            elapsedTime += Time.deltaTime;

            if (elapsedTime >= increaseInterval)
            {
                forceMultiplier++;
                elapsedTime = 0f;
                Debug.Log("FORCE" + forceMultiplier);
            }   
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        // Check if the collision is happening with the Deadzone
        if (collision.gameObject.CompareTag("Deadzone"))
        {
            // Destroy the ball
            Destroy(gameObject);
        }
    }

   
}
