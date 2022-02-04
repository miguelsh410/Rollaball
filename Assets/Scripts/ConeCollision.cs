using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConeCollision : MonoBehaviour
{
    public float force = 1;
    
    private Rigidbody cone;

    // Start is called before the first frame update
    void Start()
    {
        cone = GetComponent<Rigidbody>();
    }

    //void OnCollisionEnter(Collision collision)
    //{
      //  if (collision.collider.CompareTag("Player")) {
        //    Debug.Log("Collision");
          //  Vector3 playerVelocity = collision.collider.attachedRigidbody.velocity;
            //cone.MovePosition(playerVelocity * force * Time.deltaTime);
        //}    
    //}
}
