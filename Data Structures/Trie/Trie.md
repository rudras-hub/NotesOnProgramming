# Trie Data Structure
- Usually a node represents a character, and a path represents a complete/part of a word.
- Used for word validation, autocomplete etc.
- Representation of a trie node:
    ```Java
    class TrieNode{
        String prefix; // prefix till this node.
        HashMap<Character, Node> children;
        boolean isCompleteWord;
    }
    ```
- Common optimization:
    - To check if something is a valid prefix, instead of starting from the root for every character added, we want to build on past calls. 
    - If a character is a valid prefix, return the node. Then to check for the next character, use the returned node reference to check  if the next character is a child.

## Operations:
- Insertion: 
    - Going through the string, check if your first character is a child of the tire root, if not insert it. Check if the next character is a child of the previous root. And so on. At the last character, set `isCompleteWord` flag to true.
    - If we want to insert `n` words in a trie with an average length of `l`, then the time complexity is `O(lxn)`. 

- Search:
    - Prefix Search:
        - Check if there are words with given prefix.
        - Check if the first character is a child of the root, check if second character is child of first character, and so on.
        - If we reach the last character of the given prefix following a trie path, then the given prefix is valid, as there is at least one word that starts with given prefix.
    - Whole Word Search:
        - Similar to above we trie to find a path while going through a given word character by character.
        - If we reach the last character we additionally check if the `isCompleteWord` flag true.
    - Time Complexity: If the length of the given word or prefix is `l` then the time complexity is `O(l)`.

- Delete Word:
    - Going through the given word, follow along a trie path. 
    - At the node for the last character:
        - If the node has children, then simply set the `isEndOfWord` to false.
        - If it does not have any children, go one level up to the parent, and remove the entry associated with the last character from the dictionary.
            - If this deletion results in the parent node having no children then go one level up, to the grandparent, delete the parent entry from the grandparent's dictionary, and so on. Keep going up  till you reach a node that can't be deleted.
    - Time Complexity: If the length of the word is `l`, then time complexity is `O(l)`.

## Template for writing a Tire class:
1. A private class for trie node. Members are:
    - `string Prefix {get; }` to store prefix till now.
    - `Dictionary<char, Node> Children {get; }`
    - flag ` bool isCompleteWord {get; set;}`
    - Constructor sets prefix and initializes hashmap.
2. A member variable for trie root, `Node root;`
3. A method to insert words to a trie: For each word
    - set current to root
    - Travelling through the word: If current doesn't contain current character as child, add it to the children hashmap.
    - Update current to be the node associated with current character.
    - If end of a string reached, set flag to true for current node.
4. Trie Constructor:
    - Initializes root
    - Adds given words to trie using step 3.

5. Pre DFS: Check if a given prefix is valid
    - Starting from current node set to root, travel through the length of the prefix string
    - If current node contains the current character as a child, update current node. 
    - If not the prefix is invalid => return null.
    - IF end of string of prefix reached return the current node.

6. DFS:
    - A recursive DFS starting from the current node returned by step 5.
    - Base condition: If current node is a complete word, add it to a list of words.
    - Recursive condition: For all children nodes of current node, start recursive call passing the child and results list.

7. Post DFS: Optional. Additional processing of results if required.