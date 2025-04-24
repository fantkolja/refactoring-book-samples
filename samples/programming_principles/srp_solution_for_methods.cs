class Cart
{
  private List<CartItem> _items = new List<CartItem>();
  public int Add(string name, int count = 1)
  {
    CartItem? item = FindItemByName(name);
    
    if (item == null) { _items.Add(new CartItem(name, count)); }
    else { IncreaseItemCount(item, count); }
    return _items.Count;
  }

  public bool Remove(string name, int count = 1)
  {
    CartItem? item = FindItemByName(name);
    ValidateItemExists(item);
    ValidateRemovalAmount(item, count);

    if (item!.Count == count) { _items.Remove(item); }
    else { DecreaseItemCount(item, count); }
    return true;
  }

  private CartItem? FindItemByName(string name)
  {
    return _items.Find(i => string.Equals(i.Name, name, StringComparison.OrdinalIgnoreCase));
  }

  private void IncreaseItemCount(CartItem item, int count)
  {
    item.Count += count;
  }

  private void DecreaseItemCount(CartItem item, int count)
  {
    item.Count -= count;
  }

  private void ValidateItemExists(CartItem? item)
  {
    if (item == null) { throw new KeyNotFoundException("Item not found in cart."); }
  }

  private void ValidateRemovalAmount(CartItem item, int count)
  {
    if (item.Count < count) { throw new NotSupportedException("Cannot remove more items than exist."); }
  }
}
