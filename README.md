# Determining-DNA-Health-algo
This code tries to solve the DNA Health issue but has a number of problems such as incomplete query processing and slow substring matching. The algorithm projects genes to their health values but applies a brute-force strategy that tries all possible substrings against the gene dictionary. It doesn't effectively handle the query range filtering and would be too slow for big input since its O(n³) way of generating substrings is very inefficient.

