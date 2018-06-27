using System;

namespace WishListComponent
{
    public class MyWish : IWish
    {
        public void SayYourWish(string wisherName, string yourWish)
        {
            Console.WriteLine("Client: " + wisherName + " wishes :" + yourWish);
        }
    }
}