namespace PhoneCameraApp
{
    internal class Program
    {
        private static void Main()
        {
            PhotoSharingStrategyFactory strategyFactory = new();

            PhoneCameraApp basicCameraApp = new PhoneCameraApp(strategyFactory.CreatePhotoSharingStrategy("text"));
            basicCameraApp.TakePhoto();
            basicCameraApp.EditPhoto();
            basicCameraApp.SavePhoto();
            basicCameraApp.SharePhoto("basic_camera_photo.jpg");
            Console.WriteLine();

            CameraPlusApp cameraPlusApp = new CameraPlusApp(strategyFactory.CreatePhotoSharingStrategy("email"));
            cameraPlusApp.TakePhoto();
            cameraPlusApp.EditPhoto();
            cameraPlusApp.SavePhoto();
            cameraPlusApp.SharePhoto("camera_plus_photo.jpg");
            Console.WriteLine();

            PhoneCameraApp futureApp = new PhoneCameraApp(strategyFactory.CreatePhotoSharingStrategy("socialmedia"));
            futureApp.TakePhoto();
            futureApp.EditPhoto();
            futureApp.SavePhoto();
            futureApp.SharePhoto("future_app_photo.jpg");
        }
    }
}