# SimpleToken

A *very* simple library that generates readable random tokens. The tokens are strings that alternate between a lowercase consonant and a vowel, making them easy to dictate or to write on a piece of paper.

The total number of different possibilities with length $n$ is $20^{\lceil\frac{n}{2}\rceil} \cdot 6^{\lfloor\frac{n}{2}\rfloor}$. With tokens of length 10, that is $24883200000$.

It is advised that you check if a token has not been generated before.

## Nuget

I did this mainly to try out nuget so [here's the package](https://www.nuget.org/packages/SimpleToken/).
