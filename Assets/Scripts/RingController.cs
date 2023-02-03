using UnityEngine;

public class RingController : MonoBehaviour
{
    private Rigidbody[] _childs;

    private float _explosionForce = 390;
    private float _explosionRadius = 100;

    void Start()
    {
        _childs = GetComponentsInChildren<Rigidbody>();
    }

    public void DestroyRing()
    {
        for (int i = 0; i < _childs.Length; i++)
        {
            _childs[i].isKinematic = false;
            _childs[i].useGravity = true;

            _childs[i].AddExplosionForce(_explosionForce, transform.position, _explosionRadius);

            Destroy(gameObject, 2);
        }
    }
}
