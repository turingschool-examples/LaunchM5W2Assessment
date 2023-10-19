namespace RecordCollection.Models
{
    public class AlbumViewModel
    {
        public Album Album { get; set; }
        public List<Album> RelatedAlbums { get; set; }
        public int RelatedAlbumsCount { get; set; }

        public bool IsModernAlbum()
        {
            if (Album.ReleaseDate.Year > 2000)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
