//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RentCar.UserInterface.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBL_Musteriler
    {
        public int ID { get; set; }
        public string TcNo { get; set; }
        public string Isim { get; set; }
        public string Soyisim { get; set; }
        public Nullable<System.DateTime> DogumTarihi { get; set; }
        public string DogumYeri { get; set; }
        public string CepTel { get; set; }
        public string EvTel { get; set; }
        public string Email { get; set; }
        public string Adres { get; set; }
        public string EhliyetNo { get; set; }
        public string EhliyetTuru { get; set; }
        public string Notlar { get; set; }
        public byte[] Resim { get; set; }
    }
}