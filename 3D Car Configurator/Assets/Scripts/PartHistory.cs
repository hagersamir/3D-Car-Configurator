using System.Collections.Generic;
using UnityEngine;

public class PartHistory : MonoBehaviour
{
    private List<System.Action> states = new List<System.Action>();
    private int index = -1;

  
    private System.Action originalState;

    // assign original reset ONLY for this part
    public void SetOriginalState(System.Action resetAction)
    {
        originalState = resetAction;
    }

    public void AddState(System.Action applyState)
    {
        if (index < states.Count - 1)
        {
            states.RemoveRange(index + 1, states.Count - index - 1);
        }

        states.Add(applyState);
        index++;
    }

    public void StepBack()
    {
        if (index <= 0)
        {
            index = -1;

            if (originalState != null)
                originalState.Invoke();

            return;
        }

        index--;
        states[index].Invoke();
    }
}