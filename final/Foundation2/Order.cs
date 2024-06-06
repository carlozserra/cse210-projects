class Order
    {
        private List<Product> _products;
        private Customer _customer;

        public Order(Customer customer)
        {
            _customer = customer;
            _products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public double GetTotalCost()
        {
            double totalCost = 0;
            foreach (var product in _products)
            {
                totalCost += product.CalculateCost();
            }

            double shippingCost;
            if (_customer.IsInUSA())
            {
                shippingCost = 5.0;
            }
            else
            {
                shippingCost = 35.0;
            }
            totalCost += shippingCost;

            return totalCost;
        }

        public string GetPackingLabel()
        {
            string label = "";
            foreach (var product in _products)
            {
                label += $"{product.GetId()} - {product.GetName()}\n";
            }
            return label;
        }

        public string GetShippingLabel()
        {
            return $"Name: {_customer.GetName()}\n {_customer.GetAddress().GetFullAddress()}";
        }

        public void DisplayOrderDetails()
        {
            Console.WriteLine("Packing Label:");
            Console.WriteLine(GetPackingLabel());
            Console.WriteLine("Shipping Label:");
            Console.WriteLine(GetShippingLabel());
            Console.WriteLine($"\nTotal Price: ${GetTotalCost():0.00}\n");
        }
}
