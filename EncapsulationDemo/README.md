# EncapsulationDemo

This program demonstrates the concept of Encapsulation in object-oriented programming (OOP) using a simple BankAccount class.

## OverView

Encapsulation is one of the  principles of OOP, which involves restricting 
access to the internal state and behavior of an object while exposing only the necessary
details through public methods or properties. This ensures data integrity and hides
implementation details from the user.

### In this program:

- A BankAccount class encapsulates the properties AccountHolderName and Balance.
- Access to these properties is controlled through:
- - Read-only properties.
- - public methods (Deposit, Withdraw, and GetBalance) to interact with the data securely.
	
	- #### Expected Output

	- - - amount = 2000 is deposited in your account
- - - 3000 has been withdrawn from your account
- - - 4000 is your Balance in your bank  account
- - - You can only withdraw with in the range you have in your account
- - -System.ArgumentException: Please Enter the Valid Amount
   at EncapsulationDemo.BankAccount.Deposit(Decimal amount) in C:\Users\subia\OneDrive\Desktop\Intern\OOP-Demo\EncapsulationDemo\BankAccount.cs:line 45
- - -amount = -500 is deposited in your account