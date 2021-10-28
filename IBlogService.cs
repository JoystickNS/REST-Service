using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace Lab4
{
    [ServiceContract]
    public interface IBlogService
    {
        // PostTypes
        [OperationContract]
        [WebGet (UriTemplate = "/PostTypes", ResponseFormat = WebMessageFormat.Json)]
        IEnumerable<PostTypeDTO> GetPostTypes();

        [OperationContract]
        [WebGet (UriTemplate = "/PostTypes/{postTypeId}", ResponseFormat = WebMessageFormat.Json)]
        PostTypeDTO GetPostType(string postTypeId);

        [OperationContract]
        [WebInvoke (Method = "POST", UriTemplate = "/PostTypeAdd/{postTypeName}")]
        int AddPostType(string postTypeName);

        [OperationContract]
        [WebInvoke (Method = "PUT", UriTemplate = "/PostTypeUpdate/{postTypeId}/{postTypeName}")]
        void UpdatePostType(string postTypeId, string postTypeName);

        [OperationContract]
        [WebInvoke (Method = "DELETE", UriTemplate = "/PostTypeDelete/{postTypeId}")]
        void DeletePostType(string postTypeId);
        // End PostTypes

        // Posts
        [OperationContract]
        [WebGet (UriTemplate = "/Posts", ResponseFormat = WebMessageFormat.Json)]
        IEnumerable<PostDTO> GetPosts();

        [OperationContract]
        [WebGet (UriTemplate = "/Posts/{postId}", ResponseFormat = WebMessageFormat.Json)]
        PostDTO GetPost(string postId);

        [OperationContract]
        [WebInvoke (Method = "POST", UriTemplate = "/PostAdd/{postHeader}/{postText}/{postTypeId}")]
        int AddPost(string postHeader, string postText, string postTypeId);

        [OperationContract]
        [WebInvoke (Method = "PUT", UriTemplate = "/PostUpdate/{postId}/{postHeader}/{postText}/{postTypeId}")]
        void UpdatePost(string postId, string postHeader, string postText, string postTypeId);

        [OperationContract]
        [WebInvoke (Method = "DELETE", UriTemplate = "/PostDelete/{postId}")]
        void DeletePost(string postId);
        // End Posts
    }
}
