# FormFree Coding Assessment

## Summary

The purpose of these challenges is for the __FormFree__ development team to gain
insight into _how_ you develop software.

Please, craft these answers as if you were writing production software: follow
the best practices, patterns, and maintainability aspects of development that
come with production quality and enterprise-grade code. Be as thorough as you can.

---

## Assessment 1

Write a C# application that solves the following problem:

* Take in three integer inputs, representing the sides of a triangle, and return
the triangle type (Scalene, Isosceles, Equilateral).

* Support your application with unit tests.

### Solution
See `TriangleTypeLibrary` for implementation details. Used factory method to
return the appropriate triangle object based on the integer parameters. Unit
tests are located in `UnitTests/TriangleTypeLibraryTests.cs`.

## Assessment 2

Write a C# application that solves the following problem:

* Return the fifth element __from the end__ of a singly linked list of integers.
Do not iterate the list more than once. Assume the list size cannot be known
without traversing the list.

***Note: You must __only__ use your `LinkedList` data structure to solve this problem.
You are not allowed to use any language provided data structures, like `List` or `Dictionary`.***

* Support your application with unit tests.

* Solve the same problem above, but assume the linked list contains strings
instead of integers.

### Solution
See `LinkedListLibrary` for implementation details. Used generics rather than
implementing `IntLinkedList` and `StringLinkedList` seperately. Unit tests are 
located in `UnitTests/LinkedListLibraryTests.cs`.

Approach: Let one pointer traverse 5 nodes (if it can). Once it has, let another
pointer traverse from the start of the list while the lead pointer traverses to the end. Once the
first pointer reaches the end of the list, the new pointer will be at the fifth
element from the end.

## Assessment 3

Write a C# application that solves the following problem:

* Take, as input, the path to a file containing one integer per line. For each
integer in the file, output to the console a comma-delimited list of the
integer's prime factors. The list of integers on each line of the output should
multiply to produce the integer.

* Support your application with unit tests.

### Solution
See `PrimeFactorizationLibrary` for implementation details. Unit tests are
located in `UnitTests/PrimeFactorizationLibraryTests.cs`

Approach: I first tried a [Sieve of Eratosthenes](https://en.wikipedia.org/wiki/Sieve_of_Eratosthenes) 
approach by precomputing all of the smallest prime factors for every number
ahead of time. I thought that this approach would save time by avoiding re-computing
the smallest prime factor for a given number, but ran into memory issues. Later,
I learned that this approach is only viable for smaller primes.

The approach I ended up using was a simpler iterative function that finds the smallest
prime number that the input number is divisible by, and dividing the input number by the prime.
I decided to return a nested list rather than log to the console straight from the library
to make testing a bit easier.

## Assessment 4

Given a database with the following structure:

```
+------------------------------------------------------------------------------+
| Customers                                                                    |
+------------------------------------------------------------------------------+
| id         | name       | address       | phone_number        | email        |
+------------------------------------------------------------------------------+
```
```
+------------------------------------------------------------------------------+
| Orders                                                                       |
+------------------------------------------------------------------------------+
| id           | customer_id       | order_amount       | order_address        |
+------------------------------------------------------------------------------+
```

Perform the following:

1. Write a SQL query to pull all customers.
```
SELECT id 
FROM Customers
```
2. Write a SQL query to pull all customers that have orders (no duplicates).
```
SELECT DISTINCT customer_id
FROM Orders
```
3. Write a SQL query to pull all customers that do not have orders.
```
SELECT customer_id
FROM Customers c
WHERE NOT EXISTS
  (SELECT *
   FROM ORDERS o
   WHERE c.id = o.customer_id)
```
4. If you had to create an index on these tables, which fields would you most
likely index, and why?

Good indexes are columns that are used frequently to narrow down search criteria.
The ideal index for the Customers table is `id` and the ideal index for the Orders
table is `customer_id`. Common lookups of these tables would most likely answer 
one of the following questions:
- Whose order is this?
- What orders does this customer have?

or any other query that requires linking a customer to an order. Performing queries
on the Orders table with no knowledge of the relevant customers would likely be an
uncommon operation. Additionally, performing queries on the Customers table would
most likely require some knowledge of what orders they’ve placed (e.g. “Find the
emails for customers with an order amount > X in order to send them a thank you
message”).  Adding indexes to many columns would increase insert time, and for
columns whose uniqueness is irrelevant, an index would not be as useful.

5. Write a query that lists each customer name, email, and the number of orders
they have.
```
SELECT c.name, c.email, COUNT(o.customer_id) AS order_count
FROM Customer c LEFT JOIN Orders o ON (c.id = o.customer_id)
GROUP BY c.id
```
6. Write a query that pulls all customers that have between 2 and 5 orders.
```
SELECT COUNT(o.id) AS order_count, o.customer_id
FROM Orders o
GROUP BY o.customer_id
HAVING COUNT(o.id) > 2 AND COUNT(o.id) < 5
```
