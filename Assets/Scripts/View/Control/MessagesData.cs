using System;
using Sirenix.OdinInspector;
using Sirenix.Serialization;
using UnityEngine;

public class MessagesData : SerializedMonoBehaviour
{
    public MessageData[] SafeMessages;
    public MessageData[] ThreatMessages;
}

public class MessageData
{
    public string Title;
    [TextArea(4, 10)]
    public string Message;
    [TextArea(4, 10)]
    public string InformativeMessage;
    public Sprite Image;
}