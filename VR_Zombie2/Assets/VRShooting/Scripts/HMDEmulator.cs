using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HMDEmulator : MonoBehaviour
{
    private Transform camTr;
    public float yawSpeed = 3.0f;
    public float pitchSpeed = 3.0f;
    // Start is called before the first frame update
    void Start()
    {
        camTr = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftAlt))
        {
            Vector3 rot = camTr.localEulerAngles
                + new Vector3(-Input.GetAxis("Mouse Y") * pitchSpeed
                , Input.GetAxis("Mouse X") * yawSpeed
                , 0);
            camTr.localRotation = Quaternion.Euler(rot);
        }
    }
}
