namespace Crops.Models
{
    public class CropChangeRequest
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime ModificationDate { get; set; }
        public string ParcelId { get; set; }
        public string ParcelName { get; set; }
        public string NewMainCrop { get; set; }
        public string NewCatchCrop { get; set; }
    }

}
