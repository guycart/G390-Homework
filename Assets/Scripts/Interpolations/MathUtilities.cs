using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MathUtilities : MonoBehaviour
{
    public const float TAU = Mathf.PI * 2;

    public static float DirToAngle(Vector2 direction) => Mathf.Atan2(direction.y, direction.x);

    public static Vector2 AngToDir(float angleRad) => new Vector2(Mathf.Cos(angleRad), Mathf.Sin(angleRad));

    public static float AngBetweenVectors(Vector2 v1, Vector2 v2) => Vector3.Dot(v1, v2) / (v1.magnitude * v2.magnitude);

    public static float InverseLerp(Vector3 a, Vector3 b, Vector3 value)
    {
        Vector3 aToB = b - a;
        Vector3 aToV = value - a;
        return Vector3.Dot(aToV, aToB) / Vector3,Dot(aToB, aToB);
    }

    public static float Remap(float iMin, float iMax, float oMin, float oMax, float value) => Mathf.Lerp(oMin, oMax, Mathf.InverseLerp(iMin, iMax, value));
}