using UnityEngine;

public class AxisRotate : MonoBehaviour
{
    public float speed = 1f;
    public bool rotate = true;
    // Update is called once per frame
    void Update()
    {
        if (rotate)
        {
            Vector3 direction = new Vector3(0, Time.deltaTime * speed, 0);
            direction.Normalize();
            transform.Rotate(direction * speed);
        }
    }

    public void RotateState(bool enable)
    {
        rotate = enable;
    }
}