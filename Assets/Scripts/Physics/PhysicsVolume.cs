using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsVolume : MonoBehaviour
{
    [SerializeField] protected List<PhysicsVolumeAttribute> _attributes = new List<PhysicsVolumeAttribute>();
    public List<PhysicsVolumeAttribute> Attributes => _attributes;

}

[Serializable]
public struct PhysicsVolumeAttribute
{
    public ForceType ForceType;
    public float X, Y;

    public PhysicsVolumeAttribute(ForceType type, float x, float y)
    {
        ForceType = type;
        X = x;
        Y = y;
    }
}
     

public enum ForceType
{
    ADDFORCE = 0,
    ADDDRAG = 1,
    ATTRACTREPEL = 2,
}
