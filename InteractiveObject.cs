using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveObject : MonoBehaviour
{
    public float radius = 3f;//��˹����С��Ҫ���С���ͧ���
    public Transform player;
    public Transform interactItem;
    bool hasInteract = false;//����Ҫ��ѹ�������

  

   
    void Update()
    {
        float distance = Vector3.Distance(player.position, interactItem.position);
        if (distance<=radius && !hasInteract)
        {
            hasInteract = true;
            Interact();
        }
    }
    public virtual void Interact()
    {
        Debug.Log("Item Active");
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(interactItem.position, radius);
    }
}
