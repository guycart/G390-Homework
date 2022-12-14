using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Healer : MonoBehaviour
{
    public Transform playerTrans;

    public float maxHealRadius = 10f;

    public float minHealRadius = 25f;

    public float minHealStrength = 1f;

    public float maxHealStrength = 15f;

    
    private void OnDrawGizmos()
    {
        var pos = transform.position;
        Handles.color = Color.green;
        Handles.DrawWireDisc(pos, Vector3.up, maxHealRadius);
        Handles.color = Color.yellow;
        Handles.DrawWireDisc(pos, Vector3.up, minHealRadius);
    }

    private void Update() 
    {
        float playerDist = Vector3.Distance(playerTrans.position, transform.position);
        if(playerDist > minHealRadius)
        {
            MathUtilities.Remap(minHealRadius, maxHealRadius, minHealStrength, maxHealStrength, playerDist);
        }

        print(currentHealingAmount)
    }
}
