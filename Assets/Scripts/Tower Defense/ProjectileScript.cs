using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileScript : MonoBehaviour
{
    public Vector3 targetPosition;

    public float speed = 10f;

    public int damage = 4;

    public float lifeSpan = 10f;

    public Vector3 targetLocation;

    private void MoveToTarget()
    {
        Transform projectileTransform = transform;
        Vector3 directionToTarget = (targetPosition - projectileTransform.position).normalized;
        projectileTransform.position += directionToTarget * speed * Time.deltaTime;
    }
}
