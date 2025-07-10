using UnityEngine;

public class DismemberOnClick : MonoBehaviour
{
    [SerializeField] private PlayerInputsSO playerInputs;

    private void RayCast()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out RaycastHit hitInfo))
        {
            if (hitInfo.collider.TryGetComponent(out Dismemberable dismemberable))
                dismemberable.Dismember();
        }
    }

    private void OnEnable()
    {
        playerInputs.OnLeftClickPressed += RayCast;
    }
    
    private void OnDisable()
    {
        playerInputs.OnLeftClickPressed -= RayCast;
    }
}
