using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayPanSound : MonoBehaviour
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
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
