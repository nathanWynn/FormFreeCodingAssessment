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

## Assessment 3

Write a C# application that solves the following problem:

* Take, as input, the path to a file containing one integer per line. For each
integer in the file, output to the console a comma-delimited list of the
integer's prime factors. The list of integers on each line of the output should
multiply to produce the integer.

* Support your application with unit tests.

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
2. Write a SQL query to pull all customers that have orders (no duplicates).
3. Write a SQL query to pull all customers that do not have orders.
4. If you had to create an index on these tables, which fields would you most
likely index, and why?
5. Write a query that lists each customer name, email, and the number of orders
they have.
6. Write a query that pulls all customers that have between 2 and 5 orders.
