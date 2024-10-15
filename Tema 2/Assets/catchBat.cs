using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class BatPositionFixer : MonoBehaviour
{
    private Vector3 initialPosition;
    private Quaternion initialRotation;

    private void Start()
    {
        initialPosition = transform.localPosition;
        initialRotation = transform.localRotation;
    }

    public void OnSelectEnter(XRBaseInteractor interactor)
    {
        transform.localPosition = initialPosition;
        transform.localRotation = initialRotation;
    }

    public void OnSelectExit(XRBaseInteractor interactor)
    {
    }
}
