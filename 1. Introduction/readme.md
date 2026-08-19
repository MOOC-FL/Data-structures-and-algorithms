#### Introduction
- The aim of the course Data Structures and Algorithms is to advance your programming skills and teach you techniques and ways of thinking that help you in implementing programs that are correct and efficient in all circumstances.
- The course uses the Python language but the techniques taught on the course are applicable to other programming languages too. The course involves a lot of programming but some theoretical ideas and concepts are covered too.

#### What is an algorithm?
- An `algorithm` is a method for solving some computational problem. An `algorithm` implemented in some programming language can be executed on a computer.
- [ ] The **input** of an algorithm is the initial data provided to the algorithm.
- [ ] The **output** of an algorithm is the answer produced by the algorithm by the end of its execution.
> In Python an algorithm can be implemented as a function, and then typically the input is given as the function parameters and the output is the return value.

- Let us consider an example, where the algorithm is given a list of numbers and the task is to count how many of the numbers are even. For example if the list is `[5, 4, 1, 7, 9, 6],` the desired answer is 2, because 4 and 6 are the even numbers.
- This task can be solved with an algorithm that goes through the numbers on the list and maintains a variable that stores the count of even numbers seen so far. The algorithm can be implemented as a Python function count_even:
```py
def count_even(numbers):
    result = 0
    for x in numbers:
        if x % 2 == 0:
            result += 1
    return result
```
- The function can be tested with the following main program:
```py
print(count_even([1, 2, 3])) # 1
print(count_even([2, 2, 2, 2, 2])) # 5
print(count_even([5, 4, 1, 7, 9, 6])) # 2
```
- Here the function is tested with three different lists. For each test, the desired answer is given as a comment at the end of the line. When the program is executed, it prints out:
```text
1
5
2
```
- Thus the function produces the desired output, at least for these three lists, and it seems we have created a correctly working algorithm for the task.
#### What is a data structure?
1. A data structure is a way of storing data within a program.
2. The basic data structure in Python is the list, but there are many other standard data structures too.
3. The choice of data structures is an important part of designing an algorithm, because the data structures have a big effect on the efficiency of the algorithm.
> On this course, we learn about many data structures and their uses in designing algorithms. We cover many standard Python data structures, and learn to implement data structures not provided by Python or other programming languages.





