using UnityEngine;

public class PlanetRotateAxis : MonoBehaviour
{
    // speed of rotation
    public float speed = 1.0f;

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = new Vector3(0, Time.deltaTime*speed, 0);
        direction.Normalize();
        transform.Rotate(direction/**speed*/);
    }
}
