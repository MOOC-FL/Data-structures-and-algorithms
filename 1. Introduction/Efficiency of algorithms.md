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




