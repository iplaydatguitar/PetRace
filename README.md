# PetRace

This project is made available as a pre-screening exercise for candidates interviewing for software developer positions with SnapAV. Please thoroughly review the information below to ensure your pre-screening submission is evaluated effectively. Failure to follow the instructions given may result in being removed from considation for an open position.

## Participation Instructions

1. Fork this repository, and clone your fork
2. Modify the code as requested in the exercises below
3. Commit and push your changes to your forked repository
4. Make sure your forked repository is public
5. Provide a link to your forked repository to those who provided the link to this repository

IMPORTANT: Once you complete step #5 you response will be considered final.  It will be reviewed by the hiring manager and team within 48 business hours. Do not modify the repository once step #5 is complete. Doing so may jeopardize an objective evaluation of your work.

## Domain Description

I have several pets in my home: 2 dogs, 2 cats, 2 birds, and 1 snake. It's true. Sometimes I like to race them against each other but, for obvious reasons, I can't race them at the same time. So I measure the speed of each type of pet and do some simple math to simulate which pet would win. To facilitate this process I've written this simple class to help me. A `Pet` is created with a `PetType` and an initial location expressed as a two-dimensional coordinate (`Vector2`). 

NOTE: There is no mechanism provided for actually executing a race. None of the instructions below require you to actually build and run a program. However, if you wish to do so you may implement this scaffolding by adding a `PetRace.cs` file containing a class by the same name. DO NOT change any other code artifacts in this project unless specifically instructed to do so.

## 1. Design Exercise

This class has a number of design problems. Review the design of the `Pet` class and provide recommendations for how the design can be improved.

### Instructions
1. Restrict your work in this phase to the `BasicPet.cs` file
3. Add code comments to the `Pet` class pointing out specific design problems and propose a strategy for improving the design.
4. DO NOT make changes to the code at this time 
4. Add unit tests for all code artifacts in `BasicPet.cs`

## 2. Programming Exercise

Extend the Pet class to support fish.

### Instructions
1. Restrict your work in this phase to the `BetterPet.cs` file
2. Within the contraints of the curent implementation add support for racing Note that fish swim, the do not walk, fly or slither.
3. Add code comments pointing out specific challenges related to this exercise. 
4. Add unit tests for all code artifacts in `BetterPet.cs`

## 3. Refactoring Exercise

Refactor the solution to allow each pet to travel at it's own speed. For example, my 2 year old husky is a lot faster than my 10 year old pitbull-terrier mix. 

### Instructions
1. Restrict your work in this phase to the `BestPet.cs` file
2. Refactor this implementation to address the problems you identified in the first two exercises
3. Update the solution to support discrete speeds for each pet 
4. Feel free to create any additional code artifacts that you might need to refactor the solution but confine them to the `BestPet.cs` file
5. Use code comments liberally to describe how the refactored design addresses the problems you identified 
6. Add unit tests for all code artifacts in `BestPet.cs`
