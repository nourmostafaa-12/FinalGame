using UnityEngine;

public class ButtonAnimator : MonoBehaviour
{
    public Animator buttonAnimator; // Reference to the Animator

    public void OnButtonClick()
    {
        // Trigger the "OnClick" trigger in the Animator
        buttonAnimator.SetTrigger("OnClick");
    }
}
