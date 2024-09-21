using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GravityManager
{
    public static List<GravitySource> sources = new List<GravitySource>();

    public static Vector3 GetGravity(Vector3 position) {
        Vector3 g = Vector3.zero;
        for (int i = 0; i < sources.Count; i++) {
            g += sources[i].GetGravity(position);
        }
        return g;
    }

    public static void Register(GravitySource gBody) {
        sources.Add(gBody);
    }
    public static void Unregister(GravitySource gBody) {
        sources.Remove(gBody);
    }
}
