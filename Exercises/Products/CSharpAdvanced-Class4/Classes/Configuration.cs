using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpAdvanced_Class4.Interfaces;
using static CSharpAdvanced_Class4.Enums.Enums;

namespace CSharpAdvanced_Class4
{
    public abstract class Item
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public double Discount { get; set; }
    }

    public class Part : Item, IPrice
    {
        public double GetPrice()
        {
            return Price;
        }
    }

    public class Module : Item, IPrice, IDiscont
    {
        private List<Part> _parts = new List<Part>();

        public Module() { }
        public Module(string name)
        {
            Name = name;
        }

        public void AddPartToModule(Part part, int quantity = 1)
        {
            part.Quantity = quantity;
            _parts.Add(part);
        }

        public void RemovePartFromModule(Part part)
        {
            for (int i = 0; i < _parts.Count; i++)
            {
                if (_parts[i] == part)
                {
                    _parts.Remove(_parts[i]);
                }
            }
        }

        public double GetPrice()
        {
            double sum = 0.0;
            foreach (var item in _parts)
            {
                sum += item.GetPrice() * item.Quantity;
            }
            return sum;
        }

        public void SetDiscount(double discount)
        {
            Discount = discount / 100;
        }

        public double GetPriceWithDiscount()
        {
            return GetPrice() * (1 - Discount);
        }
    }

    public class Configuration : Item, IPrice, IDiscont
    {
        public Colors BoxColor { get; set; }
        private List<Part> _parts = new List<Part>();
        private List<Module> _modules = new List<Module>();
        public List<Part> Parts { get; set; }
        public List<Module> Modules { get; set; }

        public Configuration() { }
        public Configuration(Colors boxColor)
        {
            BoxColor = boxColor;
        }

        public void AddPartToProduct(Part part, int quantity = 1)
        {
            part.Quantity = quantity;
            _parts.Add(part);
        }

        public void RemovePartFromModule(Part part)
        {
            for (int i = 0; i < _parts.Count; i++)
            {
                if (_parts[i] == part)
                    _parts.Remove(_parts[i]);
            }
        }

        public void AddModuleToProduct(Module module, int quantity = 1)
        {
            module.Quantity = quantity;
            _modules.Add(module);
        }

        public void RemovePartFromModule(Module module)
        {
            for (int i = 0; i < _modules.Count; i++)
            {
                if (_modules[i] == module)
                    _modules.Remove(_modules[i]);
            }
        }

        public double GetPrice()
        {
            double sum = 0;
            foreach (var item in _parts)
            {
                sum += item.GetPrice() * item.Quantity;
            }

            foreach (var item in _modules)
            {
                sum += item.GetPrice() * item.Quantity;
            }
            return sum;
        }

        public void SetDiscount(double discount)
        {
            Discount = discount / 100;
        }

        public double GetPriceWithDiscount()
        {
            return GetPrice() * (1 - Discount);
        }
    }
}
