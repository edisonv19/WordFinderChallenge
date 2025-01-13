# WordFinderChallenge

## Technical detail notes

1. There is a IWordFinder interface with 2 methods: 
```
IEnumerable<string> Find(IEnumerable<string> wordStream)

char[,] Matrix { get; }
```
2. I have a WordFinder class that implements IWordFinder interface

3. WordFinder class constructor has a List of strings as parameter that convert it to a matrix
   - size of list will be the count rows
   - size of element list will be the count columns (all of elements has the same size)
   - if list size or element size is gretter that 64, the count of rows or columns will be 64 respectively

4. The Matrix method return the matrix. I use it in order to print the matrix

5. The Find method request a stream of words and does:
	 - remove the duplicate values from stream
	 - create a dictionary in order to set the count of word found in the matrix
	 - for each word in stream, I try to get the count of times that word appear in the matrix, getting the horizontal and vertical appears
		 - Horizontal: 
			 - loop through all rows, but is not neccesary to loop through all columns, because the elements to loop through should be greater or equal to stream word lengh.
			 - count the word found
		 - Vertical: 
			 - similar as Horizontal but in this case is not neccesary to loop through all rows.
			 - if stream word has 1 like a lengh (only one character), it was counted in horizontal method. For this reason, I return 0.
	 - Sort the dictionary by value and get the top 10
		
## Temporal complexity details
1. We have several nested loops.
	 - In the constructor, we have a loop through all rows and columns. In this case we have a temporal complexity O(C \* R), where C is size of columns and R is size of rows in the matrix.
	 - In Find method we have:
		 - a loop through all wordStream list (S)
		 - in horizontal and vertical method the complexity depends of word lengh in stream list (W)
			 - on the one hand, in horizontal we loop through all rows, but columns minus word lengh (C - W)
			 - on the other hand, in vertical we loop through all columns, rows minus word lengh (R - W)
			 - in the worst case, we have to loop through all columns and rows (when word stream leght equal to 1) (C \* R)
		 - in IsMatch method, we loop through for each character from the word (W)
2. In summary, This approach has a O(C\*R\*S\*W) temporal complexity, where:
   - **C**: size of columns
   - **R**: size of rows
   - **S**: size of word stream list
   - **W**: size of longest word in stream list
