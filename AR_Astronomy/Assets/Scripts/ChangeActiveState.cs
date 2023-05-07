using UnityEngine;

public class ChangeActiveState : MonoBehaviour
{
    [SerializeField] public bool isActive = false;

    private void Update()
    {
        gameObject.SetActive(isActive);
    }

    public void ChangeState()
    {
        if (isActive)
            isActive = false;
        else
            isActive = true;
    }
}
