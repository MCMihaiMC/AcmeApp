namespace Acme.Biz
{
    /// <summary>
    /// Manages products carried in inventaries.
    /// </summary>
    public class Product
    {
        public const double InchesPerMeter = 30.97;
        public readonly decimal MinimumPrice;

        #region Constructors

        // Default constructor
        public Product()
        {
            Console.WriteLine("Product instance created");

            // initializing auto propertties in constructor
            this.MinimumPrice = .96m;
            this.Category = "tools";
        }

        // In below case the using of this allows us to invoke another constructor
        // This is constructor chaining - reduces the code
        public Product(int productId, string productName, string description) : this()
        {
            this.ProductId = productId;
            this.ProductName = productName;
            this.Description = description;

            Console.WriteLine("Product instance has a name: " + ProductName);
        }
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
            get
            {
                var formattedValue = productName?.Trim();
                return formattedValue;
            }
            set
            {
                if (value.Length < 3)
                    ValidationMessage = "Product Name must have at least 3 characters.";
                else if (value.Length > 20)
                    ValidationMessage = "Product Name must have maximum 20 characters.";
                else
                    productName = value;
            }
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
            get
            {
                if (productVendor == null)
                {
                    productVendor = new Vendor();
                }
                return productVendor;

            }
            set { productVendor = value; }
        }

        public string ValidationMessage { get; private set; }

        // Auto properties
        public string Category { get; set; }

        // Initialized auto properties
        public int SequenceNumber { get; set; } = 1;

        // Properties used in concatenated values
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //public string FullName
        //{
        //    get { return FirstName + ", " + LastName; }
        //}

        // Expression body properties
        public string FullName => FirstName + ", " + LastName;
        // Properties used in concatenated values

        // Properties used in calculations
        public int Quantity { get; set; }
        public int Price { get; set; }

        public long ListItemTotal
        {
            get { return Quantity * Price; }
        }

        // Expression body properties
        public int ItemTotal => Quantity * Price;
        // Properties used in calculations

        //public string VendorName => ProductVendor?.CompanyName; // ToDo: define CompanyName in vendor

        public string ProductCode => this.Category + "-" + this.SequenceNumber;

        #endregion

        #region Methods

        public decimal CalculateQuantityOnHand()
        {
            var quantity = 0;
            // Calculate the number in inventory

            return quantity;
        }

        public string SayHello()
        {
            return "Hello " + ProductName + " (" + ProductId + "): " + Description;
        }

        #endregion
    }
}
