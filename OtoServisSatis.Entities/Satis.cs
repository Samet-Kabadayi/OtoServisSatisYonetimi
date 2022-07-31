using System;

namespace OtoServisSatis.Entities
{
    public class Satis : IEnttity
    {
        public int Id { get; set; }
        public int AracId { get; set; }
        public int MusteriId { get; set; }
        public decimal Satisfiyati { get; set; }
        public DateTime SatisTarihi { get; set; }
        public virtual Arac Arac { get; set; }
        public virtual Musteri Musteri { get; set; }
    }
}
