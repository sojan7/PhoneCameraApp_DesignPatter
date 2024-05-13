namespace PhoneCameraApp
{
    public class EmailPhotoSharingStrategy : IPhotoSharingStrategy
    {
        public void SharePhoto(string photo)
        {
            Console.WriteLine($"Sharing photo via email: {photo}");
        }
    }
}