using System.Collections.Generic;
using System.Xml.Serialization;

namespace CountWordsPerLanguage
{
  class LetterFrequencyList
  {
    [XmlElement("LetterFrequency")]
    public List<LetterFrequency> LetterFrequencies = new List<LetterFrequency>(); 
  }
}