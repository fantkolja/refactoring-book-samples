public class Trie
{
  private readonly TrieNode _root = new();

  public void Insert(string word)
  {
    var node = _root;
    foreach (var ch in word)
    {
      if (!node.Children.ContainsKey(ch))
      {
        node.Children[ch] = new TrieNode();
      }
      node = node.Children[ch];
    }
    node.IsWord = true;
  }

  public bool Contains(string word)
  {
    var node = _root;
    foreach (var ch in word)
    {
      if (!node.Children.TryGetValue(ch, out node))
        return false;
    }
    return node.IsWord;
  }

  public int Count
  {
    get
    {
      int counter = 0;
      foreach (var word in GetWords())
      {
        counter++;
      }
      return counter;
    }
  }

  public IEnumerable<string> GetWords()
  {
    return _traverse(_root, "");
  }

  private IEnumerable<string> _traverse(TrieNode node, string prefix)
  {
    if (node.IsWord)
      yield return prefix;

    foreach (var key in node.Children.Keys)
    {
      foreach (var word in _traverse(node.Children[key], prefix + key))
      {
        yield return word;
      }
    }
  }
}