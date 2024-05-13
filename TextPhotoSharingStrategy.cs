namespace PhoneCameraApp
{
    public class TextPhotoSharingStrategy : IPhotoSharingStrategy
    {
        public void SharePhoto(string photo)
        {
            Console.WriteLine($"Sharing photo via text: {photo}");
        }
    }
}