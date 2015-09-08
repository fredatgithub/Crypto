using System;
using System.Security.Cryptography;
using System.Text;
using System.Xml.Serialization;

namespace CountWordsPerLanguage
{
  public class LetterFrequency
  {
    [XmlElement("Language")]
    public string Language { get; set; }
    [XmlElement("FileHash")]
    public int FileHash { get; set; }
    [XmlElement("LetterA")]
    public int LetterA { get; set; }
    [XmlElement("LetterB")]
    public int LetterB { get; set; }
    [XmlElement("LetterC")]
    public int LetterC { get; set; }
    [XmlElement("LetterD")]
    public int LetterD { get; set; }
    [XmlElement("LetterE")]
    public int LetterE { get; set; }
    [XmlElement("LetterF")]
    public int LetterF { get; set; }
    [XmlElement("LetterG")]
    public int LetterG { get; set; }
    [XmlElement("LetterH")]
    public int LetterH { get; set; }
    [XmlElement("LetterI")]
    public int LetterI { get; set; }
    [XmlElement("LetterJ")]
    public int LetterJ { get; set; }
    [XmlElement("LetterK")]
    public int LetterK { get; set; }
    [XmlElement("LetterL")]
    public int LetterL { get; set; }
    [XmlElement("LetterM")]
    public int LetterM { get; set; }
    [XmlElement("LetterN")]
    public int LetterN { get; set; }
    [XmlElement("LetterO")]
    public int LetterO { get; set; }
    [XmlElement("LetterP")]
    public int LetterP { get; set; }
    [XmlElement("LetterQ")]
    public int LetterQ { get; set; }
    [XmlElement("LetterR")]
    public int LetterR { get; set; }
    [XmlElement("LetterS")]
    public int LetterS { get; set; }
    [XmlElement("LetterT")]
    public int LetterT { get; set; }
    [XmlElement("LetterU")]
    public int LetterU { get; set; }
    [XmlElement("LetterV")]
    public int LetterV { get; set; }
    [XmlElement("LetterW")]
    public int LetterW { get; set; }
    [XmlElement("LetterX")]
    public int LetterX { get; set; }
    [XmlElement("LetterY")]
    public int LetterY { get; set; }
    [XmlElement("LetterZ")]
    public int LetterZ { get; set; }

    public LetterFrequency() // constructor without parameters required by XML Serialization
    {
      Language = "english";
    }

    public LetterFrequency(string language)
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

    public void AddHash(string text)
    {
      byte[] buffer = Encoding.Default.GetBytes(text);
      var fileHash2 = SHA512.Create();
      fileHash2.ComputeHash(buffer);
      FileHash = fileHash2.GetHashCode();
    }
  }
}