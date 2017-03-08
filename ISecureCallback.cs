﻿using System.ServiceModel;
using System.ServiceModel.Web;
using System.Threading.Tasks;

namespace Goova.Plexo
{
    [ServiceContract]
    public interface ISecureCallback
    {
        [OperationContract]
        [WebInvoke(UriTemplate = "Instrument", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        Task<ClientSignedResponse> Instrument(ServerSignedRequest<IntrumentCallback> instrument);
    }
}