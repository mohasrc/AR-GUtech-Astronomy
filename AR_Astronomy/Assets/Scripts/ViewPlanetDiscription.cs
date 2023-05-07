using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewPlanetDiscription : MonoBehaviour
{
    [SerializeField] private List<ChangeActiveState> PlanetDescriptions;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.touchCount > 0) && (Input.GetTouch(0).phase == TouchPhase.Began))
        {
            Ray raycast = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit raycastHit;
            if (Physics.Raycast(raycast, out raycastHit))
            {
                Debug.Log("Something Hit");
                string nameHit = raycastHit.collider.name;
                switch (nameHit)
                {
                    case "Sun":
                        PlanetDescriptions[0].ChangeState();
                        break;
                    case "Mercury":
                        PlanetDescriptions[1].ChangeState();
                        break;
                    case "Venus":
                        PlanetDescriptions[2].ChangeState();
                        break;
                    case "Earth":
                        PlanetDescriptions[3].ChangeState();
                        break;
                    case "Mars":
                        PlanetDescriptions[4].ChangeState();
                        break;
                    case "Jupiter":
                        PlanetDescriptions[5].ChangeState();
                        break;
                    case "Saturn":
                        PlanetDescriptions[6].ChangeState();
                        break;
                    case "Uranus":
                        PlanetDescriptions[7].ChangeState();
                        break;
                    case "Neptune":
                        PlanetDescriptions[8].ChangeState();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
