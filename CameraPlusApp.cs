using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneCameraApp
{
    public class CameraPlusApp : CameraApp
    {
        public CameraPlusApp(IPhotoSharingStrategy photoSharingStrategy) : base(photoSharingStrategy)
        {
        }

        public override void EditPhoto()
        {
            Console.WriteLine("Editing a photo with advanced editor");
        }
    }
}