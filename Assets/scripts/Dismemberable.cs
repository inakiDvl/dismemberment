using System.Collections.Generic;
using UnityEngine;

public class Dismemberable : MonoBehaviour
{
    [SerializeField] private bool dismember = false;
    [SerializeField] private Rigidbody body;
    [SerializeField] private Dismemberable dismemberableChild;

    private bool dismembered;

    public void Dismember()
    {
        if (dismembered)
            return;

        gameObject.SetActive(false);
        body.gameObject.SetActive(true);

        body.transform.parent = null;
        Vector3 randomForce = Random.onUnitSphere * Random.Range(1f, 2f);
        body.AddForce(randomForce, ForceMode.Impulse);

        if (dismemberableChild)
            dismemberableChild.Dismember();

        dismembered = true;
    }

    private void Awake()
    {
        body.gameObject.SetActive(false);    
    }

    private void Update()
    {
        if (dismember)
        {
            dismember = false;
            Dismember();
        }
    }
}
