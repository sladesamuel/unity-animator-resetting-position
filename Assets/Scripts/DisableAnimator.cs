using UnityEngine;

public class DisableAnimator : MonoBehaviour
{
    public Animator animator;

    public void OnClick()
    {
        animator.enabled = false;
    }
}
