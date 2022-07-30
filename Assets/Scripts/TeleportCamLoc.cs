using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportCamLoc : MonoBehaviour
{
    public Transform xrRig;
    public Transform labStartPos;
    //public Transform head;
    //public Transform bodyTracker;
    [Header("Press T to teleport to this location")]
    public Transform startPos;
    public float desiredHeight;

    void Start()
    {
        xrRig.position = labStartPos.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T)){
            Vector3 tempPos = startPos.position;
            tempPos.y = Terrain.activeTerrain.SampleHeight(startPos.position) + desiredHeight;
            xrRig.position = tempPos;
        }
    }
}
