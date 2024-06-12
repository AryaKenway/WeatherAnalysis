using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonInput : MonoBehaviour
{
    public ApiOperations apioperations;
    public TMP_InputField inputfield;
    public GameObject tree;
    public GameObject treetwo;
    public GameObject treethree;
    public Button button;
    public void Start()
    {
       // Debug.Log(inputfield == null);
        if (inputfield != null)
        {
            inputfield.Select();
            inputfield.ActivateInputField();
            var rigidbody1 = tree.GetComponent<Rigidbody>();
            Rigidbody treerigidbody = rigidbody1;
            treerigidbody.isKinematic = true;
            var rigidbody2 = treetwo.GetComponent<Rigidbody>();
            Rigidbody treerigidbody2 = rigidbody2;
            treerigidbody2.isKinematic = true;
            var rigidbody3 = treethree.GetComponent<Rigidbody>();
            Rigidbody treerigidbody3 = rigidbody3;
            treerigidbody3.isKinematic = true;
        }
        else
            Debug.Log(" ");
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            apioperations.TestGet();
        }
    }
    /*public void OnTriggerEnter(Collider collision)
    {
        Debug.Log("Workng");

        if (collision.gameObject.CompareTag("UserInterface"))
        {
            SceneManager.LoadScene("UserInterface");
        }
    }
    */

}

