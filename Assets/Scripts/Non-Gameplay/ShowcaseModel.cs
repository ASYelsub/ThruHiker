using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Put this script on an object you want to rotate and move slightly up and down.
public class ShowcaseModel : MonoBehaviour
{
    [Header("Rotation & Bounce")]
    GameObject rotateObject;
    Vector3 rotateVector;
    public float rotateSpeed;
    public float bounceSpeed;
    float timer = 0f;
    Vector3 initialPos;

    /*[Header("Materials")]
    public Material eyesSelectMat;
    public Material bodySelectMat;
    public Material hairSelectMat;
    public Material eyesMat;
    public Material bodyMat;
    public Material hairMat;

    [Header("Parts")]
    public GameObject body;
    public GameObject shirt;
    public GameObject pants;
    public GameObject boots;
    public GameObject eyes;
    public GameObject socks;
    public GameObject ears;
    public GameObject skullcap;*/

    bool isHighlighted;

    void Start()
    {
        
        rotateObject = gameObject;
        rotateVector = new Vector3(0, rotateSpeed);
        initialPos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
        //eyesMat = gameObject.GetComponentInChildren<Material>();
        isHighlighted = false;
    }

    void Update()
    {
       
       /* if (Input.GetKeyDown(KeyCode.F))
        {
            isHighlighted = !isHighlighted;
            ChangeMat();
        }*/
    }

    private void FixedUpdate()
    {
        timer += 1 * bounceSpeed;
        rotateObject.transform.Rotate(rotateVector);
        rotateObject.transform.localPosition = new Vector3(initialPos.x, initialPos.y + Mathf.Sin(timer) * bounceSpeed, initialPos.z);
    }

    /*private void OnMouseDown()
    {
        isHighlighted = true;
        ChangeMat();
    }

    void ChangeMat()
    {
        if (!isHighlighted)
        {
            body.GetComponent<SkinnedMeshRenderer>().material = bodySelectMat;
            shirt.GetComponent<SkinnedMeshRenderer>().material = bodySelectMat;
            pants.GetComponent<SkinnedMeshRenderer>().material = bodySelectMat;
            boots.GetComponent<SkinnedMeshRenderer>().material = bodySelectMat;
            eyes.GetComponent<SkinnedMeshRenderer>().material = eyesSelectMat;
            socks.GetComponent<SkinnedMeshRenderer>().material = bodySelectMat;
            ears.GetComponent<SkinnedMeshRenderer>().material = bodySelectMat;
            skullcap.GetComponent<SkinnedMeshRenderer>().material = hairSelectMat;
            skullcap.GetComponentInChildren<SkinnedMeshRenderer>().material = hairSelectMat;
        }
        else if (isHighlighted)
        {
            body.GetComponent<SkinnedMeshRenderer>().material = bodyMat;
            shirt.GetComponent<SkinnedMeshRenderer>().material = bodyMat;
            pants.GetComponent<SkinnedMeshRenderer>().material = bodyMat;
            boots.GetComponent<SkinnedMeshRenderer>().material = bodyMat;
            eyes.GetComponent<SkinnedMeshRenderer>().material = eyesMat;
            socks.GetComponent<SkinnedMeshRenderer>().material = bodyMat;
            ears.GetComponent<SkinnedMeshRenderer>().material = bodyMat;
            skullcap.GetComponent<SkinnedMeshRenderer>().material = hairMat;
            skullcap.GetComponentInChildren<SkinnedMeshRenderer>().material = hairMat;
        }
        
    }
    private void OnMouseExit()
    {
        isHighlighted = false;
        ChangeMat();
    }*/
}
