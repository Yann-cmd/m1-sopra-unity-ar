using UnityEngine;

public class ShowButtonOnTarget : MonoBehaviour
{
    public GameObject uiButton;

    void Start()
    {
        if (uiButton != null)
            uiButton.SetActive(false); // bouton caché au départ
    }

    public void OnTargetFound()
    {
        Debug.Log("ImageTarget détecté !");
        if (uiButton != null)
            uiButton.SetActive(true);
    }

    public void OnTargetLost()
    {
        Debug.Log("ImageTarget perdu !");
        if (uiButton != null)
            uiButton.SetActive(false);
    }
}
