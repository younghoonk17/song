using System.Collections.Generic;


namespace song
{
    public class Song
    {
        public int number { get; set; }
        public string title { get; set; }
        public List<Verse> verse;
    }
}
