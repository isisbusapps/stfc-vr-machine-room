﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class FlashLightGrab : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<VRTK_InteractableObject>().InteractableObjectGrabbed += new InteractableObjectEventHandler(flashlightGrabbed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void flashlightGrabbed (object sender, InteractableObjectEventArgs e) {
        this.GetComponent<Rigidbody>().isKinematic = true;
    }
}
