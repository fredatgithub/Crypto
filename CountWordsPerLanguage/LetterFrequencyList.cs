using System.Collections.Generic;
using System.Xml.Serialization;

namespace CountWordsPerLanguage
{
  public class LetterFrequencyList
  {
    [XmlElement("LetterFrequencies")]
    public List<LetterFrequency> LetterFrequencies = new List<LetterFrequency>();

    public LetterFrequencyList() // useful for deserialization
    {
      
    }
  }
}