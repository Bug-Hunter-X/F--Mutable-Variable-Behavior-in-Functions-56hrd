# F# Mutable Variable Behavior in Functions

This example demonstrates a common misunderstanding in F# regarding mutable variables and function parameters.  In this example, the `addOne` function does not modify the original `x`. Instead, it creates a new value `y` which is one greater than the value of `x`.

The `addOneInPlace` function, on the other hand, uses a mutable reference and directly modifies the value of `z`.