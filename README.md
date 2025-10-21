# in-class-activities
## Devlogs
### W1
After moving the camera off the Cat object, the camera stays in place and no longer follows the Cat. This is because the camera is no longer attached to the Cat + the movement controls are attached to the Cat and not the camera, so the camera stays in place while the Cat moves freely.

### W2
1. The r, g, b variables are floats because color values come out as decimals and therefore are fractionals. Floats hold fractionals, unlike all other variable types.
2. The _bounce variable is an int because it stores the number of bounces which is a whole number. 
3. In Step 4 of the code, the error was that there was a missing semicolon in "g -= 0.1f" and there was a missing "f" in "g = 1.0".

### W3
Table #15: The parameter for SetLightDimness would be an int representing the player's sanity level as it goes from 0%-100%. The return type would be void as it simply updates the brightness level value rather than returning a value.

### W4


## Open-Source Assets
### W1
- Animals: https://assetstore.unity.com/packages/3d/characters/animals/animals-free-animated-low-poly-3d-models-260727 
- Low-poly environment: https://assetstore.unity.com/packages/3d/environments/landscapes/low-poly-simple-nature-pack-162153 