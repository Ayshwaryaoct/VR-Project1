using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour {

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("collision");
    }
}
