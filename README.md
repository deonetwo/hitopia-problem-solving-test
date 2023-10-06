# 📋 HITOPIA - Problem Solving Test

A repository for restore the code to answer the problem solving test written in C#


## Running Test Case

To run the test cases, go to each directory with `cd` (ex: `cd case1`) from root folder and run the following command:

```bash
  dotnet run
```


## Solution

#### 1. Weighted Strings

![Weighted Strings](img/case1)

#### 2. Highest Palindrome 

![Highest Palindrome](img/case2)

#### 3. Balanced Bracket

![Balanced Bracket](img/case3)

## Solution No.3 Complexity

I assume that the complexity in question is the complexity of time and space.
### Time Complexity
In this case, I am using Stack to solve the problem. The operations inside the loop, including pushing and popping elements from the stack, are all `O(1)` operations when there is only one loop included, which is `O(n)`. That means that in the worst case, the code will iterate each character from the input string exactly once, performing constant-time operations within the loop. The `n` notation refers to the length of the input string.

### Space Complexity
Because of the stack I am using, in the worst case, the space complexity will increase linearly with the length of the input string. So, the notation will be `O(n)`, where `n` is the length of the input strings.
