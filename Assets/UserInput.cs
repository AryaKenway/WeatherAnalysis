using UnityEngine;

public class UserInput : MonoBehaviour
{
    public string input;
    //[field:SerializeField] public TMP_InputField inputTMP;

    /* private void Start()
     {
         var text= inputTMP.text;
     }
    */
    public void ReadStringInput(string s)

    {
        input = s;
       // Debug.Log(input);
    }
}
