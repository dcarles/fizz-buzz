### The application:
* Should be an MVC 4.0 or 5.0 project
* Should be correctly architected, as if this was a production application
* Should built using a 'test first’ methodology
* It is not important that you complete every step in the exercise
* It is important that all submitted code is of good quality. Refactor as necessary.
 
You have 2 hours to complete the exercise
 
**You must check in your code to Bitbucket every 10 minutes, without fail**
 
Also, check in your code after every step, and label it ‘Step 1’, ‘Step 2’ etc.
 
**DO NOT** share, print or distribute this exercise to any other person.

1- Basic Fizz-Buzz:

	a - The user should be able to enter a positive integer
	b -  You should print out, in a vertical list, all of the values between 1 and the entered value
	c - Where the number is divisible by 3, you should instead print ‘fizz’
	d - Where the number is divisible by 5, you should instead print 'buzz'
	e - Where the number is divisible by 3 AND 5, you should instead print ‘fizz buzz’

2 -Add validation to ensure the entered value is an integer between 1 and 1000 

* ADDED AS DATA ANNOTATION ALSO EXCEPTION INSIDE METHOD AND TESTED BY UNIT TESTING)

3- Add styling so 'fizz' is printed in blue, and 'buzz' in green

* ASSUMED THAT FIZZBUZZ SHOULD DISPLAY FIZZ HALF IN BLUE AND BUZZ HALF IN GREEN

4 - Change the logic so that if today is Wednesday, the words 'wizz' and ‘wuzz' are substituted for 'fizz' and 'buzz 

* Decided to do simple injection of DateTime.Now as a func instead of complicating with a time class that you can mock later as I dont think is needed for this simple project. Unit testing could be done better to avoid repetition

5 - Amend the program so only 20 values are displayed at a time. Implement ‘Next’ and ‘Previous’ buttons to display the remaining values.

* Used PagedList.MVC to implement this functionality

6 - A RESTful web service is required  to record the user entered values.Design and document this web service. Implement it as a mock or stub in your code. 

* DID NOT HAVE TIME TO IMPLEMENT THIS STEP