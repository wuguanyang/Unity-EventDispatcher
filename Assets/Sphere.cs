/*
CreateBy:     #AuthorName#
CreateTime:   #CreateTime#
Description:  
*/

using UnityEngine;

public class Sphere : MonoBehaviour
{
    void Start() {
        CubeSphereDispatcher.Instance.BroadCast(CubeSphereEvent.Chat,"你吃了吗");
    }
}
