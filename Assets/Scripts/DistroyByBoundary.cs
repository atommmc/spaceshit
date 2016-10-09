using UnityEngine;
using System.Collections;

public class DistroyByBoundary : MonoBehaviour
{
    private void OnTriggerExit(Collider other)
    {
        Destroy(other.gameObject);
    }
	
}
