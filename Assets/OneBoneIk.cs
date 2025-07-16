using UnityEngine;

// implements: https://zenn.dev/mogesystem/scraps/5ca77b2fe1be2b
public class OneBoneIk : MonoBehaviour
{
  public Transform bone;
  public Transform boneEnd;
  public Transform target;
  void Start(){}
  void Update()
  {
    var beforeDirection = boneEnd.position - bone.position;
    var afterDirection = target.position - bone.position;
    var delta = Quaternion.FromToRotation(beforeDirection, afterDirection);
    bone.rotation = delta * bone.rotation;
  }
}
