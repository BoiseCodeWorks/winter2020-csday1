using System.Collections.Generic;

namespace csharp1.Models
{
  // Access modifier, when not provided is 'internal'
  class Store
  {
    // Field hold data
    // access modifier in class is defaulted to private
    // string _address;

    // // Property
    // public string Address
    // {
    //   get
    //   {
    //     return _address;
    //   }
    //   set
    //   {
    //     _address = value;
    //   }
    // }

    // AutoProp
    public string Address { get; set; }
    public Dictionary<string, Furniture> Furniture { get; private set; }



    // Method Signature 
    // Access Modifier, Return Type, method name, parameters
    public bool addFurniture(string name, float price, int quantity)
    {
      if (price > 0)
      {
        Furniture newItem = new Furniture(price, name, quantity);
        Furniture.Add(newItem.Name, newItem);
        return true;
      }
      return false;
    }


    // contstructor is always public, no return type, and method name is the same as the Class
    public Store(string address)
    {
      Furniture = new Dictionary<string, Furniture>();
      Address = address;
    }

    // Public, accessible by anything
    // Private only accessible by other methods and properties inside the class
    // Protected, Internal


  }
}