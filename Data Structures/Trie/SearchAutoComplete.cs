public class AutocompleteSystem
{
    private class Node
    {
        public Node(string prefix)
        {
            this.Prefix = prefix;
            this.Children = new Dictionary<char, Node>();
        }

        public string Prefix { get; }

        public Dictionary<char, Node> Children { get; }

        public bool IsCompleteWord { get; set; }
    }

    private class ResultsComparer : IComparer<string>
    {
        private Dictionary<string, int> indexMap;

        public ResultsComparer(Dictionary<string, int> map)
        {
            indexMap = map;

        }

        public int Compare(string x, string y)
        {
            if(indexMap[x] != indexMap[y])
            {
                return indexMap[y] - indexMap[x];
            }

            return  x.CompareTo(y);
        }
    }

    private  Dictionary<string, int> hotIndexMap;

    private Node root;

    private String searchString = String.Empty;

    public AutocompleteSystem(string[] sentences, int[] times)
    {
        InitHotIndexMap(sentences, times);
        root = new Node("*");
        AddToTrie(sentences);
    }

    public IList<string> Input(char c)
    {
        if(!Char.IsLetter(c) && c != ' ')
        {
            if (hotIndexMap.ContainsKey(searchString))
            {
                hotIndexMap[searchString]++;
            }
            else
            {
                hotIndexMap.Add(searchString, 1);
                AddToTrie(new string[] { searchString });
            }

            searchString = string.Empty;
            return new List<string>();
        }

        searchString += c;
        return GetHotSearches(searchString);
    }

    private void InitHotIndexMap(string[] sentences, int[] times)
    {
        hotIndexMap = new Dictionary<string, int>();

        for (var i = 0; i < times.Length; ++i)
        {
            hotIndexMap[sentences[i]] = times[i];
        }
    }

    // O(n x l)
    // n is the number of sentences
    // l is the average length
    private void AddToTrie(string[] sentences)
    {
        foreach (var s in sentences)
        {
            Node current = root;
            for (var i = 0; i < s.Length; ++i)
            {
                if (!current.Children.ContainsKey(s[i]))
                {
                    current.Children.Add(s[i], new Node(s.Substring(0, i + 1)));
                }
                current = current.Children[s[i]];
                
                if(i == s.Length - 1){
                    current.IsCompleteWord = true;
                }
            }
        }
    }

    private List<string> GetHotSearches(string s)
    {
        var results = new List<string>();
        var prefixNode = CheckValidPrefix(s);
        
        if(prefixNode == null)
        {
            return results;
        }

        DFSVisit(prefixNode, results);

        return PostProcessing(results);
    }


    private Node CheckValidPrefix(string prefix)
    {
        Node current = root;
        for (var i = 0; i < prefix.Length; ++i)
        {
            if (!current.Children.ContainsKey(prefix[i]))
            {
                return null;
            }
            current = current.Children[prefix[i]];
        }

        return current;
    }

    private void DFSVisit(Node current, List<string> results)
    {
        if (current.IsCompleteWord)
        {
            results.Add(current.Prefix);
        }
        
        foreach(var child in current.Children.Keys)
        {
            DFSVisit(current.Children[child], results);
        }
    }

    private List<string> PostProcessing(List<string> results)
    {
        results.Sort(new ResultsComparer(hotIndexMap));

        if(results.Count <= 3)
        {
            return results;
        }

        var newResults = new List<string>();
        for(var i = 0; i < 3; ++i) {
            newResults.Add(results[i]);
        }

        return newResults;

    }
}

/**
 * Your AutocompleteSystem object will be instantiated and called as such:
 * AutocompleteSystem obj = new AutocompleteSystem(sentences, times);
 * IList<string> param_1 = obj.Input(c);
 */