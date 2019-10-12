using System;
namespace Bai_4
{
    public class CD
    {
        private string cdName;
        private string cdType;
        private double cdPrice;

        public CD()
        {
        }
        public CD(string cdName, string cdType, double cdPrice)
        {
            this.CDNAME = cdName;
            this.CDTYPE = cdType;
            this.CDPRICE = cdPrice;
        }

        public string CDNAME { get => cdName; set => cdName = value; }
        public string CDTYPE { get => cdType; set => cdType = value; }
        public double CDPRICE{ get => cdPrice; set => cdPrice = value; }

        public override string ToString()
        {
            return "Ten CD: " + this.cdName + " | " + "Type CD: " + this.cdType + " | " + "Price CD : " + this.cdPrice;
        }

    }
}
