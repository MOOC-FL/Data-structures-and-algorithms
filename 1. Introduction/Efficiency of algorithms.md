#### Efficiency of algorithms
- The same task can be solved by different algorithms, and there can be big differences in their efficiencies. Often the goal is to find an efficient algorithm that solves the task quickly.
- Let us consider a task, where we are given a list of numbers, and the goal is to find the largest difference between any two numbers. For example, when the `list` is `[3, 2, 6, 5, 8, 5]`, the desired answer is `6`, because the largest difference is between the numbers 2 and 8.
- Three algorithms for solving the task are given below:
```py
def max_diff(numbers):
    result = 0
    for x in numbers:
        for y in numbers:
            result = max(result, abs(x - y))
    return result
```
> The first algorithm has two nested for loops that go through all ways of choosing two numbers from the list. The algorithm computes the difference using the `abs (absolute value)` function and remembers the largest difference it has encounter so far.
```py
def max_diff(numbers):
    numbers = sorted(numbers)
    return numbers[-1] - numbers[0]

```
- The idea of the second algorithm is that the biggest difference must be between the smallest number and the largest number on the list.
- The algorithm first sorts the list using the sorted function. Then the smallest number is in the beginning (index 0) and the largest is at the end (index -1) of the list.
```py
def max_diff(numbers):
    return max(numbers) - min(numbers)

```
- The third algorithm is based on finding the smallest and largest numbers too, but instead of sorting, it uses the functions min and max.







