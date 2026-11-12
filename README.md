\# Shopping Basket Calculator



\## Project Overview

This is a simple C# console application that calculates the total price of shopping basket items.



\## Technologies Used

\- C#

\- .NET 10

\- xUnit (Unit Testing)



\## Pricing Rules



| Item | Price | Offer |

|---|---:|---|

| Apple | 35p | No offer |

| Banana | 20p | No offer |

| Melon | 50p | Buy 1 Get 1 Free |

| Lime | 15p | 3 for the price of 2 |



\## Project Structure



\- `Program.cs` – Gets user input and displays the total.

\- `ShoppingBasket.cs` – Contains the shopping basket calculation and validation logic.

\- `ShoppingBasketCalculator.Tests/` – Contains unit tests.



\## How to Run



1\. Open the project folder in PowerShell.

2\. Run:



&#x20;  `dotnet run`



3\. Enter items separated by commas.



Example:



`Apple, Apple, Banana, Melon, Melon, Lime, Lime, Lime`



Output:



`Total Price: 170p`



\## How to Run Tests



Navigate to the test project folder and run:



`dotnet test`



\## Test Results



All 6 unit tests passed successfully.



\- Total: 6

\- Passed: 6

\- Failed: 0



\## Validation



\- Supports case-insensitive item names.

\- Handles an empty basket.

\- Rejects invalid item names.

\- Rejects a null basket.



