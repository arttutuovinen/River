using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdMovement : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        // Check if the collision has a contact point
        if (collision.contacts.Length > 0)
        {
            // Get the collision normal
            Vector3 collisionNormal = collision.contacts[0].normal;

            // Reflect the object's direction based on the collision normal
            ReflectObject(collisionNormal);
        }
    }

    private void ReflectObject(Vector3 collisionNormal)
    {
        // Get the current object's velocity
        Rigidbody rb = GetComponent<Rigidbody>();
        Vector3 currentVelocity = rb.velocity;

        // Reflect the velocity based on the collision normal
        Vector3 reflectedVelocity = Vector3.Reflect(currentVelocity, collisionNormal);

        // Apply the reflected velocity to the object
        rb.velocity = reflectedVelocity;
    }
}
