using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_2
{
    class Bread:Product
    {
        private string breadType;
        public string BreadType
        {
            get { return breadType;} set{if(string.IsNullOrEmpty(value)) breadType = value;} 
        }


        public Bread(string productName,int productCost,int productId,string productType,string razdelMagazin,string breadType) : base(productName, productCost, productId, productType,razdelMagazin)
        {
            this.breadType = breadType;
        }

        public Bread() : base()
        {
            breadType = String.Empty;
        }
        public override string ToString() {
            return base.ToString() + $" Bread Type : {breadType}";
        }
        
        public override string RazdelMagazin()
        {
            return $"razdelMagazin {razdelMagazin} - There can be different type of bread";
        }
        public override bool Equals(object obj){
            if(obj is Bread){ return ToString().Equals(((Bread)obj).ToString()); }
            return false;
        }

        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }
    }
}
