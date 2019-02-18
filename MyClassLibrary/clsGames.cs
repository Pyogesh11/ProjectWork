using System;

namespace MyClassLibrary
{
    public class clsGames
    {
        public string Game_Name { get; set; }
        public string Game_Description { get; set; }
        public int Game_Quantity { get; set; }
        public string Platform { get; set; }
        public int Supplier_ID { get; set; }

        public bool Find(int supplier_ID)
        {
            throw new NotImplementedException();
        }
    }
}