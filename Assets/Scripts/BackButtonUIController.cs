using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BackButtonUIController : MonoBehaviour
{
    [SerializeField]
    private Button photocameraButton;
    
    
    // Start is called before the first frame update
    void Start()
    {
        photocameraButton.onClick.AddListener(onPhotocameraButtonClickListener);
    }

    private void onPhotocameraButtonClickListener()
    {
        SceneManager.LoadScene("HomeScene");
    }
}