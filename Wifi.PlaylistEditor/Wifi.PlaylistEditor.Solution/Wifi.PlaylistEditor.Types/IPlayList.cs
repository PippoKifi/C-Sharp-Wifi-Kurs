using System;
using System.Collections.Generic;

namespace Wifi.PlaylistEditor.Types
{
    public interface IPlayList
    {
        string Autor { get; set; }
        int Count { get; }
        DateTime CreatedAt { get; }
        IEnumerable<IPlaylistItem> ItemList { get; }
        string Name { get; set; }
        TimeSpan PlayList_Duration { get; set; }
        Guid PlayListGuid { get; set; }

        void Add(IPlaylistItem ItemToAdd);
        void Add2(IPlaylistItem newItem);
        void Clear();
        void Dispose();
        void Load(IPlaylistItem ItemToAdd);
        TimeSpan PLayListDuration(Guid Playlist_Guid);
        void Remove();
        void Remove2(IPlaylistItem iItemToRemove);
        void RemoveAll();
        void Save();
    }
}