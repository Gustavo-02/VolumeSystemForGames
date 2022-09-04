using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Volume : MonoBehaviour
{
    public float volumeMestre, volumeDia, volumeMusica;
    public Slider sliderMestre, sliderDialogo, sliderMusica;

    void Start()
    {
        PlayerPrefs.SetFloat("Mestre", 1);
        PlayerPrefs.SetFloat("Dialogo", 1);
        PlayerPrefs.SetFloat("Musica", 1);
        sliderMestre.value = PlayerPrefs.GetFloat("Mestre");
        sliderDialogo.value = PlayerPrefs.GetFloat("Dialogo");
        sliderMusica.value = PlayerPrefs.GetFloat("Musica");
        
    }

    public void VolumeMestre(float volume)
    {
        volumeMestre = volume;
        AudioListener.volume = volumeMestre;

        PlayerPrefs.SetFloat("Mestre", volumeMestre);
    }

    public void VolumeDialogo(float volume)
    {
        volumeDia = volume;
        GameObject[] diag = GameObject.FindGameObjectsWithTag("Dialogo");
        for(int i=0; i<diag.Length; i++)
        {
            diag[i].GetComponent<AudioSource>().volume = volumeDia;
        }

        PlayerPrefs.SetFloat("Dialogo", volumeDia);
    }

    public void VolumeDaMusica(float volume)
    {
        volumeMusica = volume;
        GameObject[] Musicas = GameObject.FindGameObjectsWithTag("Musica");
        for(int i=0; i<Musicas.Length; i++)
        {
            Musicas[i].GetComponent<AudioSource>().volume = volumeMusica;
        }

        PlayerPrefs.SetFloat("Musica", volumeMusica);
    }

}
