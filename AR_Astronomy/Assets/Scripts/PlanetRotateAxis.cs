using UnityEngine;
using UnityEngine.UI;

public class PlanetRotateAxis : MonoBehaviour
{
    // speed of rotation
    public float speed = 1.0f;

    // Check box used to controle if Planet Axis Rotation is on
    public Toggle rotatePlanet;

    // Update is called once per frame
    void Update()
    {
        if (rotatePlanet.isOn)
        {
            Vector3 direction = new Vector3(0, Time.deltaTime * speed, 0);
            direction.Normalize();
            transform.Rotate(direction/**speed*/);
        }
    }
}
