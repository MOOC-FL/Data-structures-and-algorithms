#### Implementing an algorithm
- Any algorithm can be implemented with a few basic programming constructs. In Python, these basic constructs are:
  - variables
  - operators (+, = etc.)
  - conditionals (if)
  - loops (for, while)
  - lists
  - functions
  - classes
> In addition to these, programming languages have many other features that can help shorten the code, but do not affect the fundamental operating logic of the code. They can be used in implementing algorithms but are not necessary.

- Let us return to the earlier example function `count_even` that was implemented with the basic constructs:
```py
def count_even(numbers):
    result = 0
    for x in numbers:
        if x % 2 == 0:
            result += 1
    return result
```
- This can be implemented more compactly with a **special Python construct**, the generator expression:
```py
def count_even(numbers):
    return sum(x % 2 == 0 for x in numbers)
```
- [ ] Here the `sum` function encloses a generator `expression` that computes the value of the expression `x % 2 == 0` for each element `x` of the `list`.
- [ ] The possible values are `True` and `False`, but when they are summed up, each `True` is counted as the number `1` and each `False` as the number `0`.
- [ ] Thus the result of the summation is the count of even numbers.

- The latter function is much shorter but its fundamental operation is the same as the former one’s.
- Both functions go through the numbers on the list and add up the times when an even number is encountered.
- The operating logic is essentially the same in both cases.

> The advantage of the first function is that it is easier to explain to a person who is not familiar with Python special constructs. The function could be easily translated into other programming languages, for example JavaScript:
```javascript
function countEven(numbers) {
    let result = 0;
    for (let x of numbers) {
        if (x % 2 == 0) result++;
    }
    return result;
}
```
> The advantage of the second function is that is more concise and perhaps more in the style of **Python** language. Even though the basic constructs are sufficient, it can be interesting to learn more special constructs too.

