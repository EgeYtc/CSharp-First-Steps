# Balanced Braces Problem

A C# solution that checks whether a string of brackets is balanced using two stacks.

## Problem Description

Given a string containing the characters `(`, `)`, `[`, `]`, `{`, `}`, determine whether the brackets are balanced. A string is balanced if:

- Every opening brace has a corresponding closing brace of the same type
- Braces are properly nested (inner pairs close before outer pairs)

## How It Works

The algorithm uses **two stacks** to validate the string:

### Step 1 — Collect Closing Braces (Forward Pass)
A `foreach` loop iterates left to right over the string and pushes every closing brace (`)`, `]`, `}`) onto `stackOfClosingBraces`.

### Step 2 — Collect Opening Braces (Reverse Pass)
A `for` loop iterates right to left over the string and pushes every opening brace (`(`, `[`, `{`) onto `stackOfOpeningBraces`.

Iterating in reverse mirrors the natural nesting order so that when both stacks are popped, matching pairs align correctly.

### Step 3 — Early Exit Check
If the total count of both stacks is odd, the string cannot be balanced and `false` is returned immediately.

### Step 4 — Pair Comparison
A `while` loop pops one character from each stack and checks if they form a valid pair:
- `)` must match `(`
- `]` must match `[`
- `}` must match `{`

If any pair mismatches, `false` is returned. If all pairs match, `true` is returned.

## Example

```
Input:  "{{[]}}"

Closing stack (left→right):  }, }, ]
Opening stack (right→left):  [, {, {

Pop pairs:
  } vs {  ✅
  } vs {  ✅
  ] vs [  ✅

Result: true
```

## Known Limitation

The two-stack approach does **not** handle cases where a closing brace appears before any opening brace (e.g. `}{`). The counts balance out so the algorithm incorrectly returns `true`. The classic fix is a single-stack approach:

```csharp
foreach (char c in inputString)
{
    if (c == '(' || c == '[' || c == '{')
        stack.Push(c);
    else
    {
        if (stack.Count == 0) return false; // closing brace with nothing open
        char top = stack.Pop();
        if ((c == ')' && top != '(') ||
            (c == ']' && top != '[') ||
            (c == '}' && top != '{'))
            return false;
    }
}
return stack.Count == 0;
```

## Usage

```csharp
Debug.WriteLine(IsBalanced("{{[]}}").ToString()); // True
Debug.WriteLine(IsBalanced("(([]").ToString());   // False
```

## Concepts Practiced

- Stack data structure (LIFO)
- Two-pointer / two-pass traversal
- String parsing
- Edge case analysis in algorithm design
