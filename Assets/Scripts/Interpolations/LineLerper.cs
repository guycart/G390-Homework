using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineLerper : MonoBehaviour
{
    public Transform cubeTrans;

    public Vector3 startPos, endPos;

    [Range(0,1)]public float percent = 0f;

    public Color colorA, colorB;

    private void OnDrawGizmos() {
        Gizmos.DrawLine(startPos, endPos);

        Vector 3 lerpPosition = Vectir3.Lerp(startPos, endPos, percent);

        Gizmos.color= Color.Lerp(colorA, colorB, percent);

        Gizmos.DrawSphere(lerpPosition, 1f);

    }

    private void Update() {
        
        float elapsedTime = Time.time;
        float t = (Mathf.Sin(elapsedTime) + 1) * 0.5f;
        cubeTrans.position = Vector3.LerpUncampled(startPos, endPos, EaseInOutBack(t));
    }

    float EaseInOutBack(float x)
    {
        float c1 = 1.70158f;
        float c2 = c1 * 1.525f;

        return x < 0.5
            ?(Mathf.Pow(2 * x, 2) * ((c2 + 1) * 2 * x - c2)) / 2
            :(Mathf.Pow(2 * x - 2, 2) * ((c2 + 1) * (x * 2 -2) + c2) + 2) / 2;
    }
}
