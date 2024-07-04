using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonController : MonoBehaviour
{
    GameObject tempNote;

    bool isNote;

    // Start is called before the first frame update
    void Start()
    {
        isNote = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        isNote = true;

        tempNote = collision.gameObject;

        Debug.Log("Entrou");
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (isNote)
        {
            Destroy(tempNote);
            isNote = false;
            GameManager.Instance.AddScore(-1);
            Debug.Log("Saiu");
        }
    }

    private void OnMouseDown()
    {
        if (isNote)
        {
            isNote = false; 
            GameManager.Instance.AddScore(1);
            Destroy(tempNote);
            Debug.Log("Acertou");
        }
        else
        {
            GameManager.Instance.AddScore(-1);
            Debug.Log("Errou");
        }
    }
}
