using UnityEngine;
using UnityEngine.UI;

public class PlaneJetSound : MonoBehaviour
{
    public Button bouton;          // référence au bouton
    public AudioSource audioSource; // référence à l’AudioSource

    void Start()
    {
        // On ajoute l’événement OnClick
        bouton.onClick.AddListener(PlaySound);
    }

    void PlaySound()
    {
        audioSource.Play();
    }
}
