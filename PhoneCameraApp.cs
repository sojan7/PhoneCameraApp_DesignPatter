namespace PhoneCameraApp
{
    public class PhoneCameraApp : CameraApp
    {
        public PhoneCameraApp(IPhotoSharingStrategy photoSharingStrategy) : base(photoSharingStrategy)
        {
        }

        public override void EditPhoto()
        {
            Console.WriteLine("Editing a photo with basic editor");
        }
    }
}