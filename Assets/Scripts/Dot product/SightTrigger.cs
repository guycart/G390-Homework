using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SightTrigger : MonoBehaviour
{
    public Transform triggerTransform;

    public float lookThreshold = 0.5f;

    private void OnDrawGizmos() {
        Vector3 triggerUp = triggerTransform.up;
        Vector3 objectUp = transform.up;

        VectorRenderer.DrawVector(triggerTransform.position, triggerTransform.position + triggerUp * 5);
        VectorRenderer.DrawVector(transform.position, transform.position + objectUp * 5);

        float lookRelationship = Vector3.Dot(triggerUp, objectUp);
        print(lookRelationship);

        if(lookRelationship >= lookThreshold)
        {
            print("He can see you");
        }
    }
}
