using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    protected Joystick joy;
    // Start is called before the first frame update
    void Start()
    {
        joy = FindObjectOfType<Joystick>();
}

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * joy.Vertical/10);
        transform.Translate(Vector3.right * joy.Horizontal / 10);
    }
}
