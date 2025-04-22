class Cart
{
  private List<CartItem> _items = new List<CartItem>();

  public int Add(string name, int count = 1)
  {
    CartItem? existingItem = this._items.Find((CartItem item) => String.Equals(item.Name, name));
    if (existingItem == null)
    {
      CartItem item = new(name, count);
      _items.Add(item);
    }
    else
    {
      existingItem.Count += count;
    }

    return _items.Count;
  }

  public bool Remove(string name, int count = 1)
  {
    CartItem? existingItem = this._items.Find((CartItem item) => String.Equals(item.Name, name));
    if (existingItem == null)
    {
      throw new KeyNotFoundException();
    }
    else if (existingItem.Count < count)
    {
      throw new NotSupportedException("Actual number is less than the number requested to delete!");
    }
    else if (existingItem.Count == count)
    {
      this._items.Remove(existingItem);
    }
    else
    {
      existingItem.Count -= count;
    }
    return true;
  }

  public override string ToString()
  {
    string list = String.Join(";\n", _items);
    return $"Your cart:\n{list}";
  }


  public bool Save(string filename)
  {
    File.WriteAllText(filename, this.ToString());
    return true;
  }

  public static bool Load(string filename)
  {
    throw new NotImplementedException();
  }
}










// class Cart
// {
//   private List<CartItem> _items = new List<CartItem>();

//   public int Add(string name, int count = 1)
//   {
//     CartItem? existingItem = this._items.Find((CartItem item) => String.Equals(item.Name, name));
//     if (existingItem == null)
//     {
//       CartItem item = new(name, count);
//       _items.Add(item);
//     }
//     else
//     {
//       existingItem.Count += count;
//     }

//     return _items.Count;
//   }

//   public bool Remove(string name, int count = 1)
//   {
//     CartItem? existingItem = this._items.Find((CartItem item) => String.Equals(item.Name, name));
//     if (existingItem == null)
//     {
//       throw new KeyNotFoundException();
//     }
//     else if (existingItem.Count < count)
//     {
//       throw new NotSupportedException("Actual number is less than the number requested to delete!");
//     }
//     else if (existingItem.Count == count)
//     {
//       this._items.Remove(existingItem);
//     }
//     else
//     {
//       existingItem.Count -= count;
//     }
//     return true;
//   }

//   public List<CartItem> GetItems()
//   {
//     return new List<CartItem>(_items);
//   }
// }

// class CartFormatter
// {
//   public static string Format(Cart cart)
//   {
//     string list = String.Join(";\n", cart.GetItems());
//     return $"Your cart:\n{list}";
//   }
// }

// class CartPersistence
// {
//   public static void Save(Cart cart, string filename)
//   {
//     string content = CartFormatter.Format(cart);
//     File.WriteAllText(filename, content);
//   }

//   public static Cart Load(string filename)
//   {
//     throw new NotImplementedException();
//   }
// }