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
#### Describing Code Activity
Table #15

1. Line 17: _isGrounded is a member variable, and the type is bool. This line declares _isGrounded and sets its value to true, and is presumably referring to whether or not the Cat is on the ground.
2. Line 28: This line is an if statement that checks if the key currently pressed is the space bar AND _isGrounded is true. It checks if the current key pressed is specifically the space bar by calling the GetKeyDown method from the Input class with the parameter of KeyCode.Space, which presumably returns true or false depending on if the key in the parameter is pressed down. 
3. Line 32: This line sets _isGrounded to false if the conditions for the if statement are met. 
#### Collision Discussion Activity
1. Both the Cat and the SoccerBall have Rigidbodies and the Goal has Is Trigger checked. Both the Cat and the SoccerBall need a Rigidbody so that Unity can simulate physical collision with them, thus allowing the Cat to kick the SoccerBall and for the SoccerBall to move when the Cat touches it. The Goal needs the Is Trigger option checked because the SoccerBall needs to be able to pass through it, thus requiring an invisible collision rather than a physical one.
2. N/A, code worked!

### W5
#### Activity 1: Collaborative Learning
Q: What will return when GetComponent() is called with a conflicting type/component? Ex: BallW3 ball = someObject.gameObject.GetComponent<Pizza>(); Would it return a null or an error?  
A: Didn't get answered, but assume that it would return an error due to type conflict.

Other Q&A: Translate refers to moving in Transform component, moves based on floats and stuff

#### Activity 2: Pair Programming
1. Member variable(s): [SerializeField] private Transform _destination (store transform of destination)
2. Method(s): Start()  
3. What method(s) do: 
    Start(): runs at the beginning, set NavMeshAgent + _destination, set destination for NavMeshAgent to walk towards

### W6
#### Activity 1: Class Resource Guide
Category: Unity Engine  
[Link to doc](https://docs.google.com/document/d/12El8B1DVwCrcYU4DHfi3xilsWEET20KrlgRqnEkWHi4/edit?usp=sharing)

#### Activity 2: Pair Programming
- should have a [SerializeField] private float _speed  
- DisableChase() to disable bats  
- EnableChase() to enable bats  
- private Transform to store player location  

### W7
#### Activity 1: Designing a Game Engineering Plan
Role: Gameplay/UI  
[Link to doc](https://docs.google.com/document/d/12El8B1DVwCrcYU4DHfi3xilsWEET20KrlgRqnEkWHi4/edit?tab=t.n15fr0ty9u79)

#### Activity 2: Visualizing Coordinate Spaces
- muskrat should rotate around y-axis, use Vector3.up as a multiplier in the transform.Rotate  
  
Step 2 uses transform.position rather than transform.Translate to move the muskrat, which instead moves the muskrat forward and backwards based on fixed axes rather than the direction that the muskrat is facing. In other words, transform.position disregards rotation while transform.Translate does because it works in the muskrat's object space.

## Open-Source Assets
### W1
- Animals: https://assetstore.unity.com/packages/3d/characters/animals/animals-free-animated-low-poly-3d-models-260727 
- Low-poly environment: https://assetstore.unity.com/packages/3d/environments/landscapes/low-poly-simple-nature-pack-162153 