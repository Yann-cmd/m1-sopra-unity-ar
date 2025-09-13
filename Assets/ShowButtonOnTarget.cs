using UnityEngine;

public class ShowButtonOnTarget : MonoBehaviour
{
    public GameObject uiButton;

    void Start()
    {
        if (uiButton != null)
            uiButton.SetActive(false); // bouton cach� au d�part
    }

    public void OnTargetFound()
    {
        Debug.Log("ImageTarget d�tect� !");
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
