using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorAim : MonoBehaviour
{
    [SerializeField] private LayerMask layerMask;
    private void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out RaycastHit hitInfo, Mathf.Infinity, layerMask))
        {
            Vector3 direction = hitInfo.point - transform.position;
            direction.y = 0f;
            direction.Normalize();
            Quaternion rotation = Quaternion.LookRotation(direction, Vector3.up);
            transform.rotation = rotation;

        }
    }
}
