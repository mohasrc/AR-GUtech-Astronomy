using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePlanet : MonoBehaviour
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

                if (screenTouch.phase == TouchPhase.Began)
                {
                
                    show = true;
                    panel.SetActive(show);
                
                }

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
