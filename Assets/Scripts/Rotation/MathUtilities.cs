using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MathUtilities : MonoBehaviour
{
    public const float TAU = Mathf.PI * 2;
    
    public static float DirToAngle(Vector2 direction) => Mathf.Atan2(direction.y, direction.x);

    public static Vector2 AngToDir(float angleRad) => new Vector2(Mathf.Cos(angleRad),Mathf.Sin(angleRad));
}
