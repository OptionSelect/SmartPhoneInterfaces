using System;

namespace SmartPhoneInterfaces
{
    public class SmartPhone : ICanText, ICanTakePics, ICanPlayMusic
    {
        public string TextMessage { get; set; }
        public string Pic { get ; set ; }
        public string Song { get; set ; }

        public void EditPic()
        {
             
        }

        public void ReceiveText()
        {
             
        }

        public void SavePic()
        {
             
        }

        public void SendImageMessage()
        {
             
        }

        public void SendText()
        {
             
        }

        public void TakePic()
        {
             
        }
    }

}