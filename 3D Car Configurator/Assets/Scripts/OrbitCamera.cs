using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System.Collections.Generic;

public class OrbitCamera : MonoBehaviour
{
    public Transform target;
    private float distance = 5f;

    private float rotationSpeed = 200f;
    private float zoomSpeed = 2f;

    public float minDistance = 1f;
    public float maxDistance = 10f;

    private float x = 0f;
    private float y = 20f;

    void LateUpdate()
    {
        if (target == null) return;
        if (IsPointerOverUIOrScrollRect())
            return;

        if (Input.GetMouseButton(0))
        {
            x += Input.GetAxis("Mouse X") * rotationSpeed * Time.deltaTime;
            y -= Input.GetAxis("Mouse Y") * rotationSpeed * Time.deltaTime;
        }

        y = Mathf.Clamp(y, -20f, 80f);

        float scroll = Input.GetAxis("Mouse ScrollWheel");
        distance -= scroll * zoomSpeed;
        distance = Mathf.Clamp(distance, minDistance, maxDistance);

        Quaternion rotation = Quaternion.Euler(y, x, 0);
        Vector3 position = target.position - (rotation * Vector3.forward * distance);

        transform.rotation = rotation;
        transform.position = position;
    }

    
    bool IsPointerOverUIOrScrollRect()
    {
        if (EventSystem.current == null)
            return false;

        PointerEventData eventData = new PointerEventData(EventSystem.current);
        eventData.position = Input.mousePosition;

        List<RaycastResult> results = new List<RaycastResult>();
        EventSystem.current.RaycastAll(eventData, results);

        foreach (var r in results)
        {
            // any UI element OR ScrollRect blocks camera
            if (r.gameObject.GetComponentInParent<ScrollRect>() != null)
                return true;

            if (r.gameObject.layer == LayerMask.NameToLayer("UI"))
                return true;
        }

        return false;
    }
}