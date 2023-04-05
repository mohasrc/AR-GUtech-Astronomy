using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitMove : MonoBehaviour
{
    Vector3 initpos;
    public Transform objectTransform;
    public Ellipse orbitPath;

    [Range(0f, 1f)]
    public float orbitProgress = 0f;
    public float orbitPeriod = 3f;
    public bool orbitActive = false;
    float orbitSpeed;

    // Start is called before the first frame update
    void Start()
    {
        //orbitActive = false;
        if (objectTransform == null)
        {
            orbitActive = false;
            return;
        }
        initpos = transform.localPosition;
        if (orbitPeriod < 0.1f)
        {
            orbitPeriod = 0.1f;
        }
    }

    void Update()
    {
        if (orbitActive)
        {
            orbitSpeed = 1f / orbitPeriod;
            orbitProgress += Time.deltaTime * orbitSpeed;
            orbitProgress %= 1f;
            SetOrbitObjPos();
        }
        else
        {
            orbitActive = false;
            objectTransform.localPosition = initpos;
            orbitProgress = 0;
        }
    }

    void SetOrbitObjPos()
    {
        Vector2 orbitPos = orbitPath.Evaluate(orbitProgress);
        objectTransform.localPosition = new Vector3(orbitPos.x, 0, orbitPos.y);
    }

    public void SetOrbitState(bool state)
    {
        orbitActive = state;
    }
}
