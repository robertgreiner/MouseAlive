Feature: Mouse Utilities
	In order to keep the screen saver from activating
	As a remote support agent
	I want to have the mouse moved for me automatically

Scenario: Move Mouse
	Given I am working on a machine with MouseAlive
	When a certain amount of time has elapsed
	Then the mouse should move automatically
