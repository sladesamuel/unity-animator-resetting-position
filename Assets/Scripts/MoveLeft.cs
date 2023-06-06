using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public Animator animator;

    public void OnClick()
    {
        animator.SetTrigger("MoveLeft");
    }
}
