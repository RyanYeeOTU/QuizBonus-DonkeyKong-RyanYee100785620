using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrelScript : MonoBehaviour
{
    GameObject Barrel;
    Rigidbody rigidBodyBarrel;
    public Transform barrelPos;
    // Start is called before the first frame update
    void Start()
    {
        rigidBodyBarrel = GetComponent<Rigidbody>();


    }

    // Update is called once per frame
    void Update()
    {
        rigidBodyBarrel.maxLinearVelocity=(1f);
    }
}
