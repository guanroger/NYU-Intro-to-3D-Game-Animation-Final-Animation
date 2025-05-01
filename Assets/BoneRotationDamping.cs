using UnityEngine;

public class BoneRotationDamping : MonoBehaviour
{
    public Transform sourceBone; // The target to follow
    [Range(0f, 1f)] public float rotationDamping = 0.1f;
    public bool useWorldSpace = true;

    void LateUpdate()
    {
        if (sourceBone == null) return;

        if (useWorldSpace)
        {
            Quaternion targetRot = sourceBone.rotation;
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRot, rotationDamping);
        }
        else
        {
            Quaternion targetRot = sourceBone.localRotation;
            transform.localRotation = Quaternion.Slerp(transform.localRotation, targetRot, rotationDamping);
        }
    }
}
