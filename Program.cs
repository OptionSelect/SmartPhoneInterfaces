using System;

namespace SmartPhoneInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            var droid = new SmartPhone();
            droid.AlbumName();
            droid.ArtistName();
            droid.PlaySong();

            droid.SendImageMessage();
            droid.SendText();
            droid.ReceiveText();

            droid.TakePic();
            droid.EditPic();
            droid.SavePic();

        }
    }
}
