using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace Lab4
{
    [DataContract]
    public class PostTypeDTO
    {
        [DataMember]
        public short PostTypeID { get; set; }
        [DataMember]
        public string PostTypeName { get; set; }
    }

    [DataContract]
    public class PostDTO
    {
        [DataMember]
        public int PostID { get; set; }
        [DataMember]
        public string PostHeader { get; set; }
        [DataMember]
        public string PostText { get; set; }
        [DataMember]
        public short PostTypeID { get; set; }
    }
    public class BlogService : IBlogService
    {
        public IEnumerable<PostTypeDTO> GetPostTypes()
        {
            using (var dataContext = new WCFServiceDataContext())
            {
                var list = new List<PostTypeDTO>();
                foreach (var pt in dataContext.PostType)
                {
                    list.Add(new PostTypeDTO() { PostTypeID = pt.PostTypeID, PostTypeName = pt.PostTypeName });
                }
                return list;
            }
        }

        public PostTypeDTO GetPostType(string postTypeId)
        {
            using (var dataContext = new WCFServiceDataContext())
            {
                var pt = dataContext.PostType.FirstOrDefault(a => a.PostTypeID.ToString() == postTypeId);
                if(pt != null)
                {
                    return new PostTypeDTO() { PostTypeID = pt.PostTypeID, PostTypeName = pt.PostTypeName };
                }

                return null;
            }
        }
        public int AddPostType(string postTypeName)
        {
            using (var dataContext = new WCFServiceDataContext())
            {
                var pt = dataContext.PostType.FirstOrDefault(a => a.PostTypeName == postTypeName);
                if (pt == null)
                {
                    pt = new PostType();
                    pt.PostTypeName = postTypeName;
                    dataContext.PostType.InsertOnSubmit(pt);
                    dataContext.SubmitChanges();
                    return pt.PostTypeID;
                }

                return -1;
            }
        }
        public void UpdatePostType(string postTypeId, string postTypeName)
        {
            using (var dataContext = new WCFServiceDataContext())
            {
                var pt = dataContext.PostType.FirstOrDefault(a => a.PostTypeID.ToString() == postTypeId);
                if (pt != null)
                {
                    pt.PostTypeName = postTypeName;
                    dataContext.SubmitChanges();
                }
            }
        }

        public void DeletePostType(string postTypeId)
        {
            using (var dataContext = new WCFServiceDataContext())
            {
                var pt = dataContext.PostType.FirstOrDefault(a => a.PostTypeID.ToString() == postTypeId);
                if (pt != null)
                {
                    dataContext.PostType.DeleteOnSubmit(pt);
                    dataContext.SubmitChanges();
                }
            }
        }

        public IEnumerable<PostDTO> GetPosts()
        {
            using (var dataContext = new WCFServiceDataContext())
            {
                var list = new List<PostDTO>();
                foreach (var p in dataContext.Post)
                {
                    list.Add(new PostDTO() { PostHeader = p.PostHeader, PostID = p.PostID, PostText = p.PostText, PostTypeID = p.PostTypeID });
                }
                return list;
            }
        }

        public PostDTO GetPost(string postId)
        {
            using (var dataContext = new WCFServiceDataContext())
            {
                var p = dataContext.Post.FirstOrDefault(a => a.PostID.ToString() == postId);
                if(p != null)
                {
                    return new PostDTO() { PostHeader = p.PostHeader, PostID = p.PostID, PostText = p.PostText, PostTypeID = p.PostTypeID };
                }

                return null;
            }
        }

        public int AddPost(string postHeader, string postText, string postTypeId)
        {
            using (var dataContext = new WCFServiceDataContext())
            {
                var pt = dataContext.PostType.FirstOrDefault(a => a.PostTypeID.ToString() == postTypeId);
                if (pt != null)
                {
                    var p = new Post();
                    p.PostHeader = postHeader;
                    p.PostText = postText;
                    p.PostTypeID = short.Parse(postTypeId);
                    dataContext.Post.InsertOnSubmit(p);
                    dataContext.SubmitChanges();
                    return p.PostID;
                }
                return -1;
            }
        }

        public void UpdatePost(string postId, string postHeader, string postText, string postTypeId)
        {
            using (var dataContext = new WCFServiceDataContext())
            {
                var p = dataContext.Post.FirstOrDefault(a => a.PostID.ToString() == postId);
                p.PostHeader = postHeader;
                p.PostText = postText;
                p.PostTypeID = short.Parse(postTypeId);
                dataContext.SubmitChanges();
            }
        }

        public void DeletePost(string postId)
        {
            using (var dataContext = new WCFServiceDataContext())
            {
                var p = dataContext.Post.FirstOrDefault(a => a.PostID.ToString() == postId);
                if (p != null)
                {
                    dataContext.Post.DeleteOnSubmit(p);
                    dataContext.SubmitChanges();
                }
            }
        }
    }
}
