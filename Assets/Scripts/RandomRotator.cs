using UnityEngine;
using System.Collections;

public class RandomRotator : MonoBehaviour
{
    public float tuble;

    private void Start()
    {
        var astertics = GetComponent<Rigidbody>();
        astertics.angularVelocity = Random.insideUnitSphere * tuble;
    }
}
