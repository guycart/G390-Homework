using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  static class VectorDrawer
{
    public static void DrawVector(Vector3 startPoint, Vector3 endPoint)
    {
        Debug.DrawLine(startPoint, endPoint);
    }

    public static void DrawVector(Vector3 startPoint, Vector3 endPoint, Color color)
    {
        Debug.DrawLine(startPoint, endPoint, color);
    }

    public static void DrawBasisVectors(Vector3 origin, Vector3 right, Vector3 up, Vector3 forward)
    {
        Debug.DrawLine(origin, origin + right, Color.red);
        Debug.DrawLine(origin, origin + up, Color.green);
        Debug.DrawLine(origin, origin + forward, Color.blue);
    }
}
