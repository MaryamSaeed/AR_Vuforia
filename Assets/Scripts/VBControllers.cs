using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VBControllers : MonoBehaviour
{
    public GameObject Model;
    public  List<VirtualButtonBehaviour> VBs;
    private Vector3 initialPos;
    private Vector3 initialScale;
    private Quaternion initialRotation;
    private Vector3 scaleFactor = new Vector3(0.1f, 0.1f, 0.1f);
    private bool ScaleUP = false;
    private float timelaps = 0;
    // Start is called before the first frame update
    private void Start()
    {
        for (int i = 0; i < VBs.Count; i++)
        {
            VBs[i].RegisterOnButtonPressed(OnButtonPressed);
            VBs[i].RegisterOnButtonReleased(OnButtonReleased);
        }
    }
    private void Update()
    {
        if (ScaleUP)
        {
            timelaps += Time.deltaTime;
            Model.transform.localScale = Model.transform.localScale + (scaleFactor* timelaps);
        }
    }
    private void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        if (vb.VirtualButtonName == "ScaleUp")
        {
            ScaleUP = true;
        }
        else
        {
            Model.transform.localScale = initialScale;
            Model.transform.localPosition = initialPos;
            Model.transform.localRotation = initialRotation;
        }
    }
    private void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        if (vb.VirtualButtonName == "ScaleUp")
        {
            ScaleUP = false;
            timelaps = 0;
        }
    }
    public void ModelActive()
    {
        initialPos = Model.transform.localPosition;
        initialScale = Model.transform.localScale;
        initialRotation = Model.transform.localRotation;
    }
}
