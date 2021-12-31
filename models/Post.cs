using pa3makeup.database;
using pa3makeup.interfaces;

namespace pa3makeup.models
{
    public class Post
    {
        public string Text {get; set;}

        public DateOnly Date {get; set;}

        public ISavePost Save {get; set;}

        public Post()
        {
            Save = new SavePost();
        }
    }
}