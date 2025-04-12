using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_2
{
    abstract class Product
    { 
        public string productName;
        public int productCost;
        public int productId;
        public string productType;

        public string razdelMagazin;
        

        public Product()
        {
            productName = string.Empty;
            productCost = 0;
            productId = 0;
            productType = string.Empty;
            razdelMagazin = string.Empty;
        }
        public Product(string productName,int productcost,int productid,string productType,string razdelMagazin)
        {
            this.productName = productName;
            this.productCost = productcost;
            this.productId = productid;
            this.productType = productType;
            this.razdelMagazin = razdelMagazin;

        }

        public string ProductName
        {
            get { return productName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("ProductName");
                }
                productName = value;
            }
        }

        public int ProductCost
        {
            get { return productCost; }
            set{if (!int.TryParse(value.ToString(), out int parsed))
                {
                    throw new ArgumentException("Project age animal must be an integer");
                }
                productCost = parsed;}


        }

        public int ProductId
        {
            get { return productId; }
            set{if  (!int.TryParse(value.ToString(), out int parsed)){throw new ArgumentException("Project age animal must be an integer");}productId=value;}
        }
        public string ProductType
        {
            get { return productType;} set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("ProductType");
                } ;
                productType = value;
            } 
        }

        public string KonRazdelMagazin
        {
            get { return razdelMagazin; }
            set{
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("RazdelMagazin");
                }
                razdelMagazin = value;
            }
            
        }
        public override string ToString() {
            return $"Product info | Product name : {productName} , Product cost : {productCost} , Product Id : {productId} , Product Type : {productType} , RazdelMagazin : {razdelMagazin}";
        }
        public abstract string RazdelMagazin();

    }
}
