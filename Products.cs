namespace SupermarketPOO
{
    public abstract class Products
    {
        public int Id { get; set; }

        public string Descripcion { get; set; }

        public decimal Price { get; set; }

        public decimal Tax { get; set; }

        public abstract decimal valueToPay();

        public override string ToString()
        {
            return $"{Id}Descripción    :{Descripcion}," +
                $" Price                :{Price}," +
                $" Tax                  :{Tax},";

        }
    }
}
