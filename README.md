## Cheque Writer Util
- A utility library for converting numbers/monies into its string representation suitable for writing into paper cheques.
- This solution is built using .NET Core 3.0 in Windows environment. 
- I didn't test it non-windows environment, so I can not tell if it will run as expected for non-windows.

### There are 3 projects in this solution.
1. ChequeWriter > a console app for user to test the application.
2. ChequeWriterLib > library containing the core logic of the application. 
3. TestChequeWriterLib > test suites for unit testing

### Pre-requisites
.NET Core is required to build and run the application. 
You can download .NET Core [here](https://dotnet.microsoft.com/download).

### How to Run the Application?
* Clone this repository to directory of your choosing. 
* Go to **`ChequeWriter`** folder
* Enter **`dotnet build`**.
* Enter **`dotnet run`** - It should run the application and ask you to enter numbers to test. 
* Enter **`quit`** to exit the application. 

### How to Run the Test suites? 
1. Go to **`TestChequeWriterLib`** folder 
2. Enter **`dotnet test`**. It should run and display the test results. 


## Author's Note: 

I think the solution is complete given the requirements to support up to 2 billion and with 2-decimal places only. 
There are more than 50 unit tests in the application which I expect to cover all possible scenarios.
It is maintainable. Adding support to larger amount can be done easily by adding additional group convension in `GetGroupSuffix` function, ex. trillion.
The contraints to check for maximum 2 billions need to adjust as necessary. 

If I had the time, I would further improve the application to support different locales and currencies. 
For example, in some countries they use "," instead of "." as decimal separator.
