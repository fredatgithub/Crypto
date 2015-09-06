using System.Security.Policy;
using System.Xml.Serialization;

namespace CountWordsPerLanguage
{
  class LetterFrequency
  {
    [XmlElement]
    public string Language { get; set; }
    [XmlElement]
    public Hash FileHashHash { get; set; }
    [XmlElement]
    public int LetterA { get; set; }
    [XmlElement]
    public int LetterB { get; set; }
    [XmlElement]
    public int LetterC { get; set; }
    [XmlElement]
    public int LetterD { get; set; }
    [XmlElement]
    public int LetterE { get; set; }
    [XmlElement]
    public int LetterF { get; set; }
    [XmlElement]
    public int LetterG { get; set; }
    [XmlElement]
    public int LetterH { get; set; }
    [XmlElement]
    public int LetterI { get; set; }
    [XmlElement]
    public int LetterJ { get; set; }
    [XmlElement]
    public int LetterK { get; set; }
    [XmlElement]
    public int LetterL { get; set; }
    [XmlElement]
    public int LetterM { get; set; }
    [XmlElement]
    public int LetterN { get; set; }
    [XmlElement]
    public int LetterO { get; set; }
    [XmlElement]
    public int LetterP { get; set; }
    [XmlElement]
    public int LetterQ { get; set; }
    [XmlElement]
    public int LetterR { get; set; }
    [XmlElement]
    public int LetterS { get; set; }
    [XmlElement]
    public int LetterT { get; set; }
    [XmlElement]
    public int LetterU { get; set; }
    [XmlElement]
    public int LetterV { get; set; }
    [XmlElement]
    public int LetterW { get; set; }
    [XmlElement]
    public int LetterX { get; set; }
    [XmlElement]
    public int LetterY { get; set; }
    [XmlElement]
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