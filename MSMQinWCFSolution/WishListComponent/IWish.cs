using System.ServiceModel;

namespace WishListComponent
{
    [ServiceContract]
    public interface IWish
    {
        //IsOneWay=true denotes that there will no return message from the server to the client.
        [OperationContract(IsOneWay = true)]
        void SayYourWish(string wisherName, string yourWish);
    }
}