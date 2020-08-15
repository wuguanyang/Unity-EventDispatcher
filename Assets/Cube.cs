/*
CreateBy:     #AuthorName#
CreateTime:   #CreateTime#
Description:  
*/

using UnityEngine;

public class Cube : MonoBehaviour
{
    
    void Start() {
        CubeSphereDispatcher.Instance.AddListener(CubeSphereEvent.Chat, Listen);
    }


    void Listen(string context) {
        Debug.Log(string.Format("Sphere=>Cube:{0}",context));
    }
}
