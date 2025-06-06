using System;
using UnityEngine;

public class SplashScreenUIController : MonoBehaviour
{
    [SerializeField]
    public String animationName;
    [SerializeField]
    public float animationSpeed;
    private Animator animator;
    
    
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        animator.speed = (animationSpeed==0 ? 0.2f : animationSpeed);
        animator.Play(animationName);
    }
}