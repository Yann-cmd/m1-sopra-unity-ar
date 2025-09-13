using UnityEngine;

public class PlaneEngine : MonoBehaviour
{
    public ParticleSystem engineEffect;

    public void StartEngine()
    {
        if (engineEffect != null && !engineEffect.isPlaying)
        {
            engineEffect.Play();
        }
    }
}
