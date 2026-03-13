using UnityEngine;

public class Particle : MonoBehaviour
{
    [Header("Properties")]
    public float initialSpeed;
    public float initialAngle;
    public float maxLifeTime;
    public float activeTime;
    public float gravity;

    public Vector3 startPosition;
}