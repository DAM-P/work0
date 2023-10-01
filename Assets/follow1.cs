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

        // 上移位置
        Vector3 newPosition = new Vector3(currentPosition.x, currentPosition.y + yOffset, currentPosition.z);

        // 将 GameObject 移动到新的位置
        transform.position = newPosition;

    }
}
