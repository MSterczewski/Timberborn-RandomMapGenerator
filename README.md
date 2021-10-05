
# Random map generator

A work in progress project for generating random maps for timberborn.
Unfortunately in order to walkaround source code when a user tries to create a new map, he will create a random one, hence the ability of creating a non-random map is disabled.

Before we load a map to the creator, we create a json file with some hardcoded values and heights generated randomly from algorithm discussed in the next section.
# Generating map algorithm
I have prepared a few generators for maps. All of them implement `IMapGeneratorModule`. In order to switch to an older version of a generator, you need to change the module in `TemporaryMapGenerator` constructor. 
The newest version of the generator is included in that class. 

Below I will list all the generators in the orded of newest to oldest:
## Normal distribution map generator
A generator that create a random heightmap of size [w,h]. Size range is [1,7] with the highest chance of obtaining height=4. Height is distributed using normal distribution.
## Simplest map generator
A generator that create a random heightmap of size [w,h]. The size range is [3,5] - modifiable in respected classes.


# Installation
In order to install the mod follow the instructions from BepInEx website:
https://docs.bepinex.dev/articles/user_guide/installation/index.html
    
# Feedback

If you have any feedback, please reach out to me at discord MSterczewski#0889

  
# Authors

- [@MSterczewski (aka Informati)](https://github.com/MSterczewski)

# Changelog
## v0.0.4 Added a new generator

  