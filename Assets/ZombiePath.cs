using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ZombiePath
{

    public Transform[] path;
    
    public ZombiePath(Transform[] path)
    {
        this.path = path;
    }

    public Transform[] getPath()
    {
        return path;
    }
}
