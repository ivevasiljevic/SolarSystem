using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAround : MonoBehaviour
{
    public GameObject rotationTarget;
    public int rotationSpeed;
    // Start is called before the first frame update
    void Start()
    {
        if(rotationTarget == null)
        {
            rotationTarget = this.gameObject;
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(rotationTarget.transform.position, rotationTarget.transform.up, rotationSpeed * Time.deltaTime);
    }
}
