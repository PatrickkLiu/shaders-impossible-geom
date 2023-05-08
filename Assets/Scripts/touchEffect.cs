using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class touchEffect : MonoBehaviour
{
    // Start is called before the first frame update
    MeshRenderer meshRenderer;
    Color OriginalColor;
    [ColorUsage(true, true)]
    public Color hitColor;
    public AudioClip[] harps;
    private AudioClip harp;
    private void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        OriginalColor = meshRenderer.material.GetColor("_EmissionColor");

    }
    void OnTriggerEnter(Collider coll)
    {
        if (coll.CompareTag("Hand"))
        {
            meshRenderer.material.DOColor(hitColor, "_EmissionColor", 0.1f).OnComplete(() => meshRenderer.material.DOColor(OriginalColor, "_EmissionColor", 6f));
            int index = Random.Range(0, harps.Length);
            harp = harps[index];
            this.GetComponent<AudioSource>().PlayOneShot(harp);
        }
        
    }
}
