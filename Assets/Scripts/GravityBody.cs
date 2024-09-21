using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class GravityBody : GravitySource
{
    [SerializeField, Min(0f)]
    private float radius = 10f;
    [SerializeField]
    private Vector3 initialVelocity = Vector3.zero;

    private float G;
    private Rigidbody body;
    [SerializeField]
    private Vector3 velocity;

    private void Awake() {
        G = Universe.G;
        body = GetComponent<Rigidbody>();
        velocity = initialVelocity;
        body.velocity = velocity;
    }

    private void FixedUpdate() {
        AdjustVelocity();

        // do some stuff with velocity before here
        body.velocity = velocity;
    }

    private void AdjustVelocity() {
        velocity = body.velocity;
        velocity += GravityManager.GetGravity(transform.position);
    }

    public override Vector3 GetGravity(Vector3 position) {
        Vector3 vector = transform.position - position;
        float distance = vector.magnitude - radius;
        Vector3 direction = vector.normalized;

        float gravity = (G * mass) / Mathf.Pow(distance, 2);
        return gravity * direction;
    }
}
