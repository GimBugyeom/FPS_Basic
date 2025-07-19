using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField] GameObject buliet;
    [SerializeField] Animator animator;
    [SerializeField] float GunSpeed;
    void Update()
    {
        HandleFire();
    }

    private void HandleFire()
    {
        if (Input.GetMouseButtonDown(1)) 
        {
            Fire();
        }
    }

    private void Fire()
    {
     
        if (animator != null)
        {
            animator.ResetTrigger("Shoot");
            animator.SetTrigger("Shoot");
        }

        Buliet instance = Instantiate(buliet, transform.position, Quaternion.identity)
            .GetComponent<Buliet>();
        instance.BulietSpeed = GunSpeed;
        Camera cam = Camera.main;
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        instance.transform.forward = ray.direction;


        
    }
}

