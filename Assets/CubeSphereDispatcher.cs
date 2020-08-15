/*
CreateBy:     #AuthorName#
CreateTime:   #CreateTime#
Description:  
*/

using UnityEngine;

public enum CubeSphereEvent {
    Chat,
}

public class CubeSphereDispatcher : EventDispatcher<string, CubeSphereEvent>
{
    private CubeSphereDispatcher() {

    }
}
