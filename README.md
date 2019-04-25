<img src="https://video-images.vice.com/articles/592c3e62506abb44a68e9ad0/lede/1496072037917-Colossal_Cave_Adventure_on_VT100_terminal.jpeg">

# Unity Examples: 2D Text Interaction

Text interaction examples for Adventure type games (aka sturdy-barnacle). The source code for the text based games on the the UC Berkeley 2BSD Unix distribution tape is on [GitHub](https://github.com/msharov/bsd-games).

We will look at three approaches:

1. A simple dialogue area created using the [Unity UI system][ui] Text and Input Area elements.
1. Adding a separate UI camera to "display" the dialogue area.
1. Speech bubbles created with a speech bubble sprite and a text area.

## Simple Dialogue Area

This in new, so lets keep it simple. Our ultimate goal is to be able to display messages and read in responses from the user - and then to respond to the user's input. Let's break that down into a few smaller goals:

* Set up the dialogue area.
* Display a message to the user.
* Get a response from the user.
* Act on the user's response.

### Setting up the dialogue area

The UI elements are all children of a Canvas game object that is created when you create the first UI element. An EventSystem game object is created at the same time. The Canvas is required, the EventSystem is not (although it may turn out to be useful).

Start off by creating a UI Text element, this will be where our output (messages to the user) goes. When you create the Text element a Canvas will also be created. The *Render Mode* of the Canvas will be set to *Screen Space - Overlay* and the UI elements will most likely be "out in right field." Getting started working with the UI system is easier if you change the Render Mode to *Screen Space - Camera*, after you do that drag the Main Camera into the *Render Camera* field.

### Display a message to the user

### Get a response from the user

### Act on the user's response

## Simple Dialogue Area With UI Camera

* Dialog camera
* UI system
* UI system settings

## Speech Bubbles

## Tutorials

### Unity Live Trainings
* [Live Session: Text Adventure Game Part ](https://learn.unity.com/tutorial/5c514cacedbc2a0020694a0c)
* [Speech Bubbles and Popup UI](http://unity.grogansoft.com/speech-bubbles-and-popup-ui/)
