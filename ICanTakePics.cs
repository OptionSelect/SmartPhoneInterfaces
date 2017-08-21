using System;
namespace SmartPhoneInterfaces
{
    interface ICanTakePics
    {
        string Pic {get; set;}
        void TakePic();
        void SavePic();
        void EditPic();
    }
}