// String Methods in C#
/*
There are a lot of methods we can work with strings so we will go ahead and
start with converting a string to upper case. We use ToUpper().
*/

String fullname = "Jared Maina";
Console.WriteLine(fullname.ToUpper());

/*
Converting it to lower case we ue ToLower(). 
*/
Console.WriteLine(fullname.ToLower());

/*
Next is using the Replace method to replace specific characters within a
string with different ones.
*/
String phoneNumber = "123-456-789";
String phonenumber = phoneNumber.Replace("-", ".");
Console.WriteLine(phonenumber);

/*
Next we use the Insert method to insert a character or even a string at a specific
index position of an existing string.
*/

String userName = fullname.Insert(0, "@");
Console.WriteLine(userName);

/*
Next isn't a method but a property but found in the exact same way anyway.
We are going to access the length of the whole string using the Length property.
*/

Console.WriteLine(fullname.Length);