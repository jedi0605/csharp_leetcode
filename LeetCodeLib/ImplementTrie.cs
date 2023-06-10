using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCodeLib
{
    public class TrieHashVer
    {
        HashSet<string> _value;
        HashSet<string> _prefix;
        public TrieHashVer()
        {
            _value = new HashSet<string>();
            _prefix = new HashSet<string>();
        }

        public void Insert(string word)
        {
            if (_value.Contains(word))
                return;
            else
            {
                _value.Add(word);
                string prefix = string.Empty;
                for (int i = 0; i < word.Length; i++)
                {
                    prefix += word[i];
                    if (!_prefix.Contains(prefix))
                        _prefix.Add(prefix);
                }
            }
        }

        public bool Search(string word)
        {
            return _value.Contains(word);
        }

        public bool StartsWith(string prefix)
        {
            return _prefix.Contains(prefix);
        }
    }
}