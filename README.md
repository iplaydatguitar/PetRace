# PetRace

This project is made available as a pre-screening exercise for candidates interviewing for software developer positions with SnapAV. Please thoroughly review the information below to ensure your pre-screening submission is evaluated effectively. Careful attention to following instructions is an important part of our evaluation.

## General Instructions

1. Fork this repository, and clone your fork
2. Modify the code as requested for each exercise below
3. Complete the exercises in the order they are given
4. DO NOT delete the branches that you create for each exercise when merging them to main
5. Make sure your forked repository is public
6. Provide a link to your forked repository to those who provided the link to this repository

Once you complete step #5 the hiring manager and team will review your repository within two business days. 

## Domain Description

I have several pets in my home: 2 dogs, 2 cats, 2 birds, and 1 snake. It's true. I'd like to be able to race them against each other, but for obvious reasons, that might not be a good idea. So I measured the speed of each type of pet and wrote this class to help me calculate which pet would win a hypothetical race. A `Pet` is created with a `PetType` and an initial location expressed as a two-dimensional coordinate (`Vector2`). 

NOTE: There is no mechanism provided for actually executing a race. Adding a class to coordinate a race is an optional task in exercise 3, but you are welcome to add a Race class at any time.

## 1. Design Exercise

The implementation of the Pet class has a number of design problems. Review the design of the `Pet` class and provide recommendations for how the design could be improved.

### Instructions
1. Create an `exercise1` branch from the `main` branch
3. Add code comments to the `Pet` class pointing out specific design problems and propose a strategy for improving the design.
4. DO NOT make changes to the code at this time 
4. Commit your changes to the `exercise1` branch, merge it to `main` and push to your forked repository 
5. (Reminder: do not delete the `exercise1` branch after merging to main)

## 2. Programming Exercise

My son wants a fish. Not just any fish. A shark. Sigh. Extend the Pet class to support fish.

### Instructions
1. Create an `exercise2` branch from `main`, which should contain the changes from the first exercise
2. Within the contraints of the curent implementation, add support for racing fish. Note that fish swim, they do not walk, fly or slither.
3. Do not add any new source files or classes.
3. Add code comments pointing out specific challenges related to this exercise. 
4. Commit your changes to the `exercise2` branch, merge it to `main` and push to your forked repository
5. (Reminder: do not delete the `exercise2` branch after merging to main)

## 3. Refactoring Exercise

Refactor the solution to allow each pet to travel at it's own speed. For example, my 2 year old husky is a lot faster than my 10 year old pitbull-terrier mix, but they're both dogs. 

### Instructions
1. Create an `exercise3` branch from `main`, which should contain the cummulative changes from the previous two exercises
2. Refactor this implementation to address the problems you identified in the first two exercises
3. Update the solution to support discrete speeds for each pet 
4. Feel free to create any additional source files and classes needed to refactor the solution.
5. Use code comments liberally to describe how the refactored design addresses the problems you identified
6. (optional) Add a `Race` class that sets up and executes a race
7. (optional) Add unit tests for all classes in the resulting solution
8. Commit your changes to `exercise3`, merge it to `main` and push to your forked repository

