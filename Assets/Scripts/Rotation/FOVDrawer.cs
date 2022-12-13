using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FOVDrawer : MonoBehaviour
{
    [Range (0, 180)]public float fovRangeDeg = 45;

    float fovRangeRad => Mathf.Deg2Rad * fovRangeDeg;

    float fovHalfAng => fovRangeRad * 0.5f;

    private void OnDrawGizmos() {
        Vector3 origin = transform.position, normal = -transform.forward, up = transform.up;

        float forwardAngle = MathUtilities.DirToAngle(up);

        Vector3 leftLine = MathUtilities.AngToDir(fovHalfAng + forwardAngle);
        Vector3 rightLine = MathUtilities.AngToDir(-fovHalfAng + forwardAngle);

        Gizmos.DrawLine(origin, origin + leftLine);
        Gizmos.DrawLine(origin, origin + rightLine);
    }
}
