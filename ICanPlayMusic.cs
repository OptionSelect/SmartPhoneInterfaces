using System;
namespace SmartPhoneInterfaces
{
    interface ICanPlayMusic
    {
        string Song {get; set;}
        void TakePic();
        void SavePic();
        void EditPic();
    }
}