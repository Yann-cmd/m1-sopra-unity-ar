using UnityEngine;
using UnityEngine.UI;

public class PlaneJetSound : MonoBehaviour
{
    public Button bouton;          // r�f�rence au bouton
    public AudioSource audioSource; // r�f�rence � l�AudioSource

    void Start()
    {
        // On ajoute l��v�nement OnClick
        bouton.onClick.AddListener(PlaySound);
    }

    void PlaySound()
    {
        audioSource.Play();
    }
}
