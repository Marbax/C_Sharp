
namespace properties
{
    class Shop
    {
        private Laptop[] _arr;
        public Laptop this[int index]
        {
            get => _arr[index];
            set => _arr[index] = value;
        }

        public Shop():this(1) {  }

        public Shop(int size) { _arr = new Laptop[size]; for (var i = 0; i < size; i++) _arr[i]=new Laptop(); }

        public int Length => _arr.Length;


    }
}
