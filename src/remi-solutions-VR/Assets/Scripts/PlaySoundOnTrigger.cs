using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundOnTrigger : MonoBehaviour
{
    
    private AudioSource _audioSource;

    private void Awake()
    {
        // Obtém o componente AudioSource do objeto
        _audioSource = GetComponent<AudioSource>();
        if (_audioSource == null)
        {
            Debug.LogError("AudioSource não encontrado! Adicione um AudioSource ao objeto.");
        }
    }

    // Evento chamado quando outro objeto entra no trigger
    private void OnTriggerEnter(Collider other)
    {
        // Verifica se há um AudioSource e reproduz o som
        if (_audioSource != null)
        {
            _audioSource.Play();
        }
    }

    void Start()
    {
        
    }
    
    void Update()
    {
        
    }
}
