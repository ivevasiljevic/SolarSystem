using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeLookAtTarget : MonoBehaviour
{
    public GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        if(target == null)
        {
            target = this.gameObject;
        }
    }

    private void OnMouseDown()
    {
        Camera.main.gameObject.GetComponent<LookAtTarget>().target = target;
        Camera.main.fieldOfView = 60 * target.transform.localScale.x;
    }
}
