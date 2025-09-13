using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class ShowTextOnHold : MonoBehaviour
{
    public TextMeshPro textMesh;   // r�f�rence vers le texte au-dessus de l�avion
    public float holdThreshold = 0.3f; // temps minimum pour consid�rer un "maintien"

    private bool isHolding = false;
    private float holdTimer = 0f;

    void Start()
    {
        if (textMesh != null)
            textMesh.gameObject.SetActive(false);
    }

    void Update()
    {
        if (Mouse.current != null && Mouse.current.leftButton.isPressed)
        {
            Ray ray = Camera.main.ScreenPointToRay(Mouse.current.position.ReadValue());
            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                if (hit.transform == transform)
                {
                    holdTimer += Time.deltaTime;
                    if (holdTimer >= holdThreshold && !isHolding)
                    {
                        isHolding = true;
                        if (textMesh != null)
                            textMesh.gameObject.SetActive(true);
                    }
                }
            }
        }
        else
        {
            // Reset quand on rel�che le clic
            if (isHolding)
            {
                isHolding = false;
                if (textMesh != null)
                    textMesh.gameObject.SetActive(false);
            }
            holdTimer = 0f;
        }
    }
}

