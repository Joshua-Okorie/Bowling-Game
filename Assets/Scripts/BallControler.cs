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

    // Update is called once per frame
    void Update()
    {   
       if(Input.GetKey(KeyCode.Space))
        {
            ForceAdd();
        }
          
        if(Input.GetKeyUp(KeyCode.Space))
        {
            ImpulseForce(forceMultiplier);

        } 
    }

    public void ImpulseForce(int forceMultiplier)
    {
        Vector3 ballDrive = new Vector3(-5.0f -forceMultiplier, 0f, 0f);
        ballRigidBody.AddForce(ballDrive,ForceMode.Impulse);
    }

    public void ForceAdd()
    {
        {
            elapsedTime += Time.deltaTime;

            if (elapsedTime >= increaseInterval)
            {
                forceMultiplier++;
                elapsedTime = 0f;
                Debug.Log("FORCE" + forceMultiplier);
                
            }
            
        }

    }

   
}
