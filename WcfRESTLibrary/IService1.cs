using System.IO;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace WcfRESTLibrary
{
    [ServiceContract]
    public interface IService1
    {
        [WebInvoke(Method = "GET", UriTemplate = "files/{fileName}?offset={offset}&size={size}",
            ResponseFormat = WebMessageFormat.Json)]
        [OperationContract]//get filename offset size
        string GetFilePiece(string fileName, string offset, string size);


        [WebInvoke(Method = "POST", UriTemplate = "files/?name={fileName}&text={text}",
            ResponseFormat = WebMessageFormat.Json)]
        [OperationContract]//post text filename
        string ReceiveText(string fileName, string text);


        [WebInvoke(Method = "GET", UriTemplate = "hash/?text={text}",
            ResponseFormat = WebMessageFormat.Json)]
        [OperationContract]//get text
        int GetHashCode(string text);

        [WebInvoke(Method = "POST", UriTemplate = "base64",
            ResponseFormat = WebMessageFormat.Json)]
        [OperationContract]//post data
        string GetBase64Code(Stream data);

    }

    
}
