using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closeDesc : MonoBehaviour
{

    public GameObject panel;
    public bool show = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        show = false;
        panel.SetActive(show);
    }
}
