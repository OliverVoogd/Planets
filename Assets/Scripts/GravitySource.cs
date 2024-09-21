using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravitySource : MonoBehaviour
{
    [SerializeField, Min(0f)]
    protected float mass = 1000f; // kg

    public virtual Vector3 GetGravity(Vector3 position) {
        return Physics.gravity;
    }

    protected void OnEnable() {
        GravityManager.Register(this);
    }
    protected void OnDisable() {
        GravityManager.Unregister(this);
    }
}
