class Letter
{
  public string FontStyle { get; set; } = "normal";
  public int FontSize { get; set; } = 12;
  public int FontWeight { get; set; } = 400;
  public string FontFamily { get; set; }
  public string FontColor { get; set; } = "#000";
  public string TextDecoration { get; set; } = "normal";
  public string FromAlphabet { get; } = "latin";
  public string Type { get; } = "Alphabetic";
  public int CharCode { get; }
  public string DisplayName { get; }
  public (int, int) CurrentPosition { get; set; }
  public (int, int) OriginalPosition { get; }
  public string OriginalDocument { get; }
  public Letter(string fontFamily, char character, (int, int) position, string originalDocument)
  {
    this.FontFamily = fontFamily;
    this.CharCode = (int)character;
    this.DisplayName = character.ToString();
    this.OriginalPosition = position;
    this.CurrentPosition = position;
    this.OriginalDocument = originalDocument;
  }
}