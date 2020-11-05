Feature: Trigonometry
	In order to answer difficult trigonometric questions
	As a math idiot
	I want to be told the correct calculation for Pi, Sin, Cos, Tan

Scenario: calculate sinus
	Given a number is Pi
	When the sinus is calculated
	Then the result should be 0

Scenario: calculate cosinus
	Given a number is Pi
	When the cosinus is calculated
	Then the result should be -1

Scenario: calculate tangens
	Given a number is Pi
	When the tangens is calculated
	Then the result should be 0