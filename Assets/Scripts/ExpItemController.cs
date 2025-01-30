using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ExpItemController : MonoBehaviour
{
    [SerializeField]
    private Button expItemButton;
    
    
    // Start is called before the first frame update
    void Start()
    {
        expItemButton.onClick.AddListener(onExpItemButtonClickListener);
    }

    private void onExpItemButtonClickListener()
    {
        SceneManager.LoadScene("DigitizeCollecting");
    }
}