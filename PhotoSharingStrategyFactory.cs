using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneCameraApp
{
    public class PhotoSharingStrategyFactory
    {
        public IPhotoSharingStrategy CreatePhotoSharingStrategy(string shareMethod)
        {
            return shareMethod.ToLower() switch
            {
                "text" => new TextPhotoSharingStrategy(),
                "email" => new EmailPhotoSharingStrategy(),
                "socialmedia" => new SocialMediaPhotoSharingStrategy(),
                _ => throw new ArgumentException("Invalid share method"),
            };
        }
    }
}