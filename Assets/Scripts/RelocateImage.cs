using UnityEngine;

public class RelocateImage : MonoBehaviour
{
    public Vector3 targetPosition;
    public GameObject image;

    public void OnClick()
    {
        image.transform.localPosition = targetPosition;
    }
}
