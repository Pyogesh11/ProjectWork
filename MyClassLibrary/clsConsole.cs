using System;

namespace MyClassLibrary
{
    public class clsConsole
    {
        public bool Active { get; set; }
        public DateTime DateAdded { get; set; }
        public string Console { get; set; }
        public string Manufacturer { get; set; }
        public int Price { get; set; }
        public int Stock { get; set; }

        public string Valid(string manufacturer)
        {
            if (Manufacturer != "")
            {
                return "";
            }
            else
            {
                return "This must not be blank";
            }
        }
    }
}