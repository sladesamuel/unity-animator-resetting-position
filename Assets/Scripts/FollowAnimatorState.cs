using UnityEngine;

public class FollowAnimatorState : MonoBehaviour
{
    public Animator animator;
    public TMPro.TextMeshProUGUI debugText;

    void Update()
    {
        string state = animator.enabled ? "enabled" : "disabled";
        debugText.text = $"Animator is {state}";
    }
}
