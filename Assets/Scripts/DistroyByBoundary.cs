using UnityEngine;
using System.Collections;

public class DistroyByBoundary : MonoBehaviour
{
    void OnTriggerExit(Collider other)
    {
        Destroy(other.gameObject);
    }
	
}
