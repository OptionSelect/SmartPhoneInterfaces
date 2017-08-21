using System;
namespace SmartPhoneInterfaces
{
    interface ICanPlayMusic
    {
        string Song {get; set;}
        void PlaySong();
        void ArtistName();
        void AlbumName();
    }
}