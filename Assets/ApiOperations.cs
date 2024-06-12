using System.Threading.Tasks;
using TMPro;
using UnityEngine;
using UnityEngine.Networking;
[System.Serializable]
public class ApiOperations : MonoBehaviour
{
    public UserInput userinput;
    public TextMeshProUGUI displayTextregion;
    public TextMeshProUGUI displayTextlat;
    public TextMeshProUGUI displayTextlon;
    public TextMeshProUGUI displayTextlocaltime;
    public TextMeshProUGUI displayTexttzid;
    public TextMeshProUGUI displayTextname;
    public TextMeshProUGUI displayTextConditiontext;
    public GameObject tree;
    public GameObject treetwo;
    public GameObject treethree;
    public ButtonInput buttoninput;

    // [ContextMenu("Test Get")]
    public async void TestGet()
    {
        var text = GetComponent<ButtonInput>().inputfield.text;
        Debug.Log(text);

        string userInputI = userinput.input;
        string url = "http://api.weatherapi.com/v1/current.json?key=a1f67bd335834eb4b88100433242305&q=" + userInputI;
        Debug.Log(userInputI);
        using UnityWebRequest www = UnityWebRequest.Get(url);
        www.SetRequestHeader("Content-Type", "application/json");
        var operation = www.SendWebRequest();
        while (!operation.isDone)
            await Task.Yield();
        if (www.result == UnityWebRequest.Result.Success)
        {
            //var data = JsonUtility.FromJson<ApiOperations>(www.downloadHandler.text);
            string responsBody = www.downloadHandler.text;
            //Debug.Log(responsBody);
            JsonData jsonData = new();
            jsonData = JsonUtility.FromJson<JsonData>(responsBody);
            displayTextname.text = "Name: " + jsonData.location.name;
            displayTextregion.text = "Region: " + jsonData.location.region;
            displayTextlat.text = "Latitude: " + jsonData.location.lat;
            displayTextlon.text = "Longitude: " + jsonData.location.lon;
            displayTextlocaltime.text = "Local Time: " + jsonData.location.lon;
            displayTexttzid.text = "Time Zone ID: " + jsonData.location.lon;
            displayTextConditiontext.text = "How them clouds are :  " + jsonData.current.condition.text;
            if (jsonData.current.condition.text == "Partly cloudy")
            {
                var rigidbody1 = tree.GetComponent<Rigidbody>();
                var rigidbody2 = treetwo.GetComponent<Rigidbody>();
                var rigidbody3 = treethree.GetComponent<Rigidbody>();
                Rigidbody treerigidbody = rigidbody1;
                Rigidbody treerigidbody2 = rigidbody2;
                Rigidbody treerigidbody3 = rigidbody3;
                treerigidbody.isKinematic = false;
                treerigidbody2.isKinematic = false;
                treerigidbody3.isKinematic = false;
            }
        }
        else
        {
            Debug.Log($"Failed: {www.error}");
        }
    }
}
