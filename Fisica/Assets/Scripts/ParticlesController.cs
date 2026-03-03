using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ParticlesController : MonoBehaviour
{
    [Header("Properties")]
    [SerializeField] int systemParticlesNumber;
    [SerializeField] int systemInitialSpeed;
    [SerializeField] int systemInitialAngle;
    [SerializeField] float systemLifeTime;
    [SerializeField] float systemGravity;

    [SerializeField] GameObject Particle;
    List<GameObject> particles = new();

    private void Start()
    {

    }

    void CreateParticleExplotion()
    {
        Debug.Log("Hola");
    }

    void UpdateParticlePosition(Particle p, float time)
    {

    }

    public void OnPress(InputAction.CallbackContext context)
    {
        CreateParticleExplotion();

        for (int i = 0; i < systemParticlesNumber; i++)
        {
            
        }
    }
}