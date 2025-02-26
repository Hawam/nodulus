using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MessagePanel : MonoBehaviour
{
    public Image Image;
    public TMP_Text Title;
    public TMP_Text GameMessage;
    public TMP_Text InformativeMessage;

    public void Show(MessageData messageData)
    {
        Image.sprite = messageData.Image;
        Title.text = messageData.Title;
        GameMessage.text = messageData.Message;
        InformativeMessage.text = messageData.InformativeMessage;
        gameObject.SetActive(true);
        Canvas.ForceUpdateCanvases();
    }
}
