using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceDebug : MonoBehaviour
{
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.magenta;
        Gizmos.DrawLine(transform.position, transform.position + (transform.forward * 20));
        Gizmos.color = Color.cyan;
        Gizmos.DrawLine(transform.position, transform.position + (transform.forward * 12));
        Gizmos.color = Color.green;
        Gizmos.DrawLine(transform.position, transform.position + (transform.forward * 6));
    }
}
