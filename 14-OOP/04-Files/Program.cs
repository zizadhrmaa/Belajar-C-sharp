using System.IO;  // include the System.IO namespace

string writeText = "Hello World!";  // Create a text string
//filename.txt bakal masuk ke folder yang sama kayak path terminalnya 
File.WriteAllText("filename.txt", writeText);  // Create a file and write the content of writeText to it
string readText = File.ReadAllText("filename.txt");  // Read the contents of the file
Console.WriteLine(readText);  // Output the content

/*
Method: AppendText()
Description: Appends text at the end of an existing file

Method: Copy()
Description: Copies a file

Method: Create()
Description: Creates or overwrites a file

Method: Delete()
Description: Deletes a file

Method: Exists()
Description: Tests whether the file exists

Method: ReadAllText()
Description: Reads the contents of a file

Method: Replace()
Description: Replaces the contents of a file with the contents of another file

Method: WriteAllText()
Description: Creates a new file and writes the contents to it. If the file already exists, it will be overwritten.
*/