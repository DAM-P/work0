using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow1 : MonoBehaviour
{
    public float yOffset=0f;
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {   
        Transform parentTransform = transform.parent;
        
        Vector3 currentPosition =  parentTransform.position;

        // ����λ��
        Vector3 newPosition = new Vector3(currentPosition.x, currentPosition.y + yOffset, currentPosition.z);

        // �� GameObject �ƶ����µ�λ��
        transform.position = newPosition;

    }
}
