# FlappyBirdySmart
This is a Unity project I made to get a better understanding of implementation of Unity's ML-Agents library(v0.15)
![Gif](https://media.giphy.com/media/fUSx2pEdWvoYB3SmxL/giphy.gif)
## Installation
1. Unity 19.3.0f6
2. MLAgents Toolkit 0.15
3. Python 3.7
4. Tensorflow 2.0.1

## Overview of the game mechanics
* A replica from the popular game [Flappy Bird](http://flappybird.io/)
* The bird can sort of fly up to avoid the obstacles
* The gravity pulls the bird down
* The obstacles are spawned randomly with variation in gaps between them

## Assets:
* The backgrounda and obstacles (pipes) created using GIMP
* The bird sprites used from [xstrack1's assets](https://github.com/xstreck1/Flappy-Agents)

## ML Agents(v0.15)
* Unity's mlagents toolkit, made for creating a game AI
* Please refer to the official description and setup [here](https://github.com/Unity-Technologies/ml-agents)

## Performance
* The Ai currently plays the game without crashing for about 400 seconds, still further training is required and more tweaking of the hyperparameters

## To See the AI play the game
* On the agent script in the editor make sure the model has been added just hit play andd watch it fly!
*Note: there are multiple models in the assets and currently i have added the model named **FlappyBirdMoreSensorsMoreGravity.nn**, not all the models are compatible as i have made changes in vector observations with different models to get the optimum performance*
