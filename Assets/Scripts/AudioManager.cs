using UnityEngine;
using UnityEngine; Audio;
using UnityEngine; UI;

public class AudioManager : MonoBehaviour
{

    [SerializeField]
    private AudioMixer audioMixer;

    [SerializeField]
    private Slider glissiereVolumeMusique


    void Start()
    {
        
        //audioMixer.GetFloat("MusiqueVolume");
        //audioMixer.SetFloat("MusiqueVolume", -20f);

    }

    public void AjusteVolumeMusique(float volume){
        audioMixer.SetFloat("MusiqueVolume", ConvertToLogarithmique(volume));
    }

    private float ConvertToLogarithmique(float volume){
        return Mathf.Log10(volume) * 20;
    }

}
