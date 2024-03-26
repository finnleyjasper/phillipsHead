using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class Morbius : MonoBehaviour
{
    public NPCConversation myConversation;

    void Start()
    {
        StartCoroutine(MyCoroutine());
    }

    IEnumerator MyCoroutine ()
    {
        yield return new WaitForSeconds(3f);
        ConversationManager.Instance.StartConversation(myConversation);
        yield return new WaitForSeconds (3f);
        ConversationManager.Instance.EndConversation();
    }
}