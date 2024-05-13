namespace PhoneCameraApp
{
    public abstract class CameraApp
    {
        protected IPhotoSharingStrategy photoSharingStrategy;

        public abstract void EditPhoto();

        public CameraApp(IPhotoSharingStrategy photoSharingStrategy)
        {
            this.photoSharingStrategy = photoSharingStrategy;
        }

        public void TakePhoto()
        {
            Console.WriteLine("Taking a photo");
        }

        public void SavePhoto()
        {
            Console.WriteLine("Saving a photo");
        }

        public void SharePhoto(string photo)
        {
            photoSharingStrategy.SharePhoto(photo);
        }
    }
}