using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchPlanet : MonoBehaviour
{
    public bool isActive = false;
    public GameObject panel;
    public bool show = false;

    void Start()
    {
        show = false;
        panel.SetActive(show);
    }

    void Update()
    {
        if (isActive)
        {
            if (Input.touchCount == 1)
            {
                Touch screenTouch = Input.GetTouch(0);

                //tap to show description
                if (screenTouch.phase == TouchPhase.Began)
                {
                    show = true;
                    panel.SetActive(show);
                }

                //move finger to rotate the planet on its axis
                if (screenTouch.phase == TouchPhase.Moved)
                {
                    transform.Rotate(0f, screenTouch.deltaPosition.x, 0f);
                }
                if (screenTouch.phase == TouchPhase.Ended)
                {
                    isActive = false;
                }
            }
        }
    }
}
