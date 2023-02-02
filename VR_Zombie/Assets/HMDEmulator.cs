using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HMDEmulator : MonoBehaviour
{
    private Transform camTr;
    public float yawSpeed = 3.0f;
    public float pitchSpeed = 3.0f;

    void Start()
    {
        camTr = GetComponent<Transform>();
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.LeftAlt))
        {
            Vector3 rot = camTr.localEulerAngles + new Vector3(-Input.GetAxis("Mouse Y") * pitchSpeed, Input.GetAxis("Mouse X") * yawSpeed, 0);
            camTr.localRotation = Quaternion.Euler(rot);
        }
    }
}
