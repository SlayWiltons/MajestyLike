using UnityEngine;

public class TaxCollectorStateMachine : MonoBehaviour
{
    [SerializeField]private Character character;

    private BaseState currentState;

    public void SetState(BaseState state)
    {
        currentState = state;
        state.OnStateStart(character);
    }
}
