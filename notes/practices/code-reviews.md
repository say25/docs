# Code Review

1. Pattern Variation

- Is it a new pattern to the code base
- How many "like patterns are there"?
    - DataAccess for example

1. Code Removal

- Is it the last in codebase place being used
- Is it the only in file place being used

1. Pattern/Contract Modification

- Why?
- Is it a breaking change?

1. Changing Accessibility

- Less accessible is better

1. External Dependencies

- Examples: NuGet/Maven/NPM
- Trimming Dependencies
    - Library A -> Library B -> Library C
    - If you trim library C it "trickles down" make sure its ok
- Runtime or compile time?
- Custom vs Open Source

1. Naming

``csharp
var enrollmentService = new EnrollmentService()
```

1. Analyzing the Big Picture for Easy Win

- Critical bug
- Remove deprecated code
- Clean warnings

1. Separation of Concerns

- Web tier, vs business tier, data tier

1. Code Style

- `.editorconfig`

1. What Else Is Impacted

- Are files shared?

1. What are the implications of the change?

1. Who

- Coder should sorta know who to ask/has context
- Code reviewer they should ask for context when needed
- Code reviewer should defer to other experts if possible
- Both should include others for learning opportunities
- Just because coder is "legendary" doesn't you blindly approve

1. Lifetime Modification

- Singleton, Scoped, Transient
