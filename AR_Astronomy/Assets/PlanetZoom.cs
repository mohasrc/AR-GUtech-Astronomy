using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem.HID;

public class PlanetZoom : MonoBehaviour
{
    private GameObject clickedObject;
    private Transform originalTransform;

    private void Update()
    {
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                clickedObject = hit.collider.gameObject;
                originalTransform = clickedObject.transform;
                clickedObject.transform.localScale = new Vector3(3, 3, 3);
                
            }

            clickedObject.transform.localScale =originalTransform.localScale;

        }
        

    }

}
