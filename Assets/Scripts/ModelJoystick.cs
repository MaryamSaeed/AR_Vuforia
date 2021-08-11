using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelJoystick : MonoBehaviour
{
    public float Speed;
    public FixedJoystick JoyStick;
    public float TurnSpeed;
    private Rigidbody rigidBody;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void Update()
    {
        if (Mathf.Abs(JoyStick.Horizontal) > 0 && Mathf.Abs(JoyStick.Vertical) > 0)
        {
            var dir = new Vector3(JoyStick.Horizontal, 0,JoyStick.Vertical);
            transform.forward = dir.normalized;
            Vector3 movement = -transform.forward * Speed * Time.deltaTime;
            transform.localPosition = transform.localPosition + movement;
        }
    }
}
