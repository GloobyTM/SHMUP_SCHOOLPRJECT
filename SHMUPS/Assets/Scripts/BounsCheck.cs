using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounsCheck : MonoBehaviour
{
    [Header("Set in Inspector")]
    public float radius = 1f;

    [Header("Set Dynamically")]
    public float camWidth;
    public float camLength;

    [SerializeField] private float horizontalBound;
    [SerializeField] private float topBound;
    [SerializeField] private float bottomBound;

    void Awake()
    {
        camLength = Camera.main.orthographicSize;
        camWidth = camLength * Camera.main.aspect;
    }

    void LateUpdate()
    {
        Vector3 pos = transform.position;

        pos.x = Mathf.Clamp(pos.x, -horizontalBound, horizontalBound);
        pos.z = Mathf.Clamp(pos.z, bottomBound, topBound);
        transform.position = pos;
    }
    void OnDrawGizmos()
    {
        //if (Application.isPlaying) return;
        //Vector3 boundSize = new Vector3(camWidth * 2, camLength * 2, 0.1f);

        //Gizmos.DrawWireCube(Vector3.zero, boundSize);
    }
}
