using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemRotationHandler : MonoBehaviour
{
    public float rotationSpeed;
    void Start()
    {
        rotationSpeed = 50f;
        Invoke("destroy", 20f);
    }

    private void destroy()
    {
        Destroy(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, rotationSpeed * Time.deltaTime, 0f, Space.Self);
    }
}
