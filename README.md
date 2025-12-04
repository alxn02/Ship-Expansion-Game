1. Functional Requirements

Here are the main features I added:

2D ship movement with screen boundaries

Fuel system that drains over time and decreases on obstacle collision

Collectibles the ship can pick up (fuel cans, stars)

Score system that increases when collecting stars

Obstacle system that damages the ship

Continuous spawning for collectibles and obstacles

Basic collision interactions between the ship and all game objects

UI that displays updated fuel and score values

2. Class List & Descriptions

Ship – player movement, fuel drain, score, collisions

Collectible (base class) – parent for all collectible items

FuelCanister – refuels the ship and gives points

Star – increases score

Obstacle – damages the ship on contact

CollectibleSpawner – spawns stars and fuel at random positions

ObstacleSpawner – spawns obstacles at intervals

SpawnerManager – organizes and manages spawn systems

UIManager – updates and displays fuel and score UI

3. Data Structures Used

The following are the data structures used in this project:

List<Collectible> – storing collectible references

List<Obstacle> – tracking active obstacles

Dictionary<string, float> – storing fuel type values (via Fuel class)

Queue<float> – storing recent fuel usage entries

4. UML Diagram

My UML diagram shows the main classes (Ship, Collectible, FuelCanister, Star, Obstacle, Spawners, UIManager) and how they relate through inheritance and composition.


5. Weekly Progress – Week 1

Defined project scope

Wrote functional requirements

Created class list and design

Built initial UML diagram

Planned features and data structures

6. Week 2 Progress Report — Alan’s Team

What I completed this week:

Implemented all main classes (Ship, Collectibles, Obstacle, Spawners, UI).

Added movement, fuel drain, score tracking, and collision systems.

Added collectible and obstacle spawning with adjustable timing.

Updated the UML diagram to reflect new classes and relationships.

Organized scripts and prepared for the week’s demo.

Wrote initial unit test ideas for key methods.

7. Challenges

Keeping class relationships aligned with OOP principles.

Choosing appropriate data structures for each system.

Fixing collision inconsistencies between 2D triggers.

Balancing spawn timers for gameplay difficulty.

How I solved them:

Refactored scripts to simplify responsibilities.

Finalized correct data structures (List, Dictionary, Queue).

Switched all collisions fully to 2D physics.

Tuned spawn rates and added screen boundaries.

Not having a partner or more to work on the project with

8. What’s Next (Next Week's Plan)

Finish implementing enemy AI behavior (ChaserEnemy).

Add new collectible types or power-ups.

Improve UI display and polish gameplay.

Add difficulty scaling.

Complete unit tests for all implemented classes.

Record the updated demo video.

9. How to Run the Project

Open the Unity project in Unity 2022 or newer.

Press Play to test movement, fuel drain, score, and interactions.
