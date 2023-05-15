using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePlanet : MonoBehaviour
{
    public bool isActive = false;
    public GameObject panel;
    public bool show = false;

    float lastTapTime = 0;
    float doubleTapThreshold = 0.3f;

    // Start is called before the first frame update
    void Start()
    {
        show = false;
        panel.SetActive(show);
    }

    // Update is called once per frame
    void Update()
    {

        if (isActive)
        {
           
            if (Input.touchCount == 1)
            {
                Touch screenTouch = Input.GetTouch(0);

                if (screenTouch.phase == TouchPhase.Began)
                {
                    if (Time.time - lastTapTime <= doubleTapThreshold)
                    {
                        lastTapTime = 0;

                        show = true;
                        panel.SetActive(show);
                    }
                    else
                    {
                        lastTapTime = Time.time;

                 
                    }
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
