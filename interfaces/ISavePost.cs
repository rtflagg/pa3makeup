using pa3makeup.models;

namespace pa3makeup.interfaces
{
    public interface ISavePost
    {
         public void CreatePost(Post myPost);

         public void SavePost(Post myPost);
    }
}