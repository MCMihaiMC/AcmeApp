namespace Acme.Biz
{
    public class Product
    {
        public const double InchesPerMeter = 30.97;
        public readonly decimal MinimumPrice;

        #region Constructors
        #endregion

        #region Properties
        private DateTime? availabilityDate;
        public DateTime? AvailabilityDate
        {
            get { return availabilityDate; }
            set { availabilityDate = value; }
        }

        private string productName;
        public string ProductName
        {
            get { var formattedValue = productName?.Trim(); 
                return formattedValue;
            }
            set { productName = value; }
        }

        private string description;
        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        private int productId;
        public int ProductId
        {
            get { return productId; }
            set { productId = value; }
        }

        private Vendor productVendor;
        public Vendor ProductVendor
        {
            get {
                if (productVendor == null)
                {
                    productVendor = new Vendor();
                }
                return productVendor;
            
            }
            set { productVendor = value; }
        }


        #endregion
    }
}
