public class TrieNode
{
  public bool IsWord { get; set; }
  public SortedDictionary<char, TrieNode> Children { get; } = new();
}

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
}
