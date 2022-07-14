using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (gameObject.CompareTag("mushroom"))
        {
            transform.Rotate(0f, 0f, 70 * Time.deltaTime, Space.Self);
        }
        else
        {
            transform.Rotate(0f, 70 * Time.deltaTime, 0f, Space.Self);
        }
    }
}
