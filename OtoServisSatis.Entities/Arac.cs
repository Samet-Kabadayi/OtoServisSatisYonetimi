namespace OtoServisSatis.Entities
{
    public class Arac : IEnttity
    {
        public int Id { get; set; }
        public int MarkaId { get; set; }
        public string Renk { get; set; }
        public decimal Fiyat { get; set; }
        public string Model { get; set; }
        public string KasaTipi { get; set; }
        public int ModelYili { get; set; }
        public bool SatisDurumu { get; set; }
        public string Notlar { get; set; }

        public virtual Marka Marka { get; set; }
    }
}
