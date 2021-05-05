using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.TryGetComponent(out PlatformSegment platformSegment))
        {
            if(other.transform.parent != null)
                other.GetComponentInParent<Platform>().Break();
        }
    }
}
