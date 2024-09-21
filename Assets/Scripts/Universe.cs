using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Universe : MonoBehaviour
{
    [SerializeField, Range(0f, 20f)]
    public float time = 1.0f;
    [SerializeField, Range(0f, 0.05f)]
    public static float G = 0.005f;

    private void OnValidate() {
        Time.timeScale = time;
    }
}
