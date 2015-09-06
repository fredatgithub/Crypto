using System.Security.Policy;
using System.Xml.Serialization;

namespace CountWordsPerLanguage
{
  class LetterFrequency
  {
    [XmlAnyElement]
    public string Language { get; set; }
    [XmlAnyElement]
    public Hash FileHashHash { get; set; }
    [XmlAnyElement]
    public int LetterA { get; set; }
    [XmlAnyElement]
    public int LetterB { get; set; }
    [XmlAnyElement]
    public int LetterC { get; set; }
    [XmlAnyElement]
    public int LetterD { get; set; }
    [XmlAnyElement]
    public int LetterE { get; set; }
    [XmlAnyElement]
    public int LetterF { get; set; }
    [XmlAnyElement]
    public int LetterG { get; set; }
    [XmlAnyElement]
    public int LetterH { get; set; }
    [XmlAnyElement]
    public int LetterI { get; set; }
    [XmlAnyElement]
    public int LetterJ { get; set; }
    [XmlAnyElement]
    public int LetterK { get; set; }
    [XmlAnyElement]
    public int LetterL { get; set; }
    [XmlAnyElement]
    public int LetterM { get; set; }
    [XmlAnyElement]
    public int LetterN { get; set; }
    [XmlAnyElement]
    public int LetterO { get; set; }
    [XmlAnyElement]
    public int LetterP { get; set; }
    [XmlAnyElement]
    public int LetterQ { get; set; }
    [XmlAnyElement]
    public int LetterR { get; set; }
    [XmlAnyElement]
    public int LetterS { get; set; }
    [XmlAnyElement]
    public int LetterT { get; set; }
    [XmlAnyElement]
    public int LetterU { get; set; }
    [XmlAnyElement]
    public int LetterV { get; set; }
    [XmlAnyElement]
    public int LetterW { get; set; }
    [XmlAnyElement]
    public int LetterX { get; set; }
    [XmlAnyElement]
    public int LetterY { get; set; }
    [XmlAnyElement]
    public int LetterZ { get; set; }

    public LetterFrequency(string language = "english")
    {
      Language = language;
    }

    public void FeedLetters(int[] letterArray)
    {
      LetterA = letterArray[1];
      LetterB = letterArray[2];
      LetterC = letterArray[3];
      LetterD = letterArray[4];
      LetterE = letterArray[5];
      LetterF = letterArray[6];
      LetterG = letterArray[7];
      LetterH = letterArray[8];
      LetterI = letterArray[9];
      LetterJ = letterArray[10];
      LetterK = letterArray[11];
      LetterL = letterArray[12];
      LetterM = letterArray[13];
      LetterN = letterArray[14];
      LetterO = letterArray[15];
      LetterP = letterArray[16];
      LetterQ = letterArray[17];
      LetterR = letterArray[18];
      LetterS = letterArray[19];
      LetterT = letterArray[20];
      LetterU = letterArray[21];
      LetterV = letterArray[22];
      LetterW = letterArray[23];
      LetterX = letterArray[24];
      LetterY = letterArray[25];
      LetterZ = letterArray[26];
    }

  }
}