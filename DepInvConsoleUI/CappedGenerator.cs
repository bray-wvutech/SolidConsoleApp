using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidUI;

internal class CappedGenerator : ISentenceGenerator
{
    protected List<string> _sentences = [
        "The quick brown fox jumps over the lazy dog.",
        "How razorback-jumping frogs can level six piqued gymnasts!",
        "The five boxing wizards jump quickly."
    ];

    // SOLID: Open/Closed Principle
    public void AddSentence(string sentence)
    {
        _sentences.Add(sentence);
    }

    public string GetNewSentence()
    {
        return _sentences[new Random().Next(0, _sentences.Count)].ToUpper();
    }
}
