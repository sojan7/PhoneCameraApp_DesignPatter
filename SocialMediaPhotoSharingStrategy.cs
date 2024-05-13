using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneCameraApp
{
    public class SocialMediaPhotoSharingStrategy : IPhotoSharingStrategy
    {
        public void SharePhoto(string photo)
        {
            Console.WriteLine($"Sharing photo via social media: {photo}");
        }
    }
}