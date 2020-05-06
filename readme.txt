Driver usage:

The executable accepts an array of strings, with each string representing a path to a file
that should be read and parsed by the program.  For example, an input file named "inputFile.txt" 
should be put into the program as <drive letter>:/path/to/inputFile.txt. The program will create an 
output file in the same path that contains the requested information (the addition of the numerical
quiz grade average and the letter grade of the quiz average).  If an input path is invalid, the program 
will write to standard out that the input file path is invalid.  The program will continue to execute 
until all args (file paths) have either been read or attempted to be read.