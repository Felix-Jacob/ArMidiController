﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetInitialPostion : MonoBehaviour
{
    public GameObject Coordinates;
    public GameObject Modulator;

    void Start()
    {
        transform.position = Camera.main.transform.position + (Camera.main.transform.forward);
        Vector3 lookTarget = new Vector3(Camera.main.transform.position.x,
                                         transform.position.y,
                                         Camera.main.transform.position.z);
        transform.LookAt(lookTarget);

       //var meshOfCoordObj = Coordinates.GetComponent<MeshFilter>().mesh;
       //var newModPosInWorld = Coordinates.transform.TransformPoint(
       //    meshOfCoordObj.bounds.min + new Vector3(
       //    meshOfCoordObj.bounds.size.x, 0, 0));
       //Modulator.GetComponent<ModulatorScript>().NullPosModInWorld = newModPosInWorld;
    }
}