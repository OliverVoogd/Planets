using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sun : GravitySource
{
    public override Vector3 GetGravity(Vector3 position) {
        Vector3 vector = transform.position - position;
        float distance = vector.magnitude;
        Vector3 direction = vector.normalized;

        float gravity = (Universe.G * mass) / (Mathf.Pow(distance, 2));
        return gravity * direction;
    }
}
