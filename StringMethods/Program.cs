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
