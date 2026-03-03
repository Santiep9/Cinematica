using UnityEngine;

public class Particle : MonoBehaviour
{
    [Header("Properties")]
    [SerializeField] int initialSpeed;
    [SerializeField] int initialAngle;
    [SerializeField] float maxLifeTime;
    [SerializeField] float activeTime;
    [SerializeField] float gravity;
}
