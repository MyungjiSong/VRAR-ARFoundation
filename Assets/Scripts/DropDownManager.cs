using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class DropDownManager : MonoBehaviour
{
    ARFaceManager arFaceManager;
    public Material[] materials;

    // Start is called before the first frame update
    public void ChangeFaceMaterial(int val)
    {
        arFaceManager = GetComponent<ARFaceManager>();
        if (val == 0)
        {
            arFaceManager.facePrefab.GetComponent<MeshRenderer>().material = materials[0];
        }
        else if (val == 1)
        {
            arFaceManager.facePrefab.GetComponent<MeshRenderer>().material = materials[1];
        }
        else if (val == 2)
        {
            arFaceManager.facePrefab.GetComponent<MeshRenderer>().material = materials[2];
        }
        else if (val == 3)
        {
            arFaceManager.facePrefab.GetComponent<MeshRenderer>().material = materials[3];
        }
        else if (val == 4)
        {
            arFaceManager.facePrefab.GetComponent<MeshRenderer>().material = materials[4];
        }
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
