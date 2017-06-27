### Syzygy Anagram Tester
------

A console application that leverages a library and a small set of unit tests to check edge cases
in word comparisson.

Flow:

- Reads the file line by line and separates the words from eachother using basic LINQ.
- Then iterates over the words and puts them in a dictionary `WordDictionary` so to ensure 
  that we don't have to iterate over the whole .csv file to find matches. (limits iteration scope)
- Iterates over each individual dictionary to find anagrams by scrambling / sorting each word and comparing them
- Prints the results to the console and to a file "Anagrams.txt" that should be created in the CL-App's output.

To test it simply run the tests, then run the console application `Syzygy.App`.
