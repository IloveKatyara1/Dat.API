namespace Dat.ProductAPI.Models
{
	public class ResponceDto
	{
        public bool IsSucces { get; set; }
        public object Result { get; set; }
        public string DisplayMessaege { get; set; }
        public List<Exception> ErrorMasegess { get; set; }
    }
}
